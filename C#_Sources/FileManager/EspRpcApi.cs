using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.IO;

namespace FileManager
{
	public class EspRpcApi
	{
		private EspModule espModule;

		public EspRpcApi(EspModule espModule)
		{
			this.espModule = espModule;
		}

		public string Connect(String message)
		{
			return Connect(message,false);
		}
		public string Connect(String message,bool doNotWaitResponse)
		{
			try
			{
				// Create a TcpClient.
				// Note, for this client to work you need to have a TcpServer 
				// connected to the same address as specified by the server, port
				// combination.
				TcpClient client = new TcpClient(espModule.IP, espModule.Port);

				// Translate the passed message into ASCII and store it as a Byte array.
				Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

				// Get a client stream for reading and writing.
				//  Stream stream = client.GetStream();

				NetworkStream stream = client.GetStream();

				// Send the message to the connected TcpServer. 
				stream.Write(data, 0, data.Length);

				String responseData = String.Empty;
				if (!doNotWaitResponse)
				{

					// Receive the TcpServer.response.

					// Buffer to store the response bytes.
					data = new Byte[256];
					//System.Threading.Thread.Sleep(2000);
					// String to store the response ASCII representation.

					// Read the first batch of the TcpServer response bytes.
					Int32 bytes = stream.Read(data, 0, data.Length);
					responseData += System.Text.Encoding.ASCII.GetString(data, 0, bytes);
					//writeLineToLog(responseData);
				}

				// Close everything.
				stream.Close();
				client.Close();
				return responseData;
			}
			catch (ArgumentNullException e)
			{
				Console.WriteLine("ArgumentNullException: {0}", e);
				return "";
			}
			catch (SocketException e)
			{
				Console.WriteLine("SocketException: {0}", e);
				return "";
			}

		}


		int maxStrLengthForSaveOpeeration = 1024; 

		private void SaveStringToEspFile(string targetFileName, string strContent, bool isUpdate)
		{
			if (strContent.Length > maxStrLengthForSaveOpeeration)
				throw new Exception("strContent string is too long");
			string cmdStr;
			if (!isUpdate)
				cmdStr = string.Format("**command**{0}**\n{1}\n{2}", "Newfile", targetFileName, strContent);
			else
				cmdStr = string.Format("**command**{0}**\n{1}\n{2}", "Apdfile", targetFileName, strContent);
			Connect(cmdStr);
		}

		public void SaveFile(string path)
		{
			string[] flines = File.ReadAllLines(path);
			string buffer = "";
			bool isUpdate = false;
			string crlf = "\n";
			foreach (string line in flines)
			{
				if (buffer.Length + line.Length + crlf.Length < maxStrLengthForSaveOpeeration)
				{
					buffer += line + crlf;
				}
				else
				{
					SaveStringToEspFile(Path.GetFileName(path), buffer, isUpdate);
					isUpdate = true;
					buffer = line + crlf;
				}
			}
			SaveStringToEspFile(Path.GetFileName(path), buffer, isUpdate);
		}

		public EspFiles Dir()
		{
			string cmdStr = string.Format("**command**{0}**", "Dir");
			string strFileList = Connect(cmdStr);
			EspFiles espFilelist = new EspFiles(strFileList);
			return espFilelist;
		}


		public string ReadFile(string fileName)
		{
			int offset = 0;
			int len = 256;
			string fileBody = "";
			for (;;)
			{
				string cmdStr = string.Format("**command**{0}**\n{1}\n{2}\n{3}", "Readfile", fileName, offset, len);
				string buffer = Connect(cmdStr);
				fileBody += buffer;
				offset += len;
				if (buffer.Length < len || fileBody.Length > 32767) break;
			}
			return fileBody;
		}


		public void DeleteFile(string fileName)
		{
			string cmdStr = string.Format("**command**{0}**\n{1}", "delfile", fileName);
			Connect(cmdStr);
		}

		public void DoFile(string fileName)
		{
			string cmdStr = string.Format("**command**{0}**\n{1}", "dofile ", fileName);
			Connect(cmdStr);
		}

		public void Compile(string fileName)
		{
			string cmdStr = string.Format("**command**{0}**\n{1}", "compile", fileName);
			Connect(cmdStr);
		}

		public void Restart()
		{
			string cmdStr = string.Format("**command**{0}**", "restart");
			Connect(cmdStr,true);
		}



		public static void writeLineToLog(string message)
		{
			int maxLogSize = 520;
			string logStr = Properties.Settings.Default.LogBody;
			int newLogSize = logStr.Length + message.Length;
 			if (newLogSize>maxLogSize)
			{
				int delta = newLogSize - maxLogSize;
				int removedRowsSpace = 0;
				List<string> rows = new List<string>(logStr.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries));
				do
				{
					removedRowsSpace += rows[0].Length;
					rows.RemoveAt(0);				
				}while(removedRowsSpace<delta);
				logStr = rows.Aggregate((current, next) => current + "\r\n" + next);
				logStr += "\r\n";
			}
			DateTime now = DateTime.Now;
			Properties.Settings.Default.LogBody = logStr + string.Format("{0}\t\t{1} \r\n",now.ToString("HH:mm:ss") ,message);
		}

		public static bool Ping(IPAddress address)
		{
			// Ping's the local machine.
			Ping pingSender = new Ping();
			PingReply reply = pingSender.Send(address);
			if (reply.Status == IPStatus.Success)
			{
				return true;
			}
			else
			{
				return false;
			}
		}



	}

	public class EspModule
	{
		public string IP { get; set; }
		public Int32 Port { get; set; }

		public EspModule(string ip,  Int32 port)
		{
			this.IP = ip;
			this.Port = port;
		}

	}
}

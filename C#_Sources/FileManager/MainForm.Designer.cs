namespace FileManager
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsBtnSettings = new System.Windows.Forms.ToolStripButton();
			this.tsBtnRefresh = new System.Windows.Forms.ToolStripButton();
			this.tsBtnLog = new System.Windows.Forms.ToolStripButton();
			this.tsBtnCopy = new System.Windows.Forms.ToolStripButton();
			this.tsBtnAbout = new System.Windows.Forms.ToolStripButton();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.tsBtnRun = new System.Windows.Forms.ToolStripButton();
			this.tsBtnCompile = new System.Windows.Forms.ToolStripButton();
			this.tsBtnRead = new System.Windows.Forms.ToolStripButton();
			this.tsBtnEspDelete = new System.Windows.Forms.ToolStripButton();
			this.tsBtnRestart = new System.Windows.Forms.ToolStripButton();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridProject = new System.Windows.Forms.DataGridView();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastWriteTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastAccessTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fileInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridEsp = new System.Windows.Forms.DataGridView();
			this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.espFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.toolStrip1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.toolStrip2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridProject)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fileInfoBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridEsp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.espFileBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			resources.ApplyResources(this.toolStrip1, "toolStrip1");
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnSettings,
            this.tsBtnRefresh,
            this.tsBtnCopy,
            this.tsBtnLog,
            this.tsBtnAbout});
			this.toolStrip1.Name = "toolStrip1";
			this.toolTip1.SetToolTip(this.toolStrip1, resources.GetString("toolStrip1.ToolTip"));
			// 
			// tsBtnSettings
			// 
			resources.ApplyResources(this.tsBtnSettings, "tsBtnSettings");
			this.tsBtnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsBtnSettings.Name = "tsBtnSettings";
			this.tsBtnSettings.Click += new System.EventHandler(this.tsBtnSettings_Click);
			// 
			// tsBtnRefresh
			// 
			resources.ApplyResources(this.tsBtnRefresh, "tsBtnRefresh");
			this.tsBtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsBtnRefresh.Name = "tsBtnRefresh";
			this.tsBtnRefresh.Click += new System.EventHandler(this.tsBtnRefresh_Click);
			// 
			// tsBtnLog
			// 
			resources.ApplyResources(this.tsBtnLog, "tsBtnLog");
			this.tsBtnLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsBtnLog.Name = "tsBtnLog";
			this.tsBtnLog.Click += new System.EventHandler(this.tsBtnLog_Click);
			// 
			// tsBtnCopy
			// 
			resources.ApplyResources(this.tsBtnCopy, "tsBtnCopy");
			this.tsBtnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsBtnCopy.Name = "tsBtnCopy";
			this.tsBtnCopy.Click += new System.EventHandler(this.tsBtnCopy_Click);
			// 
			// tsBtnAbout
			// 
			resources.ApplyResources(this.tsBtnAbout, "tsBtnAbout");
			this.tsBtnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsBtnAbout.Name = "tsBtnAbout";
			this.tsBtnAbout.Click += new System.EventHandler(this.tsBtnAbout_Click);
			// 
			// tableLayoutPanel1
			// 
			resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
			this.tableLayoutPanel1.Controls.Add(this.toolStrip2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.dataGridProject, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.dataGridEsp, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.toolTip1.SetToolTip(this.tableLayoutPanel1, resources.GetString("tableLayoutPanel1.ToolTip"));
			// 
			// toolStrip2
			// 
			resources.ApplyResources(this.toolStrip2, "toolStrip2");
			this.toolStrip2.ImageScalingSize = new System.Drawing.Size(48, 48);
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnRun,
            this.tsBtnCompile,
            this.tsBtnRead,
            this.tsBtnEspDelete,
            this.tsBtnRestart});
			this.toolStrip2.Name = "toolStrip2";
			this.toolTip1.SetToolTip(this.toolStrip2, resources.GetString("toolStrip2.ToolTip"));
			// 
			// tsBtnRun
			// 
			resources.ApplyResources(this.tsBtnRun, "tsBtnRun");
			this.tsBtnRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsBtnRun.Name = "tsBtnRun";
			this.tsBtnRun.Click += new System.EventHandler(this.tsBtnRun_Click);
			// 
			// tsBtnCompile
			// 
			resources.ApplyResources(this.tsBtnCompile, "tsBtnCompile");
			this.tsBtnCompile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsBtnCompile.Name = "tsBtnCompile";
			this.tsBtnCompile.Click += new System.EventHandler(this.tsBtnCompile_Click);
			// 
			// tsBtnRead
			// 
			resources.ApplyResources(this.tsBtnRead, "tsBtnRead");
			this.tsBtnRead.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsBtnRead.Name = "tsBtnRead";
			this.tsBtnRead.Click += new System.EventHandler(this.tsBtnRead_Click);
			// 
			// tsBtnEspDelete
			// 
			resources.ApplyResources(this.tsBtnEspDelete, "tsBtnEspDelete");
			this.tsBtnEspDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsBtnEspDelete.Name = "tsBtnEspDelete";
			this.tsBtnEspDelete.Click += new System.EventHandler(this.tsBtnEspDelete_Click);
			// 
			// tsBtnRestart
			// 
			resources.ApplyResources(this.tsBtnRestart, "tsBtnRestart");
			this.tsBtnRestart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsBtnRestart.Name = "tsBtnRestart";
			this.tsBtnRestart.Click += new System.EventHandler(this.tsBtnRestart_Click);
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.ForeColor = System.Drawing.Color.DarkBlue;
			this.label2.Name = "label2";
			this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
			// 
			// dataGridProject
			// 
			resources.ApplyResources(this.dataGridProject, "dataGridProject");
			this.dataGridProject.AutoGenerateColumns = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridProject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.LastWriteTime,
            this.lastAccessTimeDataGridViewTextBoxColumn});
			this.dataGridProject.DataSource = this.fileInfoBindingSource;
			this.dataGridProject.Name = "dataGridProject";
			this.dataGridProject.RowHeadersVisible = false;
			this.dataGridProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.toolTip1.SetToolTip(this.dataGridProject, resources.GetString("dataGridProject.ToolTip"));
			this.dataGridProject.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridProject_ColumnHeaderMouseClick);
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
			resources.ApplyResources(this.nameDataGridViewTextBoxColumn, "nameDataGridViewTextBoxColumn");
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			this.nameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// lengthDataGridViewTextBoxColumn
			// 
			this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lengthDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
			resources.ApplyResources(this.lengthDataGridViewTextBoxColumn, "lengthDataGridViewTextBoxColumn");
			this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
			this.lengthDataGridViewTextBoxColumn.ReadOnly = true;
			this.lengthDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// LastWriteTime
			// 
			this.LastWriteTime.DataPropertyName = "LastWriteTime";
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LastWriteTime.DefaultCellStyle = dataGridViewCellStyle4;
			resources.ApplyResources(this.LastWriteTime, "LastWriteTime");
			this.LastWriteTime.Name = "LastWriteTime";
			// 
			// lastAccessTimeDataGridViewTextBoxColumn
			// 
			this.lastAccessTimeDataGridViewTextBoxColumn.DataPropertyName = "LastAccessTime";
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lastAccessTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
			resources.ApplyResources(this.lastAccessTimeDataGridViewTextBoxColumn, "lastAccessTimeDataGridViewTextBoxColumn");
			this.lastAccessTimeDataGridViewTextBoxColumn.Name = "lastAccessTimeDataGridViewTextBoxColumn";
			this.lastAccessTimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// fileInfoBindingSource
			// 
			this.fileInfoBindingSource.DataSource = typeof(System.IO.FileInfo);
			// 
			// dataGridEsp
			// 
			resources.ApplyResources(this.dataGridEsp, "dataGridEsp");
			this.dataGridEsp.AutoGenerateColumns = false;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridEsp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridEsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridEsp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.sizeDataGridViewTextBoxColumn});
			this.dataGridEsp.DataSource = this.espFileBindingSource;
			this.dataGridEsp.Name = "dataGridEsp";
			this.dataGridEsp.RowHeadersVisible = false;
			this.dataGridEsp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.toolTip1.SetToolTip(this.dataGridEsp, resources.GetString("dataGridEsp.ToolTip"));
			this.dataGridEsp.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridEsp_ColumnHeaderMouseClick);
			// 
			// nameDataGridViewTextBoxColumn1
			// 
			this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nameDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle7;
			resources.ApplyResources(this.nameDataGridViewTextBoxColumn1, "nameDataGridViewTextBoxColumn1");
			this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
			// 
			// sizeDataGridViewTextBoxColumn
			// 
			this.sizeDataGridViewTextBoxColumn.DataPropertyName = "size";
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.sizeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
			resources.ApplyResources(this.sizeDataGridViewTextBoxColumn, "sizeDataGridViewTextBoxColumn");
			this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
			// 
			// espFileBindingSource
			// 
			this.espFileBindingSource.DataSource = typeof(FileManager.EspFile);
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.ForeColor = System.Drawing.Color.DarkBlue;
			this.label1.Name = "label1";
			this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
			// 
			// MainForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "MainForm";
			this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridProject)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fileInfoBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridEsp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.espFileBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsBtnSettings;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ToolStripButton tsBtnLog;
		private System.Windows.Forms.ToolStripButton tsBtnAbout;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.DataGridView dataGridProject;
		private System.Windows.Forms.DataGridView dataGridEsp;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource fileInfoBindingSource;
		private System.Windows.Forms.BindingSource espFileBindingSource;
		private System.Windows.Forms.ToolStripButton tsBtnRefresh;
		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripButton tsBtnEspDelete;
		private System.Windows.Forms.ToolStripButton tsBtnCopy;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastWriteTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastAccessTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
		private System.Windows.Forms.ToolStripButton tsBtnRead;
		private System.Windows.Forms.ToolStripButton tsBtnRun;
		private System.Windows.Forms.ToolStripButton tsBtnCompile;
		private System.Windows.Forms.ToolStripButton tsBtnRestart;
	}
}


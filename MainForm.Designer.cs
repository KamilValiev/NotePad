
namespace Блокнот
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.mEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditcancel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditDel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mEditGiveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditTime = new System.Windows.Forms.ToolStripMenuItem();
            this.mFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mFilePageParam = new System.Windows.Forms.ToolStripMenuItem();
            this.mFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatFont = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelpAboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.notebox = new System.Windows.Forms.TextBox();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.FontDialog = new System.Windows.Forms.FontDialog();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEdit,
            this.mFile,
            this.mFormat,
            this.mHelp});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(905, 28);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // mEdit
            // 
            this.mEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEditcancel,
            this.toolStripSeparator3,
            this.mEditCut,
            this.mEditCopy,
            this.mEditPaste,
            this.mEditDel,
            this.toolStripSeparator4,
            this.mEditGiveAll,
            this.mEditTime});
            this.mEdit.Name = "mEdit";
            this.mEdit.Size = new System.Drawing.Size(74, 24);
            this.mEdit.Text = "Правка";
            // 
            // mEditcancel
            // 
            this.mEditcancel.Name = "mEditcancel";
            this.mEditcancel.ShortcutKeyDisplayString = "Ctrl+Z";
            this.mEditcancel.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mEditcancel.Size = new System.Drawing.Size(238, 26);
            this.mEditcancel.Text = "Отменить";
            this.mEditcancel.Click += new System.EventHandler(this.mEditcancel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(235, 6);
            // 
            // mEditCut
            // 
            this.mEditCut.Name = "mEditCut";
            this.mEditCut.ShortcutKeyDisplayString = "Ctrl+X";
            this.mEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mEditCut.Size = new System.Drawing.Size(238, 26);
            this.mEditCut.Text = "Вырезать";
            this.mEditCut.Click += new System.EventHandler(this.mEditCut_Click);
            // 
            // mEditCopy
            // 
            this.mEditCopy.Name = "mEditCopy";
            this.mEditCopy.ShortcutKeyDisplayString = "Ctrl+C";
            this.mEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mEditCopy.Size = new System.Drawing.Size(238, 26);
            this.mEditCopy.Text = "Копировать";
            this.mEditCopy.Click += new System.EventHandler(this.mEditCopy_Click);
            // 
            // mEditPaste
            // 
            this.mEditPaste.Name = "mEditPaste";
            this.mEditPaste.ShortcutKeyDisplayString = "Ctrl+V";
            this.mEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mEditPaste.Size = new System.Drawing.Size(238, 26);
            this.mEditPaste.Text = "Вставить";
            this.mEditPaste.Click += new System.EventHandler(this.mEditPaste_Click);
            // 
            // mEditDel
            // 
            this.mEditDel.Name = "mEditDel";
            this.mEditDel.ShortcutKeyDisplayString = "Del";
            this.mEditDel.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.mEditDel.Size = new System.Drawing.Size(238, 26);
            this.mEditDel.Text = "Удалить";
            this.mEditDel.Click += new System.EventHandler(this.mEditDel_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(235, 6);
            // 
            // mEditGiveAll
            // 
            this.mEditGiveAll.Name = "mEditGiveAll";
            this.mEditGiveAll.ShortcutKeyDisplayString = "Ctrl+A";
            this.mEditGiveAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mEditGiveAll.Size = new System.Drawing.Size(238, 26);
            this.mEditGiveAll.Text = "Выделить всё";
            this.mEditGiveAll.Click += new System.EventHandler(this.mEditGiveAll_Click);
            // 
            // mEditTime
            // 
            this.mEditTime.Name = "mEditTime";
            this.mEditTime.ShortcutKeyDisplayString = "F5";
            this.mEditTime.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mEditTime.Size = new System.Drawing.Size(238, 26);
            this.mEditTime.Text = "Время и дата";
            this.mEditTime.Click += new System.EventHandler(this.mEditTime_Click);
            // 
            // mFile
            // 
            this.mFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFileNew,
            this.mFileOpen,
            this.mFileSave,
            this.mFileSaveAs,
            this.toolStripSeparator1,
            this.mFilePageParam,
            this.mFilePrint,
            this.toolStripSeparator2,
            this.mFileExit});
            this.mFile.Name = "mFile";
            this.mFile.Size = new System.Drawing.Size(59, 24);
            this.mFile.Text = "Файл";
            // 
            // mFileNew
            // 
            this.mFileNew.Name = "mFileNew";
            this.mFileNew.ShortcutKeyDisplayString = "Ctrl+N";
            this.mFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mFileNew.Size = new System.Drawing.Size(280, 26);
            this.mFileNew.Text = "Создать";
            this.mFileNew.Click += new System.EventHandler(this.mFileNew_Click);
            // 
            // mFileOpen
            // 
            this.mFileOpen.Name = "mFileOpen";
            this.mFileOpen.ShortcutKeyDisplayString = "Ctrl+O";
            this.mFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mFileOpen.Size = new System.Drawing.Size(280, 26);
            this.mFileOpen.Text = "Открыть...";
            this.mFileOpen.Click += new System.EventHandler(this.mFileOpen_Click);
            // 
            // mFileSave
            // 
            this.mFileSave.Name = "mFileSave";
            this.mFileSave.ShortcutKeyDisplayString = "Ctrl+S";
            this.mFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mFileSave.Size = new System.Drawing.Size(280, 26);
            this.mFileSave.Text = "Сохранить";
            this.mFileSave.Click += new System.EventHandler(this.mFileSave_Click);
            // 
            // mFileSaveAs
            // 
            this.mFileSaveAs.Name = "mFileSaveAs";
            this.mFileSaveAs.ShortcutKeyDisplayString = "Ctrl+Alt+S";
            this.mFileSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.mFileSaveAs.Size = new System.Drawing.Size(280, 26);
            this.mFileSaveAs.Text = "Сохранить как...";
            this.mFileSaveAs.Click += new System.EventHandler(this.mFileSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(277, 6);
            // 
            // mFilePageParam
            // 
            this.mFilePageParam.Name = "mFilePageParam";
            this.mFilePageParam.Size = new System.Drawing.Size(280, 26);
            this.mFilePageParam.Text = "Параметры страницы";
            this.mFilePageParam.Click += new System.EventHandler(this.mFilePageParam_Click);
            // 
            // mFilePrint
            // 
            this.mFilePrint.Name = "mFilePrint";
            this.mFilePrint.ShortcutKeyDisplayString = "Ctrl+P";
            this.mFilePrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mFilePrint.Size = new System.Drawing.Size(280, 26);
            this.mFilePrint.Text = "Печать...";
            this.mFilePrint.Click += new System.EventHandler(this.mFilePrint_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(277, 6);
            // 
            // mFileExit
            // 
            this.mFileExit.Name = "mFileExit";
            this.mFileExit.ShortcutKeyDisplayString = "Alt+F4";
            this.mFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mFileExit.Size = new System.Drawing.Size(280, 26);
            this.mFileExit.Text = "Выход";
            this.mFileExit.Click += new System.EventHandler(this.mFileExit_Click);
            // 
            // mFormat
            // 
            this.mFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFormatTransfer,
            this.mFormatFont});
            this.mFormat.Name = "mFormat";
            this.mFormat.Size = new System.Drawing.Size(77, 24);
            this.mFormat.Text = "Формат";
            // 
            // mFormatTransfer
            // 
            this.mFormatTransfer.CheckOnClick = true;
            this.mFormatTransfer.Name = "mFormatTransfer";
            this.mFormatTransfer.Size = new System.Drawing.Size(230, 26);
            this.mFormatTransfer.Text = "Перенос по словам";
            this.mFormatTransfer.Click += new System.EventHandler(this.mFormatTransfer_Click);
            // 
            // mFormatFont
            // 
            this.mFormatFont.Name = "mFormatFont";
            this.mFormatFont.Size = new System.Drawing.Size(230, 26);
            this.mFormatFont.Text = "Шрифт";
            this.mFormatFont.Click += new System.EventHandler(this.mFormatFont_Click);
            // 
            // mHelp
            // 
            this.mHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mHelpAboutProgram});
            this.mHelp.Name = "mHelp";
            this.mHelp.Size = new System.Drawing.Size(81, 24);
            this.mHelp.Text = "Справка";
            // 
            // mHelpAboutProgram
            // 
            this.mHelpAboutProgram.Name = "mHelpAboutProgram";
            this.mHelpAboutProgram.Size = new System.Drawing.Size(224, 26);
            this.mHelpAboutProgram.Text = "О программе";
            this.mHelpAboutProgram.Click += new System.EventHandler(this.mHelpAboutProgram_Click);
            // 
            // notebox
            // 
            this.notebox.AcceptsTab = true;
            this.notebox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.notebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notebox.Location = new System.Drawing.Point(0, 28);
            this.notebox.Multiline = true;
            this.notebox.Name = "notebox";
            this.notebox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.notebox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.notebox.Size = new System.Drawing.Size(905, 500);
            this.notebox.TabIndex = 3;
            this.notebox.WordWrap = false;
            this.notebox.TextChanged += new System.EventHandler(this.notebox_TextChanged);
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // pageSetupDialog
            // 
            this.pageSetupDialog.Document = this.printDocument;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 528);
            this.Controls.Add(this.notebox);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.Text = "Блокнот";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Блокнот_FormClosing);
            this.Load += new System.EventHandler(this.Блокнот_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mFile;
        private System.Windows.Forms.ToolStripMenuItem mFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mFileSave;
        private System.Windows.Forms.ToolStripMenuItem mFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mFileExit;
        private System.Windows.Forms.ToolStripMenuItem mEdit;
        private System.Windows.Forms.ToolStripMenuItem mEditcancel;
        private System.Windows.Forms.ToolStripMenuItem mEditCut;
        private System.Windows.Forms.ToolStripMenuItem mEditCopy;
        private System.Windows.Forms.ToolStripMenuItem mEditPaste;
        private System.Windows.Forms.ToolStripMenuItem mEditDel;
        private System.Windows.Forms.ToolStripMenuItem mEditGiveAll;
        private System.Windows.Forms.ToolStripMenuItem mEditTime;
        private System.Windows.Forms.ToolStripMenuItem mFormat;
        private System.Windows.Forms.ToolStripMenuItem mFormatTransfer;
        private System.Windows.Forms.ToolStripMenuItem mFormatFont;
        private System.Windows.Forms.ToolStripMenuItem mFileNew;
        private System.Windows.Forms.ToolStripMenuItem mHelp;
        private System.Windows.Forms.ToolStripMenuItem mFilePrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mFilePageParam;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mHelpAboutProgram;
        public System.Windows.Forms.TextBox notebox;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.FontDialog FontDialog;
    }
}


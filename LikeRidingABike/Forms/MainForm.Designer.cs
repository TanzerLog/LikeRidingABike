namespace LikeRidingABike
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            fileMenuItem = new ToolStripMenuItem();
            exitMenuItem = new ToolStripMenuItem();
            helpToolItem = new ToolStripMenuItem();
            aboutMenuItem = new ToolStripMenuItem();
            addItemButton = new Button();
            itemListView = new ListView();
            taskColumnHeader = new ColumnHeader();
            dueDateColumnHeader = new ColumnHeader();
            statusColumnHeader = new ColumnHeader();
            removeItemButton = new Button();
            markCompleteButton = new Button();
            editItemButton = new Button();
            headerLabel = new Label();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = SystemColors.ActiveCaption;
            menuStrip.Items.AddRange(new ToolStripItem[] { fileMenuItem, helpToolItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(4, 2, 0, 2);
            menuStrip.Size = new Size(659, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "Menu Strip";
            // 
            // fileMenuItem
            // 
            fileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitMenuItem });
            fileMenuItem.Name = "fileMenuItem";
            fileMenuItem.Size = new Size(37, 20);
            fileMenuItem.Text = "&File";
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new Size(93, 22);
            exitMenuItem.Text = "E&xit";
            // 
            // helpToolItem
            // 
            helpToolItem.DropDownItems.AddRange(new ToolStripItem[] { aboutMenuItem });
            helpToolItem.Name = "helpToolItem";
            helpToolItem.Size = new Size(44, 20);
            helpToolItem.Text = "&Help";
            // 
            // aboutMenuItem
            // 
            aboutMenuItem.Name = "aboutMenuItem";
            aboutMenuItem.Size = new Size(107, 22);
            aboutMenuItem.Text = "&About";
            // 
            // addItemButton
            // 
            addItemButton.Location = new Point(555, 246);
            addItemButton.Margin = new Padding(2);
            addItemButton.Name = "addItemButton";
            addItemButton.Size = new Size(93, 54);
            addItemButton.TabIndex = 2;
            addItemButton.Text = "Add Item";
            addItemButton.UseVisualStyleBackColor = true;
            // 
            // itemListView
            // 
            itemListView.BackColor = SystemColors.Menu;
            itemListView.Columns.AddRange(new ColumnHeader[] { taskColumnHeader, dueDateColumnHeader, statusColumnHeader });
            itemListView.Location = new Point(26, 72);
            itemListView.Name = "itemListView";
            itemListView.Size = new Size(524, 338);
            itemListView.TabIndex = 3;
            itemListView.UseCompatibleStateImageBehavior = false;
            // 
            // taskColumnHeader
            // 
            taskColumnHeader.Text = "Task";
            // 
            // dueDateColumnHeader
            // 
            dueDateColumnHeader.Text = "Due Date";
            // 
            // statusColumnHeader
            // 
            statusColumnHeader.Text = "Status";
            // 
            // removeItemButton
            // 
            removeItemButton.Location = new Point(555, 188);
            removeItemButton.Margin = new Padding(2);
            removeItemButton.Name = "removeItemButton";
            removeItemButton.Size = new Size(93, 54);
            removeItemButton.TabIndex = 4;
            removeItemButton.Text = "Remove Item";
            removeItemButton.UseVisualStyleBackColor = true;
            // 
            // markCompleteButton
            // 
            markCompleteButton.Location = new Point(555, 72);
            markCompleteButton.Margin = new Padding(2);
            markCompleteButton.Name = "markCompleteButton";
            markCompleteButton.Size = new Size(93, 54);
            markCompleteButton.TabIndex = 5;
            markCompleteButton.Text = "Mark Complete";
            markCompleteButton.UseVisualStyleBackColor = true;
            // 
            // editItemButton
            // 
            editItemButton.Location = new Point(555, 130);
            editItemButton.Margin = new Padding(2);
            editItemButton.Name = "editItemButton";
            editItemButton.Size = new Size(93, 54);
            editItemButton.TabIndex = 6;
            editItemButton.Text = "Edit Item";
            editItemButton.UseVisualStyleBackColor = true;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            headerLabel.Location = new Point(26, 24);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(181, 30);
            headerLabel.TabIndex = 7;
            headerLabel.Text = "Get It Done Tom!";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(659, 437);
            Controls.Add(headerLabel);
            Controls.Add(editItemButton);
            Controls.Add(markCompleteButton);
            Controls.Add(removeItemButton);
            Controls.Add(itemListView);
            Controls.Add(addItemButton);
            Controls.Add(menuStrip);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip;
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "To-Do";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileMenuItem;
        private ToolStripMenuItem exitMenuItem;
        private ToolStripMenuItem helpToolItem;
        private ToolStripMenuItem aboutMenuItem;
        private Button addItemButton;
        private ListView itemListView;
        private Button removeItemButton;
        private Button markCompleteButton;
        private Button editItemButton;
        private ColumnHeader taskColumnHeader;
        private ColumnHeader dueDateColumnHeader;
        private ColumnHeader statusColumnHeader;
        private Label headerLabel;
    }
}
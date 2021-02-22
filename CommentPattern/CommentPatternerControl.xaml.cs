using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Windows;
using System.Windows.Controls;


namespace CommentPattern
{
    /// <summary>
    /// Interaction logic for CommentPatternerControl.
    /// </summary>
    public partial class CommentPatternerControl : UserControl
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CommentPatternerControl"/> class.
        /// </summary>
        public CommentPatternerControl()
        {
            this.InitializeComponent();
            textBoxModification.KeyDown += new System.Windows.Input.KeyEventHandler(this.textBoxModification_KeyDown);

        }
        public void textBoxModification_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                Include();
            }
        }
        /// <summary>
        /// Handles click on the button by displaying a message box.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event args.</param>
        [SuppressMessage("Microsoft.Globalization", "CA1300:SpecifyMessageBoxOptions", Justification = "Sample code")]
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:ElementMustBeginWithUpperCaseLetter", Justification = "Default event handler naming pattern")]
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            GeneratePatternedComment();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //todo: add na lista 

            Include();

        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {

            if (listView.Items.Count > 0 && listView.SelectedItems.Count > 0) listView.Items.Remove(listView.SelectedItem.ToString());


        }

        #region Methods
        public void GeneratePatternedComment()
        {

            StringBuilder modif = new StringBuilder();
            var modifx = listView.Items;
            foreach (var item in modifx)
            {
                modif.Append(item);
            }
            Clipboard.SetText(string.Format(System.Globalization.CultureInfo.CurrentUICulture, "US {0} [{1}] - {2}", textBoxUS.Text, textBoxCampaign.Text.ToUpper(), modif));
            MessageBox.Show(
                string.Format(System.Globalization.CultureInfo.CurrentUICulture, "US {0} [{1}] - {2}", textBoxUS.Text, textBoxCampaign.Text.ToUpper(), modif),
                "CommentPatterner");
            textBoxModification.Text = "";
            textBoxUS.Text = "";
            textBoxCampaign.Text = "";
            modifx.Clear();
        }
        public void Include()
        {
            if (textBoxModification.Text.Length > 0) listView.Items.Add(string.Format("\u23f5 {0}   ", textBoxModification.Text.ToUpper()).ToUpper());
            textBoxModification.Text = "";
            textBoxModification.Focus();
        }
        #endregion
    }
}
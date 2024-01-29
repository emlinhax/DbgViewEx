using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DbgViewEx
{
    public class ComboBoxItem
    {
        public string Text;
        public object Tag;

        public ComboBoxItem(string text, object tag)
        {
            Text = text;
            Tag = tag;
        }


        public override string ToString()
        {
            return Text;
        }
    }

    public partial class FilterForm : Form
    {
        public FilterForm()
        {
            InitializeComponent();
        }

       

        private void FilterForm_Load(object sender, EventArgs e)
        {
            FILTER_Subject.Items.Add(new ComboBoxItem("Event Name", EFilterSubject.EVENT_NAME));
            FILTER_Subject.Items.Add(new ComboBoxItem("Process ID",EFilterSubject.PROCESS_ID ));
            FILTER_Subject.Items.Add(new ComboBoxItem("Summary", EFilterSubject.SUMMARY));

            FILTER_Condition.Items.Add(new ComboBoxItem("equals",EFilterCondition.EQUALS));
            FILTER_Condition.Items.Add(new ComboBoxItem("contains", EFilterCondition.CONTAINS ));

            FILTER_Action.Items.Add(new ComboBoxItem("include", EFilterAction.INCLUDE));
            FILTER_Action.Items.Add(new ComboBoxItem("exclude", EFilterAction.EXCLUDE));
        }

        private void FILTER_Savebutton_Click(object sender, EventArgs e)
        {
            Settings.filter.Subject = (EFilterSubject)((ComboBoxItem)FILTER_Subject.SelectedItem).Tag;
            Settings.filter.Condition = (EFilterCondition)((ComboBoxItem)FILTER_Condition.SelectedItem).Tag;
            Settings.filter.Value = FILTER_Value.Text;
            Settings.filter.Action = (EFilterAction)((ComboBoxItem)FILTER_Action.SelectedItem).Tag;
            MessageBox.Show("Filter has been saved!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}

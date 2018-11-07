using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Ketoan.Controls.DanhMuc
{
    public partial class AddEditFrame : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        protected GridView Gridview;
        protected bool isAdd;
        protected EWONErrorProvider ewErrorProvider1 = new EWONErrorProvider();
        public AddEditFrame()
        {
            InitializeComponent();

            //Bind acceptButton's property to ewErrorProvider1's HasErrors
            Binding buttonToErrorProvider = new Binding("Enabled", ewErrorProvider1, "HasErrors");
            buttonToErrorProvider.Format += SwitchBool;
            buttonToErrorProvider.Parse += SwitchBool;
            acceptBtn.DataBindings.Add(buttonToErrorProvider);
        }

        //Class and method for binding Button's Enabled property to ewErrorProvider'HasError property
        protected void SwitchBool(object sender, ConvertEventArgs e)
        {
            e.Value = !((bool)e.Value);
        }
        public class EWONErrorProvider : DXErrorProvider, INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;

            protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
            {
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null)
                {
                    handler(this, e);
                }
            }

            protected void OnPropertyChanged(string propertyName)
            {
                OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
            }

            //New SetError method with updating HasErrors property
            public new void SetError(Control control, string errorText, ErrorType errorType)
            {
                base.SetError(control, errorText, errorType);
                if (HasErrors)
                {
                    MessageBox.Show(errorText);
                }
            }

            //New HasErrors property with OnPropertyChanged notification
            private bool NewHasErrors;
            public new bool HasErrors
            {
                get
                {
                    if (NewHasErrors != base.HasErrors)
                    {
                        NewHasErrors = base.HasErrors;
                        OnPropertyChanged("HasErrors");
                    }

                    return NewHasErrors;
                }
            }

        }

        //Lose focus when click on panel
        private void LoseFocusClick(object sender, EventArgs e)
        {
            invisibleLB.Focus();
        }


    }
}

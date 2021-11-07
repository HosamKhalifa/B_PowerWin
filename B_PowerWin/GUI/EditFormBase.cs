using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using B_PowerWin.SharedExt;
using System.Data.Entity.Validation;
using System.Reflection;
using System.Linq;

namespace B_PowerWin.GUI
{
    public partial class EditFormBase : B_PowerWin.GUI.FormBase
    {
        public AppDbContext dbContext { get; set; }
        

        public EditFormBase()
        {
            InitializeComponent();
          
        }
             
       
        public EditFormBase(FormArgs _callerArgs):base(_callerArgs)
        {
            InitializeComponent();
        }
        public DialogResult SaveConfirmMsg()
        {
            var result = XtraMessageBox.Show("There are changes founded at this form Do you want to save changes?", "Closing form", MessageBoxButtons.YesNoCancel);
            return result;
        }
        public virtual void EditFormBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(dbContext != null)
            {
                dbContext.ChangeTracker.DetectChanges();
                if (dbContext.ChangeTracker.HasChanges())
                {
                    try
                    {
                        var result = SaveConfirmMsg();
                        switch (result)
                        {

                            case DialogResult.Cancel:
                                e.Cancel = true;
                                break;

                            case DialogResult.Yes:
                                try
                                {
                                    dbContext.SaveChanges();
                                    e.Cancel = false;
                                }
                                catch (DbEntityValidationException ex)
                                {
                                    foreach (var eve in ex.EntityValidationErrors)
                                    {
                                        string ls_EntityErrMsg = $"Entity of type \"{eve.Entry.Entity.GetType().Name}\" in state \"{eve.Entry.State}\" has the following validation errors:";
                                        string ls_ErrMsg = "";
                                        Console.WriteLine(ls_EntityErrMsg);
                                        foreach (var ve in eve.ValidationErrors)
                                        {
                                            ls_ErrMsg = $"- Property:{ve.PropertyName}, Error: \"{ve.ErrorMessage}\"";
                                            ls_EntityErrMsg += (Environment.NewLine + ls_ErrMsg);
                                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"", ve.PropertyName, ve.ErrorMessage);
                                        }
                                        XtraMessageBox.Show(ls_EntityErrMsg, "EF Errors", MessageBoxButtons.OK);
                                        e.Cancel = true;
                                    }

                                }

                                break;
                            case DialogResult.No:
                                dbContext.CancelChanges();
                                e.Cancel = false;
                                break;
                            default:
                                break;
                        }
                    }
                    catch (Exception ex)
                    {

                        XtraMessageBox.Show(ex.GetFullExceptionErrMessage());
                    }
                }
            }

        }

        public virtual void saveBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                dbContext.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    string ls_EntityErrMsg = $"Entity of type \"{eve.Entry.Entity.GetType().Name}\" in state \"{eve.Entry.State}\" has the following validation errors:";
                    string ls_ErrMsg = "";
                    Console.WriteLine(ls_EntityErrMsg);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        ls_ErrMsg=$"- Property:{ve.PropertyName}, Error: \"{ve.ErrorMessage}\"";
                        ls_EntityErrMsg += (Environment.NewLine + ls_ErrMsg);
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"", ve.PropertyName, ve.ErrorMessage);
                    }
                    XtraMessageBox.Show(ls_EntityErrMsg, "EF Errors", MessageBoxButtons.OK);
                }
                
            }
           
        }
        public virtual void RefreshData()
        {
            //Override on childs
        }
        private  void refreshBI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (dbContext.ChangeTracker.HasChanges())
                {
                    var result = SaveConfirmMsg();
                    switch (result)
                    {

                        case DialogResult.Yes:
                            dbContext.SaveChanges();
                            RefreshData();
                            break;
                        case DialogResult.No:
                            RefreshData();
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.GetFullExceptionErrMessage());
            }
        }
    }
}

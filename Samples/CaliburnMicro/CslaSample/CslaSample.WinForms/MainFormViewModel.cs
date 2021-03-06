﻿using System.Collections.Generic;
using CslaSample.Documents;
using CslaSample.FolderEdit;
using MvvmFx.CaliburnMicro;
#if WEBGUI
using Gizmox.WebGUI.Forms;
#else
using System.Windows.Forms;
#endif
using Screen = MvvmFx.CaliburnMicro.Screen;

namespace CslaSample
{
    public interface IMainFormViewModel : IScreen, IHaveViewNamedElements
    {
    }

    public class MainFormViewModel : Conductor<Screen>, IMainFormViewModel
    {
        //todo: bind menu items directly to DocumentEditViewModel

        #region Fields and properties

        public List<Control> ViewNamedElements { get; set; }

        #endregion

        #region Initializers

        protected override void OnInitialize()
        {
            DisplayName = "CSLA .NET sample";
            BindMenuItems();
        }

        private void BindMenuItems()
        {
            var mainForm = GetView() as MainForm;
            if (mainForm != null)
                mainForm.BindMenuItems(ViewNamedElements);
        }

        protected override void OnActivate()
        {
            EditDocuments();
        }

        #endregion

        #region Folder menu action methods and CAN guard properties

        public void EditFoldersModal()
        {
            if (_canEditFoldersModal)
            {
                new WindowManager().ShowDialog(FolderListEditViewModel.Instance());
                foreach (var child in GetChildren())
                {
                    child.Refresh();
                }
            }
        }

        private bool _canEditFoldersModal = true;

        public bool CanEditFoldersModal
        {
            get { return _canEditFoldersModal; }
            set
            {
                if (_canEditFoldersModal != value)
                {
                    _canEditFoldersModal = value;
                    NotifyOfPropertyChange("CanEditFoldersModal");
                }
            }
        }

        public void EditFoldersModeless()
        {
            if (_canEditFoldersModeless)
            {
                ViewLocator.ContextSeparator = "";
                new WindowManager().ShowWindow(FolderListEditViewModel.Instance(), "ViewModel");
                //new WindowManager().ShowWindow(FolderListEditViewModel.Instance());
            }
        }

        private bool _canEditFoldersModeless = true;

        public bool CanEditFoldersModeless
        {
            get { return _canEditFoldersModeless; }
            set
            {
                if (_canEditFoldersModeless != value)
                {
                    _canEditFoldersModeless = value;
                    NotifyOfPropertyChange("CanEditFoldersModeless");
                }
            }
        }

        #endregion

        #region Document menu guard visibility properties

        private bool _documentMenuVisible = true;

        public bool DocumentMenuVisible
        {
            get { return _documentMenuVisible; }
            set
            {
                if (_documentMenuVisible != value)
                {
                    _documentMenuVisible = value;
                    NotifyOfPropertyChange("DocumentMenuVisible");
                }
            }
        }

        #endregion

        #region Document menu action methods and CAN guard properties

        public void EditDocuments()
        {
            if (ActiveItem != null)
            {
                if (ActiveItem.GetType() != typeof (FolderListViewModel))
                    ActiveItem.TryClose();
            }
            ActivateItem(new FolderListViewModel());
        }

        public void CreateNewDocument()
        {
            if (_canCreateNewDocument)
            {
                GetDocumentList().CreateNew();
            }
        }

        private bool _canCreateNewDocument;

        public bool CanCreateNewDocument
        {
            get { return _canCreateNewDocument; }
            set
            {
                if (_canCreateNewDocument != value)
                {
                    _canCreateNewDocument = value;
                    NotifyOfPropertyChange("CanCreateNewDocument");
                }
            }
        }

        public void SaveDocument()
        {
            GetDocumentEdit().Save();
        }

        private bool _canSaveDocument;

        public bool CanSaveDocument
        {
            get { return _canSaveDocument; }
            set
            {
                if (_canSaveDocument != value)
                {
                    _canSaveDocument = value;
                    NotifyOfPropertyChange("CanSaveDocument");
                }
            }
        }

        public void DeleteDocument()
        {
            GetDocumentEdit().Delete();
        }

        private bool _canDeleteDocument;

        public bool CanDeleteDocument
        {
            get { return _canDeleteDocument; }
            set
            {
                if (_canDeleteDocument != value)
                {
                    _canDeleteDocument = value;
                    NotifyOfPropertyChange("CanDeleteDocument");
                }
            }
        }

        public void CloseDocument()
        {
            GetDocumentEdit().Close();
        }

        private bool _canCloseDocument;

        public bool CanCloseDocument
        {
            get { return _canCloseDocument; }
            set
            {
                if (_canCloseDocument != value)
                {
                    _canCloseDocument = value;
                    NotifyOfPropertyChange("CanCloseDocument");
                }
            }
        }

        private DocumentListViewModel GetDocumentList()
        {
            foreach (var child in GetChildren())
            {
                if (child is IParent)
                {
                    var parent = child as IParent;
                    foreach (var grandChild in parent.GetChildren())
                    {
                        if (grandChild is DocumentListViewModel)
                        {
                            return grandChild as DocumentListViewModel;
                        }
                    }
                }
            }

            return null;
        }

        private DocumentEditViewModel GetDocumentEdit()
        {
            foreach (var child in GetChildren())
            {
                if (child is IParent)
                {
                    var parent = child as IParent;
                    foreach (var grandChild in parent.GetChildren())
                    {
                        if (grandChild is IParent)
                        {
                            var grandParent = grandChild as IParent;
                            foreach (var grandGrandChild in grandParent.GetChildren())
                            {
                                if (grandGrandChild is DocumentEditViewModel)
                                {
                                    return grandGrandChild as DocumentEditViewModel;
                                }
                            }
                        }
                    }
                }
            }

            return null;
        }

        #endregion

        #region Exit

        public void Exit()
        {
            TryClose();
        }

        #endregion
    }
}
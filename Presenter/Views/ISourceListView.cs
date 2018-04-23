﻿using System;
using Presenter.Common;

namespace Presenter.Views
{
    public interface ISourceListView : IViewControl
    {
        void Clear();
        void AddItem(object obj, string name, int icoNr);
        object SelectedObject { get; set; }
        int ListSort { get; set; }
        event Action SortChanged;
        int ListView { get; set; }
        event Action ViewChanged;
        event Action EditClick;
        event Action NewClick;
        void SetModifySourceControl(IViewControl control);
        object GetImageList();

        void SelectObject(object obj);
        void UpdateSelected(string name, int icoNr);
        void RemoveSelected();

        event Action NameChanged;
        string SelectedName { get; set; }

        event Action DoDragDropping;
        event Action DoneDragDropping;
        object DragObject { get; }
    }
}
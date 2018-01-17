﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using Naver.Compass.InfoStructure;

namespace MainToolBar.ViewModel
{
    public class TabData : ViewModelBase
    {
        public TabData()
            : this(null)
        {
        }

        public TabData(string header)
        {
            Header = header;
        }

        public string Header
        {
            get
            {
                return _header;
            }

            set
            {
                if (_header != value)
                {
                    _header = value;
                    FirePropertyChanged("Header");
                }
            }
        }
        private string _header;

        public string ContextualTabGroupHeader
        {
            get
            {
                return _contextualTabGroupHeader;
            }

            set
            {
                if (_contextualTabGroupHeader != value)
                {
                    _contextualTabGroupHeader = value;
                    FirePropertyChanged("ContextualTabGroupHeader");
                }
            }
        }
        private string _contextualTabGroupHeader;

        public bool IsSelected
        {
            get
            {
                return _isSelected;
            }

            set
            {
                if (_isSelected != value)
                {
                    _isSelected = value;
                    FirePropertyChanged("IsSelected");
                }
            }
        }
        private bool _isSelected;

        public ObservableCollection<GroupData> GroupDataCollection
        {
            get
            {
                if (_groupDataCollection == null)
                {
                    Uri smallImage = new Uri("Images/Paste_16x16.png", UriKind.Relative);
                    Uri largeImage = new Uri("Images/Paste_32x32.png", UriKind.Relative);

                    _groupDataCollection = new ObservableCollection<GroupData>();
                    for (int i = 0; i < ViewModelData.GroupCount; i++)
                    {
                        _groupDataCollection.Add(new GroupData("Group " + i)
                        {
                            LargeImage = largeImage,
                            SmallImage = smallImage
                        });
                    }
                }
                return _groupDataCollection;
            }
        }
        private ObservableCollection<GroupData> _groupDataCollection;
    }
}

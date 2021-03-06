﻿using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using snapper.Annotations;

//
namespace snapper {
    class SnapViewModel : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        private Snap snap;

        public SnapViewModel(Snap snap) {
            this.snap = snap;
        }

        public Int32 Id => snap.Id;

        public string Title {
            get => snap.Title;
            set {
                snap.Title = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Title"));
            }
        }

        public string Content {
            get => snap.Content;
            set {
                snap.Content = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Content"));
            }
        }

        private void OnPropertyChanged(PropertyChangedEventArgs e) {
            PropertyChanged?.Invoke(this, e);
        }

    }
}

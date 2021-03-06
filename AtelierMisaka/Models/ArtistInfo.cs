﻿using AtelierMisaka.ViewModels;

namespace AtelierMisaka.Models
{
    public class ArtistInfo : NotifyModel
    {
        private string _id = string.Empty;
        private string _cid = string.Empty;
        private string _aName = string.Empty;
        private string _postUrl = string.Empty;
        private string _payLow = string.Empty;
        private string _payHigh = string.Empty;
        private string _twitter = string.Empty;

        public string Cid
        {
            get => _cid;
            set
            {
                if (_cid != value)
                {
                    _cid = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string Id
        {
            get => _id;
            set
            {
                if (_id != value)
                {
                    _id = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string AName
        {
            get => string.IsNullOrEmpty(_aName) ? GlobalLanguage.Text_DefaultAName : _aName;
            set
            {
                if (_aName != value)
                {
                    _aName = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string PostUrl
        {
            get => _postUrl;
            set
            {
                if (_postUrl != value)
                {
                    _postUrl = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string Twitter
        {
            get => _twitter;
            set
            {
                if (_twitter != value)
                {
                    _twitter = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string PayLow
        {
            get => _payLow;
            set
            {
                if (_payLow != value)
                {
                    _payLow = value;
                    RaisePropertyChanged();
                }
            }
        }

        public int PayLowInt
        {
            get
            {
                if (string.IsNullOrEmpty(_payLow))
                {
                    return 0;
                }
                else
                {
                    return int.Parse(_payLow);
                }
            }
        }

        public string PayHigh
        {
            get => _payHigh;
            set
            {
                if (_payHigh != value)
                {
                    _payHigh = value;
                    RaisePropertyChanged();
                }
            }
        }

        public int PayHighInt
        {
            get
            {
                if (string.IsNullOrEmpty(_payHigh))
                {
                    return -1;
                }
                else
                {
                    return int.Parse(_payHigh);
                }
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            else if (obj is ArtistInfo ai)
            {
                return ai.Id == _id;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

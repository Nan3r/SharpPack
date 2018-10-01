﻿using SharpView.Enums;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SharpView.Arguments
{
    public class Args_Find_DomainLocalGroupMember
    {
        public string[] ComputerName { get; set; }
        public string[] DNSHostName { get { return ComputerName; } set { ComputerName = value; } }

        public string ComputerDomain { get; set; }

        public string ComputerLDAPFilter { get; set; }
        
        public string ComputerSearchBase { get; set; }

        public string ComputerOperatingSystem { get; set; }
        public string OperatingSystem { get { return ComputerOperatingSystem; } set { ComputerOperatingSystem = value; } }

        public string ComputerServicePack { get; set; }
        public string ServicePack { get { return ComputerServicePack; } set { ComputerServicePack = value; } }

        public string ComputerSiteName { get; set; }
        public string SiteName { get { return ComputerSiteName; } set { ComputerSiteName = value; } }

        public string GroupName { get; set; } = "Administrators";

        public MethodType Method { get; set; } = MethodType.API;

        public string Server { get; set; }
        public string DomainController { get { return Server; } set { Server = value; } }

        public SearchScope SearchScope { get; set; } = SearchScope.Subtree;

        private int _ResultPageSize = 200;
        public int ResultPageSize
        {
            get { return _ResultPageSize; }
            set
            {
                if (value < 1 || value > 10000) throw new ArgumentOutOfRangeException("ResultPageSize");
                _ResultPageSize = value;
            }
        }

        private int? _ServerTimeLimit;
        public int? ServerTimeLimit
        {
            get { return _ServerTimeLimit; }
            set
            {
                if (value < 1 || value > 10000) throw new ArgumentOutOfRangeException("ServerTimeLimit");
                _ServerTimeLimit = value;
            }
        }

        public bool Tombstone { get; set; }

        public NetworkCredential Credential { get; set; }

        private int _Delay = 0;
        public int Delay
        {
            get { return _Delay; }
            set
            {
                if (value < 1 || value > 10000) throw new ArgumentOutOfRangeException("Delay");
                _Delay = value;
            }
        }

        private double _Jitter = 0.3;
        public double Jitter
        {
            get { return _Jitter; }
            set
            {
                if (value < 0.0 || value > 1.0) throw new ArgumentOutOfRangeException("Jitter");
                _Jitter = value;
            }
        }

        private int _Threads = 20;
        public int Threads
        {
            get { return _Threads; }
            set
            {
                if (value < 1 || value > 100) throw new ArgumentOutOfRangeException("Threads");
                _Threads = value;
            }
        }
    }
}

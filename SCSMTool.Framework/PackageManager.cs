using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EnterpriseManagement;
using Microsoft.EnterpriseManagement.Common;
using Microsoft.EnterpriseManagement.Configuration;
using Microsoft.EnterpriseManagement.ConnectorFramework;

namespace SCSMTool.Framework
{
    public class PackageManager
    {

        private readonly String _scsmServer;

        private readonly EnterpriseManagementGroup _managementGroup;

        private ManagementPack _managementPack;

        public PackageManager(String server)
        {
            _scsmServer = server;
            try
            {
                _managementGroup = new EnterpriseManagementGroup(_scsmServer);
            }
            catch
            {
                throw;
            }
        }

        public void Add(ManagementPackEnumeration parent, string value, string description)
        {
            if (_managementPack == null) return;

            var parentEnum = _managementGroup.EntityTypes.GetEnumerations()
                                             .FirstOrDefault(i => i.Equals(parent));
            if (parentEnum == null) return;
            //Exists?
            if (_managementPack.GetEnumerations().Any(i => i.DisplayName.Equals(value)))
                return;
            //Creation
            var newEnum = new ManagementPackEnumeration(_managementPack, "Enum." + StringUtil.NewID(), ManagementPackAccessibility.Public)
            {
                Parent = parentEnum,
                DisplayName = value,
                Description = description
            };
            _managementPack.AcceptChanges();
        }

        //??
        public void Delete(EnterpriseManagementObject emoWorkItem)
        {
            IncrementalDiscoveryData idd = new IncrementalDiscoveryData();
            idd.Remove(emoWorkItem);
            idd.Commit(_managementGroup);
        }

        public void LoadById(Guid packId)
        {
            try
            {
                _managementPack = _managementGroup.ManagementPacks.GetManagementPack(packId);
            }
            catch (ObjectNotFoundException) { }
            catch
            {
                throw;
            }
        }

        public void LoadByName(string packName, String version)
        {
            _managementPack = _managementGroup.ManagementPacks.GetManagementPack(packName, null, new Version(version));

            var items = _managementPack.GetEnumerations();
            var parents = GetParents();

            var childs = GetChilds();
        }

        public String GetPackageInfo()
        {
            var strBuilder = new StringBuilder();

            strBuilder.AppendLine(String.Format("Name: \t{0}", _managementGroup.Name));
            try
            {
                strBuilder.AppendLine(String.Format("UserName: \t{0}", _managementGroup.GetUserName()));
                strBuilder.AppendLine(String.Format("UserSID: \t{0}", _managementGroup.GetUserSid()));
            }
            catch
            {
                strBuilder.AppendLine(String.Format("UserName: \t{0}", "-no access-"));
                strBuilder.AppendLine(String.Format("UserSID: \t{0}", "-no access-"));
            }
            strBuilder.AppendLine(String.Format("ID: \t{0}", _managementGroup.Id));
            strBuilder.AppendLine(String.Format("Product ID: \t{0}", _managementGroup.ProductId));
            strBuilder.AppendLine(String.Format("Version: \t{0}", _managementGroup.Version));

            return strBuilder.ToString();
        }

        public IEnumerable<ManagementPackEnumeration> GetParents()
        {
            if (_managementPack == null) return null;
            var items = _managementPack.GetEnumerations();
            return items.Where(p => p.Parent == null);
        }

        /// <summary>
        /// Gets Childs by Parent
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ManagementPackEnumeration> GetChildsByParentId(Guid parentId)
        {
            var items = _managementPack.GetEnumerations().Where(p => p.Parent != null && p.Parent.Id.Equals(parentId));
            return items;
        }

        /// <summary>
        /// Gets Childs (without Parent)
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ManagementPackEnumeration> GetChilds()
        {
            if (_managementPack == null) return null;
            var items = _managementPack.GetEnumerations();
            return items.Where(p => p.Parent != null).OrderBy(i => i.Ordinal);
        }



        public IEnumerable<ManagementPack> GetAllManagementPacks()
        {
            return _managementGroup.ManagementPacks.GetManagementPacks();
        }

        #region Public Static functions

        public static bool TryConnection(String scsmServer)
        {
            try
            {
                using (var emg = new EnterpriseManagementGroup(scsmServer))
                {
                    return emg.IsConnected;
                }
            }
            catch //omits any error...
            {
                return false;
            }
        }

        #endregion


    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hierarchy_Client.SchickWeb {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://schickweb.schicknt.com/", ConfigurationName="SchickWeb.SensorDataAccessServiceWSSoap")]
    public interface SensorDataAccessServiceWSSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schickweb.schicknt.com/WhoIsThis", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string WhoIsThis();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schickweb.schicknt.com/WhoIsThis", ReplyAction="*")]
        System.Threading.Tasks.Task<string> WhoIsThisAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schickweb.schicknt.com/Login", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string Login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schickweb.schicknt.com/Login", ReplyAction="*")]
        System.Threading.Tasks.Task<string> LoginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schickweb.schicknt.com/getUserInfo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Hierarchy_Client.SchickWeb.SensorDataBaseAccess getUserInfo(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schickweb.schicknt.com/getUserInfo", ReplyAction="*")]
        System.Threading.Tasks.Task<Hierarchy_Client.SchickWeb.SensorDataBaseAccess> getUserInfoAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schickweb.schicknt.com/IsWaferExists", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int IsWaferExists(int uapid, string carrieridwafernumber, string RecipeStep);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schickweb.schicknt.com/IsWaferExists", ReplyAction="*")]
        System.Threading.Tasks.Task<int> IsWaferExistsAsync(int uapid, string carrieridwafernumber, string RecipeStep);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schickweb.schicknt.com/SaveLotFailedSensors", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int SaveLotFailedSensors(int uapid, string xml_lot_data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schickweb.schicknt.com/SaveLotFailedSensors", ReplyAction="*")]
        System.Threading.Tasks.Task<int> SaveLotFailedSensorsAsync(int uapid, string xml_lot_data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schickweb.schicknt.com/GetMFG_Lot_Number_ID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        long GetMFG_Lot_Number_ID(int uapid, string ChipID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schickweb.schicknt.com/GetMFG_Lot_Number_ID", ReplyAction="*")]
        System.Threading.Tasks.Task<long> GetMFG_Lot_Number_IDAsync(int uapid, string ChipID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schickweb.schicknt.com/GetChipID_By_MFG_Lot_Number_ID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetChipID_By_MFG_Lot_Number_ID(long uapid, long MFG_Lot_Number_ID, int WaferNumber, int DieNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schickweb.schicknt.com/GetChipID_By_MFG_Lot_Number_ID", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GetChipID_By_MFG_Lot_Number_IDAsync(long uapid, long MFG_Lot_Number_ID, int WaferNumber, int DieNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schickweb.schicknt.com/SaveWorkingTestDataXML", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string SaveWorkingTestDataXML(int uapid, string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schickweb.schicknt.com/SaveWorkingTestDataXML", ReplyAction="*")]
        System.Threading.Tasks.Task<string> SaveWorkingTestDataXMLAsync(int uapid, string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schickweb.schicknt.com/SaveLotProcessResults", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string SaveLotProcessResults(int uapid, string lotid, string waferid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schickweb.schicknt.com/SaveLotProcessResults", ReplyAction="*")]
        System.Threading.Tasks.Task<string> SaveLotProcessResultsAsync(int uapid, string lotid, string waferid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schickweb.schicknt.com/Logout", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int Logout(int uapid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schickweb.schicknt.com/Logout", ReplyAction="*")]
        System.Threading.Tasks.Task<int> LogoutAsync(int uapid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schickweb.schicknt.com/getLotInfo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable getLotInfo(int uapid, string lotid, string wafercarrierid, string chipid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schickweb.schicknt.com/getLotInfo", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> getLotInfoAsync(int uapid, string lotid, string wafercarrierid, string chipid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schickweb.schicknt.com/getTestTypeID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string getTestTypeID(int uapid, string lotid, string wafercarrierid, string chipid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schickweb.schicknt.com/getTestTypeID", ReplyAction="*")]
        System.Threading.Tasks.Task<string> getTestTypeIDAsync(int uapid, string lotid, string wafercarrierid, string chipid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schickweb.schicknt.com/getDiesPerLot", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int getDiesPerLot(int uapid, string lotid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schickweb.schicknt.com/getDiesPerLot", ReplyAction="*")]
        System.Threading.Tasks.Task<int> getDiesPerLotAsync(int uapid, string lotid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schickweb.schicknt.com/MoveVerifySerialization", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string MoveVerifySerialization(int uapid, string serialNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schickweb.schicknt.com/MoveVerifySerialization", ReplyAction="*")]
        System.Threading.Tasks.Task<string> MoveVerifySerializationAsync(int uapid, string serialNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schickweb.schicknt.com/SendEvent", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void SendEvent(int uapid, string Subject, string Body, string deviceGuid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schickweb.schicknt.com/SendEvent", ReplyAction="*")]
        System.Threading.Tasks.Task SendEventAsync(int uapid, string Subject, string Body, string deviceGuid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schickweb.schicknt.com/GetUserName", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetUserName(int uapid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schickweb.schicknt.com/GetUserName", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GetUserNameAsync(int uapid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schickweb.schicknt.com/getTestImages", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] getTestImages(int uapid, string byTestTypeName, string byTestTypeID, string byLotnumber, string bySensorpartnumber, string byImageFilePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schickweb.schicknt.com/getTestImages", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> getTestImagesAsync(int uapid, string byTestTypeName, string byTestTypeID, string byLotnumber, string bySensorpartnumber, string byImageFilePath);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schickweb.schicknt.com/")]
    public partial class SensorDataBaseAccess : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string userNameField;
        
        private string fullNameField;
        
        private string uAPIDField;
        
        private bool isCompanyAdminField;
        
        private bool isUserAdminField;
        
        private bool isSuperAdminField;
        
        private string centralAccessField;
        
        private string helpdeskAccessField;
        
        private string homePageField;
        
        private bool canAddCompanyField;
        
        private bool canAddLocationField;
        
        private bool canAccessLiveTestResultField;
        
        private bool canAccessRecordedTestResultField;
        
        private string parentCompanyIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string UserName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
                this.RaisePropertyChanged("UserName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string FullName {
            get {
                return this.fullNameField;
            }
            set {
                this.fullNameField = value;
                this.RaisePropertyChanged("FullName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string UAPID {
            get {
                return this.uAPIDField;
            }
            set {
                this.uAPIDField = value;
                this.RaisePropertyChanged("UAPID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool isCompanyAdmin {
            get {
                return this.isCompanyAdminField;
            }
            set {
                this.isCompanyAdminField = value;
                this.RaisePropertyChanged("isCompanyAdmin");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public bool isUserAdmin {
            get {
                return this.isUserAdminField;
            }
            set {
                this.isUserAdminField = value;
                this.RaisePropertyChanged("isUserAdmin");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public bool isSuperAdmin {
            get {
                return this.isSuperAdminField;
            }
            set {
                this.isSuperAdminField = value;
                this.RaisePropertyChanged("isSuperAdmin");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string centralAccess {
            get {
                return this.centralAccessField;
            }
            set {
                this.centralAccessField = value;
                this.RaisePropertyChanged("centralAccess");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string helpdeskAccess {
            get {
                return this.helpdeskAccessField;
            }
            set {
                this.helpdeskAccessField = value;
                this.RaisePropertyChanged("helpdeskAccess");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string homePage {
            get {
                return this.homePageField;
            }
            set {
                this.homePageField = value;
                this.RaisePropertyChanged("homePage");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public bool CanAddCompany {
            get {
                return this.canAddCompanyField;
            }
            set {
                this.canAddCompanyField = value;
                this.RaisePropertyChanged("CanAddCompany");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public bool CanAddLocation {
            get {
                return this.canAddLocationField;
            }
            set {
                this.canAddLocationField = value;
                this.RaisePropertyChanged("CanAddLocation");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public bool CanAccessLiveTestResult {
            get {
                return this.canAccessLiveTestResultField;
            }
            set {
                this.canAccessLiveTestResultField = value;
                this.RaisePropertyChanged("CanAccessLiveTestResult");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public bool CanAccessRecordedTestResult {
            get {
                return this.canAccessRecordedTestResultField;
            }
            set {
                this.canAccessRecordedTestResultField = value;
                this.RaisePropertyChanged("CanAccessRecordedTestResult");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public string parentCompanyID {
            get {
                return this.parentCompanyIDField;
            }
            set {
                this.parentCompanyIDField = value;
                this.RaisePropertyChanged("parentCompanyID");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SensorDataAccessServiceWSSoapChannel : Hierarchy_Client.SchickWeb.SensorDataAccessServiceWSSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SensorDataAccessServiceWSSoapClient : System.ServiceModel.ClientBase<Hierarchy_Client.SchickWeb.SensorDataAccessServiceWSSoap>, Hierarchy_Client.SchickWeb.SensorDataAccessServiceWSSoap {
        
        public SensorDataAccessServiceWSSoapClient() {
        }
        
        public SensorDataAccessServiceWSSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SensorDataAccessServiceWSSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SensorDataAccessServiceWSSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SensorDataAccessServiceWSSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string WhoIsThis() {
            return base.Channel.WhoIsThis();
        }
        
        public System.Threading.Tasks.Task<string> WhoIsThisAsync() {
            return base.Channel.WhoIsThisAsync();
        }
        
        public string Login(string username, string password) {
            return base.Channel.Login(username, password);
        }
        
        public System.Threading.Tasks.Task<string> LoginAsync(string username, string password) {
            return base.Channel.LoginAsync(username, password);
        }
        
        public Hierarchy_Client.SchickWeb.SensorDataBaseAccess getUserInfo(string username, string password) {
            return base.Channel.getUserInfo(username, password);
        }
        
        public System.Threading.Tasks.Task<Hierarchy_Client.SchickWeb.SensorDataBaseAccess> getUserInfoAsync(string username, string password) {
            return base.Channel.getUserInfoAsync(username, password);
        }
        
        public int IsWaferExists(int uapid, string carrieridwafernumber, string RecipeStep) {
            return base.Channel.IsWaferExists(uapid, carrieridwafernumber, RecipeStep);
        }
        
        public System.Threading.Tasks.Task<int> IsWaferExistsAsync(int uapid, string carrieridwafernumber, string RecipeStep) {
            return base.Channel.IsWaferExistsAsync(uapid, carrieridwafernumber, RecipeStep);
        }
        
        public int SaveLotFailedSensors(int uapid, string xml_lot_data) {
            return base.Channel.SaveLotFailedSensors(uapid, xml_lot_data);
        }
        
        public System.Threading.Tasks.Task<int> SaveLotFailedSensorsAsync(int uapid, string xml_lot_data) {
            return base.Channel.SaveLotFailedSensorsAsync(uapid, xml_lot_data);
        }
        
        public long GetMFG_Lot_Number_ID(int uapid, string ChipID) {
            return base.Channel.GetMFG_Lot_Number_ID(uapid, ChipID);
        }
        
        public System.Threading.Tasks.Task<long> GetMFG_Lot_Number_IDAsync(int uapid, string ChipID) {
            return base.Channel.GetMFG_Lot_Number_IDAsync(uapid, ChipID);
        }
        
        public string GetChipID_By_MFG_Lot_Number_ID(long uapid, long MFG_Lot_Number_ID, int WaferNumber, int DieNumber) {
            return base.Channel.GetChipID_By_MFG_Lot_Number_ID(uapid, MFG_Lot_Number_ID, WaferNumber, DieNumber);
        }
        
        public System.Threading.Tasks.Task<string> GetChipID_By_MFG_Lot_Number_IDAsync(long uapid, long MFG_Lot_Number_ID, int WaferNumber, int DieNumber) {
            return base.Channel.GetChipID_By_MFG_Lot_Number_IDAsync(uapid, MFG_Lot_Number_ID, WaferNumber, DieNumber);
        }
        
        public string SaveWorkingTestDataXML(int uapid, string xml) {
            return base.Channel.SaveWorkingTestDataXML(uapid, xml);
        }
        
        public System.Threading.Tasks.Task<string> SaveWorkingTestDataXMLAsync(int uapid, string xml) {
            return base.Channel.SaveWorkingTestDataXMLAsync(uapid, xml);
        }
        
        public string SaveLotProcessResults(int uapid, string lotid, string waferid) {
            return base.Channel.SaveLotProcessResults(uapid, lotid, waferid);
        }
        
        public System.Threading.Tasks.Task<string> SaveLotProcessResultsAsync(int uapid, string lotid, string waferid) {
            return base.Channel.SaveLotProcessResultsAsync(uapid, lotid, waferid);
        }
        
        public int Logout(int uapid) {
            return base.Channel.Logout(uapid);
        }
        
        public System.Threading.Tasks.Task<int> LogoutAsync(int uapid) {
            return base.Channel.LogoutAsync(uapid);
        }
        
        public System.Data.DataTable getLotInfo(int uapid, string lotid, string wafercarrierid, string chipid) {
            return base.Channel.getLotInfo(uapid, lotid, wafercarrierid, chipid);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> getLotInfoAsync(int uapid, string lotid, string wafercarrierid, string chipid) {
            return base.Channel.getLotInfoAsync(uapid, lotid, wafercarrierid, chipid);
        }
        
        public string getTestTypeID(int uapid, string lotid, string wafercarrierid, string chipid) {
            return base.Channel.getTestTypeID(uapid, lotid, wafercarrierid, chipid);
        }
        
        public System.Threading.Tasks.Task<string> getTestTypeIDAsync(int uapid, string lotid, string wafercarrierid, string chipid) {
            return base.Channel.getTestTypeIDAsync(uapid, lotid, wafercarrierid, chipid);
        }
        
        public int getDiesPerLot(int uapid, string lotid) {
            return base.Channel.getDiesPerLot(uapid, lotid);
        }
        
        public System.Threading.Tasks.Task<int> getDiesPerLotAsync(int uapid, string lotid) {
            return base.Channel.getDiesPerLotAsync(uapid, lotid);
        }
        
        public string MoveVerifySerialization(int uapid, string serialNumber) {
            return base.Channel.MoveVerifySerialization(uapid, serialNumber);
        }
        
        public System.Threading.Tasks.Task<string> MoveVerifySerializationAsync(int uapid, string serialNumber) {
            return base.Channel.MoveVerifySerializationAsync(uapid, serialNumber);
        }
        
        public void SendEvent(int uapid, string Subject, string Body, string deviceGuid) {
            base.Channel.SendEvent(uapid, Subject, Body, deviceGuid);
        }
        
        public System.Threading.Tasks.Task SendEventAsync(int uapid, string Subject, string Body, string deviceGuid) {
            return base.Channel.SendEventAsync(uapid, Subject, Body, deviceGuid);
        }
        
        public string GetUserName(int uapid) {
            return base.Channel.GetUserName(uapid);
        }
        
        public System.Threading.Tasks.Task<string> GetUserNameAsync(int uapid) {
            return base.Channel.GetUserNameAsync(uapid);
        }
        
        public string[] getTestImages(int uapid, string byTestTypeName, string byTestTypeID, string byLotnumber, string bySensorpartnumber, string byImageFilePath) {
            return base.Channel.getTestImages(uapid, byTestTypeName, byTestTypeID, byLotnumber, bySensorpartnumber, byImageFilePath);
        }
        
        public System.Threading.Tasks.Task<string[]> getTestImagesAsync(int uapid, string byTestTypeName, string byTestTypeID, string byLotnumber, string bySensorpartnumber, string byImageFilePath) {
            return base.Channel.getTestImagesAsync(uapid, byTestTypeName, byTestTypeID, byLotnumber, bySensorpartnumber, byImageFilePath);
        }
    }
}
// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// adoxio_area
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioArea
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMadoxioArea
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioArea()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMadoxioArea
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioArea(int? utcconversiontimezonecode = default(int?), int? timezoneruleversionnumber = default(int?), string _modifiedonbehalfbyValue = default(string), string adoxioName = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? statuscode = default(int?), string adoxioDescription = default(string), string _owningbusinessunitValue = default(string), string _owningteamValue = default(string), int? statecode = default(int?), string _adoxioRegionValue = default(string), string _createdonbehalfbyValue = default(string), string adoxioAreaid = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? adoxioNumber = default(int?), string _owneridValue = default(string), string _modifiedbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), long? versionnumber = default(long?), string _createdbyValue = default(string), int? importsequencenumber = default(int?), string _adoxioPrimaryinspectorValue = default(string), string _owninguserValue = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioAreaSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioAreaDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioAreaDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioAreaAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioAreaBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMsystemuser adoxioPrimaryInspector = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMadoxioRegion adoxioRegion = default(MicrosoftDynamicsCRMadoxioRegion), IList<MicrosoftDynamicsCRMadoxioPostalcode> adoxioAreaAdoxioPostalcodeArea = default(IList<MicrosoftDynamicsCRMadoxioPostalcode>), IList<MicrosoftDynamicsCRMincident> adoxioAreaIncidentArea = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMadoxioCitydistrict> adoxioAreaAdoxioCitydistrictAreaId = default(IList<MicrosoftDynamicsCRMadoxioCitydistrict>), IList<MicrosoftDynamicsCRMadoxioApplication> adoxioAreaAdoxioApplicationArea = default(IList<MicrosoftDynamicsCRMadoxioApplication>), IList<MicrosoftDynamicsCRMadoxioEstablishment> adoxioAreaAdoxioEstablishmentArea = default(IList<MicrosoftDynamicsCRMadoxioEstablishment>))
        {
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            AdoxioName = adoxioName;
            Modifiedon = modifiedon;
            Statuscode = statuscode;
            AdoxioDescription = adoxioDescription;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._owningteamValue = _owningteamValue;
            Statecode = statecode;
            this._adoxioRegionValue = _adoxioRegionValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            AdoxioAreaid = adoxioAreaid;
            Overriddencreatedon = overriddencreatedon;
            AdoxioNumber = adoxioNumber;
            this._owneridValue = _owneridValue;
            this._modifiedbyValue = _modifiedbyValue;
            Createdon = createdon;
            Versionnumber = versionnumber;
            this._createdbyValue = _createdbyValue;
            Importsequencenumber = importsequencenumber;
            this._adoxioPrimaryinspectorValue = _adoxioPrimaryinspectorValue;
            this._owninguserValue = _owninguserValue;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioAreaSyncErrors = adoxioAreaSyncErrors;
            AdoxioAreaDuplicateMatchingRecord = adoxioAreaDuplicateMatchingRecord;
            AdoxioAreaDuplicateBaseRecord = adoxioAreaDuplicateBaseRecord;
            AdoxioAreaAsyncOperations = adoxioAreaAsyncOperations;
            AdoxioAreaBulkDeleteFailures = adoxioAreaBulkDeleteFailures;
            AdoxioPrimaryInspector = adoxioPrimaryInspector;
            AdoxioRegion = adoxioRegion;
            AdoxioAreaAdoxioPostalcodeArea = adoxioAreaAdoxioPostalcodeArea;
            AdoxioAreaIncidentArea = adoxioAreaIncidentArea;
            AdoxioAreaAdoxioCitydistrictAreaId = adoxioAreaAdoxioCitydistrictAreaId;
            AdoxioAreaAdoxioApplicationArea = adoxioAreaAdoxioApplicationArea;
            AdoxioAreaAdoxioEstablishmentArea = adoxioAreaAdoxioEstablishmentArea;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_description")]
        public string AdoxioDescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_region_value")]
        public string _adoxioRegionValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_areaid")]
        public string AdoxioAreaid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_number")]
        public int? AdoxioNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_primaryinspector_value")]
        public string _adoxioPrimaryinspectorValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_area_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioAreaSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_area_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioAreaDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_area_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioAreaDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_area_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioAreaAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_area_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioAreaBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_PrimaryInspector")]
        public MicrosoftDynamicsCRMsystemuser AdoxioPrimaryInspector { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Region")]
        public MicrosoftDynamicsCRMadoxioRegion AdoxioRegion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_area_adoxio_postalcode_Area")]
        public IList<MicrosoftDynamicsCRMadoxioPostalcode> AdoxioAreaAdoxioPostalcodeArea { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_area_incident_Area")]
        public IList<MicrosoftDynamicsCRMincident> AdoxioAreaIncidentArea { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_area_adoxio_citydistrict_AreaId")]
        public IList<MicrosoftDynamicsCRMadoxioCitydistrict> AdoxioAreaAdoxioCitydistrictAreaId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_area_adoxio_application_Area")]
        public IList<MicrosoftDynamicsCRMadoxioApplication> AdoxioAreaAdoxioApplicationArea { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_area_adoxio_establishment_Area")]
        public IList<MicrosoftDynamicsCRMadoxioEstablishment> AdoxioAreaAdoxioEstablishmentArea { get; set; }

    }
}

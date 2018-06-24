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

    public partial class MicrosoftDynamicsCRMconnection
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMconnection
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMconnection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMconnection
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMconnection(IList<MicrosoftDynamicsCRMasyncoperation> connectionAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMsyncerror> connectionSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), string _modifiedbyValue = default(string), string _modifiedonbehalfbyValue = default(string), string _owneridValue = default(string), string _owningbusinessunitValue = default(string), string _owningteamValue = default(string), string _owninguserValue = default(string), string _record1idValue = default(string), string _record1roleidValue = default(string), string _record2idValue = default(string), string _record2roleidValue = default(string), string _relatedconnectionidValue = default(string), string _transactioncurrencyidValue = default(string), IList<MicrosoftDynamicsCRMconnection> connectionRelatedConnection = default(IList<MicrosoftDynamicsCRMconnection>), string connectionid = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), string description = default(string), System.DateTimeOffset? effectiveend = default(System.DateTimeOffset?), System.DateTimeOffset? effectivestart = default(System.DateTimeOffset?), string entityimage = default(string), object entityimageTimestamp = default(object), string entityimageUrl = default(string), string entityimageid = default(string), double? exchangerate = default(double?), int? importsequencenumber = default(int?), bool? ismaster = default(bool?), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), string name = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMaccount record1idAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMactivitypointer record1idActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), MicrosoftDynamicsCRMappointment record1idAppointment = default(MicrosoftDynamicsCRMappointment), MicrosoftDynamicsCRMcampaign record1idCampaign = default(MicrosoftDynamicsCRMcampaign), MicrosoftDynamicsCRMcampaignactivity record1idCampaignactivity = default(MicrosoftDynamicsCRMcampaignactivity), MicrosoftDynamicsCRMcompetitor record1idCompetitor = default(MicrosoftDynamicsCRMcompetitor), MicrosoftDynamicsCRMconstraintbasedgroup record1idConstraintbasedgroup = default(MicrosoftDynamicsCRMconstraintbasedgroup), MicrosoftDynamicsCRMcontact record1idContact = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMcontract record1idContract = default(MicrosoftDynamicsCRMcontract), MicrosoftDynamicsCRMemail record1idEmail = default(MicrosoftDynamicsCRMemail), MicrosoftDynamicsCRMentitlement record1idEntitlement = default(MicrosoftDynamicsCRMentitlement), MicrosoftDynamicsCRMequipment record1idEquipment = default(MicrosoftDynamicsCRMequipment), MicrosoftDynamicsCRMfax record1idFax = default(MicrosoftDynamicsCRMfax), MicrosoftDynamicsCRMgoal record1idGoal = default(MicrosoftDynamicsCRMgoal), MicrosoftDynamicsCRMincident record1idIncident = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMinvoice record1idInvoice = default(MicrosoftDynamicsCRMinvoice), MicrosoftDynamicsCRMknowledgearticle record1idKnowledgearticle = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMknowledgebaserecord record1idKnowledgebaserecord = default(MicrosoftDynamicsCRMknowledgebaserecord), MicrosoftDynamicsCRMlead record1idLead = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMletter record1idLetter = default(MicrosoftDynamicsCRMletter), MicrosoftDynamicsCRMlist record1idList = default(MicrosoftDynamicsCRMlist), MicrosoftDynamicsCRMopportunity record1idOpportunity = default(MicrosoftDynamicsCRMopportunity), MicrosoftDynamicsCRMphonecall record1idPhonecall = default(MicrosoftDynamicsCRMphonecall), MicrosoftDynamicsCRMposition record1idPosition = default(MicrosoftDynamicsCRMposition), MicrosoftDynamicsCRMpricelevel record1idPricelevel = default(MicrosoftDynamicsCRMpricelevel), MicrosoftDynamicsCRMproduct record1idProduct = default(MicrosoftDynamicsCRMproduct), MicrosoftDynamicsCRMquote record1idQuote = default(MicrosoftDynamicsCRMquote), MicrosoftDynamicsCRMrecurringappointmentmaster record1idRecurringappointmentmaster = default(MicrosoftDynamicsCRMrecurringappointmentmaster), MicrosoftDynamicsCRMresourcegroup record1idResourcegroup = default(MicrosoftDynamicsCRMresourcegroup), MicrosoftDynamicsCRMsalesorder record1idSalesorder = default(MicrosoftDynamicsCRMsalesorder), MicrosoftDynamicsCRMserviceappointment record1idServiceappointment = default(MicrosoftDynamicsCRMserviceappointment), MicrosoftDynamicsCRMsocialactivity record1idSocialactivity = default(MicrosoftDynamicsCRMsocialactivity), MicrosoftDynamicsCRMsocialprofile record1idSocialprofile = default(MicrosoftDynamicsCRMsocialprofile), MicrosoftDynamicsCRMsystemuser record1idSystemuser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMtask record1idTask = default(MicrosoftDynamicsCRMtask), MicrosoftDynamicsCRMteam record1idTeam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMterritory record1idTerritory = default(MicrosoftDynamicsCRMterritory), int? record1objecttypecode = default(int?), MicrosoftDynamicsCRMconnectionrole record1roleid = default(MicrosoftDynamicsCRMconnectionrole), MicrosoftDynamicsCRMaccount record2idAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMactivitypointer record2idActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), MicrosoftDynamicsCRMappointment record2idAppointment = default(MicrosoftDynamicsCRMappointment), MicrosoftDynamicsCRMcampaign record2idCampaign = default(MicrosoftDynamicsCRMcampaign), MicrosoftDynamicsCRMcampaignactivity record2idCampaignactivity = default(MicrosoftDynamicsCRMcampaignactivity), MicrosoftDynamicsCRMcompetitor record2idCompetitor = default(MicrosoftDynamicsCRMcompetitor), MicrosoftDynamicsCRMconstraintbasedgroup record2idConstraintbasedgroup = default(MicrosoftDynamicsCRMconstraintbasedgroup), MicrosoftDynamicsCRMcontact record2idContact = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMcontract record2idContract = default(MicrosoftDynamicsCRMcontract), MicrosoftDynamicsCRMemail record2idEmail = default(MicrosoftDynamicsCRMemail), MicrosoftDynamicsCRMentitlement record2idEntitlement = default(MicrosoftDynamicsCRMentitlement), MicrosoftDynamicsCRMequipment record2idEquipment = default(MicrosoftDynamicsCRMequipment), MicrosoftDynamicsCRMfax record2idFax = default(MicrosoftDynamicsCRMfax), MicrosoftDynamicsCRMgoal record2idGoal = default(MicrosoftDynamicsCRMgoal), MicrosoftDynamicsCRMincident record2idIncident = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMinvoice record2idInvoice = default(MicrosoftDynamicsCRMinvoice), MicrosoftDynamicsCRMknowledgearticle record2idKnowledgearticle = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMknowledgebaserecord record2idKnowledgebaserecord = default(MicrosoftDynamicsCRMknowledgebaserecord), MicrosoftDynamicsCRMlead record2idLead = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMletter record2idLetter = default(MicrosoftDynamicsCRMletter), MicrosoftDynamicsCRMlist record2idList = default(MicrosoftDynamicsCRMlist), MicrosoftDynamicsCRMopportunity record2idOpportunity = default(MicrosoftDynamicsCRMopportunity), MicrosoftDynamicsCRMphonecall record2idPhonecall = default(MicrosoftDynamicsCRMphonecall), MicrosoftDynamicsCRMposition record2idPosition = default(MicrosoftDynamicsCRMposition), MicrosoftDynamicsCRMpricelevel record2idPricelevel = default(MicrosoftDynamicsCRMpricelevel), MicrosoftDynamicsCRMproduct record2idProduct = default(MicrosoftDynamicsCRMproduct), MicrosoftDynamicsCRMquote record2idQuote = default(MicrosoftDynamicsCRMquote), MicrosoftDynamicsCRMrecurringappointmentmaster record2idRecurringappointmentmaster = default(MicrosoftDynamicsCRMrecurringappointmentmaster), MicrosoftDynamicsCRMresourcegroup record2idResourcegroup = default(MicrosoftDynamicsCRMresourcegroup), MicrosoftDynamicsCRMsalesorder record2idSalesorder = default(MicrosoftDynamicsCRMsalesorder), MicrosoftDynamicsCRMserviceappointment record2idServiceappointment = default(MicrosoftDynamicsCRMserviceappointment), MicrosoftDynamicsCRMsocialactivity record2idSocialactivity = default(MicrosoftDynamicsCRMsocialactivity), MicrosoftDynamicsCRMsocialprofile record2idSocialprofile = default(MicrosoftDynamicsCRMsocialprofile), MicrosoftDynamicsCRMsystemuser record2idSystemuser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMtask record2idTask = default(MicrosoftDynamicsCRMtask), MicrosoftDynamicsCRMteam record2idTeam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMterritory record2idTerritory = default(MicrosoftDynamicsCRMterritory), int? record2objecttypecode = default(int?), MicrosoftDynamicsCRMconnectionrole record2roleid = default(MicrosoftDynamicsCRMconnectionrole), MicrosoftDynamicsCRMconnection relatedconnectionid = default(MicrosoftDynamicsCRMconnection), int? statecode = default(int?), int? statuscode = default(int?), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), object versionnumber = default(object))
        {
            ConnectionAsyncOperations = connectionAsyncOperations;
            ConnectionSyncErrors = connectionSyncErrors;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._owneridValue = _owneridValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._owningteamValue = _owningteamValue;
            this._owninguserValue = _owninguserValue;
            this._record1idValue = _record1idValue;
            this._record1roleidValue = _record1roleidValue;
            this._record2idValue = _record2idValue;
            this._record2roleidValue = _record2roleidValue;
            this._relatedconnectionidValue = _relatedconnectionidValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            ConnectionRelatedConnection = connectionRelatedConnection;
            Connectionid = connectionid;
            Createdby = createdby;
            Createdon = createdon;
            Createdonbehalfby = createdonbehalfby;
            Description = description;
            Effectiveend = effectiveend;
            Effectivestart = effectivestart;
            Entityimage = entityimage;
            EntityimageTimestamp = entityimageTimestamp;
            EntityimageUrl = entityimageUrl;
            Entityimageid = entityimageid;
            Exchangerate = exchangerate;
            Importsequencenumber = importsequencenumber;
            Ismaster = ismaster;
            Modifiedby = modifiedby;
            Modifiedon = modifiedon;
            Modifiedonbehalfby = modifiedonbehalfby;
            Name = name;
            Overriddencreatedon = overriddencreatedon;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            Record1idAccount = record1idAccount;
            Record1idActivitypointer = record1idActivitypointer;
            Record1idAppointment = record1idAppointment;
            Record1idCampaign = record1idCampaign;
            Record1idCampaignactivity = record1idCampaignactivity;
            Record1idCompetitor = record1idCompetitor;
            Record1idConstraintbasedgroup = record1idConstraintbasedgroup;
            Record1idContact = record1idContact;
            Record1idContract = record1idContract;
            Record1idEmail = record1idEmail;
            Record1idEntitlement = record1idEntitlement;
            Record1idEquipment = record1idEquipment;
            Record1idFax = record1idFax;
            Record1idGoal = record1idGoal;
            Record1idIncident = record1idIncident;
            Record1idInvoice = record1idInvoice;
            Record1idKnowledgearticle = record1idKnowledgearticle;
            Record1idKnowledgebaserecord = record1idKnowledgebaserecord;
            Record1idLead = record1idLead;
            Record1idLetter = record1idLetter;
            Record1idList = record1idList;
            Record1idOpportunity = record1idOpportunity;
            Record1idPhonecall = record1idPhonecall;
            Record1idPosition = record1idPosition;
            Record1idPricelevel = record1idPricelevel;
            Record1idProduct = record1idProduct;
            Record1idQuote = record1idQuote;
            Record1idRecurringappointmentmaster = record1idRecurringappointmentmaster;
            Record1idResourcegroup = record1idResourcegroup;
            Record1idSalesorder = record1idSalesorder;
            Record1idServiceappointment = record1idServiceappointment;
            Record1idSocialactivity = record1idSocialactivity;
            Record1idSocialprofile = record1idSocialprofile;
            Record1idSystemuser = record1idSystemuser;
            Record1idTask = record1idTask;
            Record1idTeam = record1idTeam;
            Record1idTerritory = record1idTerritory;
            Record1objecttypecode = record1objecttypecode;
            Record1roleid = record1roleid;
            Record2idAccount = record2idAccount;
            Record2idActivitypointer = record2idActivitypointer;
            Record2idAppointment = record2idAppointment;
            Record2idCampaign = record2idCampaign;
            Record2idCampaignactivity = record2idCampaignactivity;
            Record2idCompetitor = record2idCompetitor;
            Record2idConstraintbasedgroup = record2idConstraintbasedgroup;
            Record2idContact = record2idContact;
            Record2idContract = record2idContract;
            Record2idEmail = record2idEmail;
            Record2idEntitlement = record2idEntitlement;
            Record2idEquipment = record2idEquipment;
            Record2idFax = record2idFax;
            Record2idGoal = record2idGoal;
            Record2idIncident = record2idIncident;
            Record2idInvoice = record2idInvoice;
            Record2idKnowledgearticle = record2idKnowledgearticle;
            Record2idKnowledgebaserecord = record2idKnowledgebaserecord;
            Record2idLead = record2idLead;
            Record2idLetter = record2idLetter;
            Record2idList = record2idList;
            Record2idOpportunity = record2idOpportunity;
            Record2idPhonecall = record2idPhonecall;
            Record2idPosition = record2idPosition;
            Record2idPricelevel = record2idPricelevel;
            Record2idProduct = record2idProduct;
            Record2idQuote = record2idQuote;
            Record2idRecurringappointmentmaster = record2idRecurringappointmentmaster;
            Record2idResourcegroup = record2idResourcegroup;
            Record2idSalesorder = record2idSalesorder;
            Record2idServiceappointment = record2idServiceappointment;
            Record2idSocialactivity = record2idSocialactivity;
            Record2idSocialprofile = record2idSocialprofile;
            Record2idSystemuser = record2idSystemuser;
            Record2idTask = record2idTask;
            Record2idTeam = record2idTeam;
            Record2idTerritory = record2idTerritory;
            Record2objecttypecode = record2objecttypecode;
            Record2roleid = record2roleid;
            Relatedconnectionid = relatedconnectionid;
            Statecode = statecode;
            Statuscode = statuscode;
            Transactioncurrencyid = transactioncurrencyid;
            Versionnumber = versionnumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Connection_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ConnectionAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Connection_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> ConnectionSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

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
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_record1id_value")]
        public string _record1idValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_record1roleid_value")]
        public string _record1roleidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_record2id_value")]
        public string _record2idValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_record2roleid_value")]
        public string _record2roleidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_relatedconnectionid_value")]
        public string _relatedconnectionidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "connection_related_connection")]
        public IList<MicrosoftDynamicsCRMconnection> ConnectionRelatedConnection { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "connectionid")]
        public string Connectionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "effectiveend")]
        public System.DateTimeOffset? Effectiveend { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "effectivestart")]
        public System.DateTimeOffset? Effectivestart { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage")]
        public string Entityimage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_timestamp")]
        public object EntityimageTimestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_url")]
        public string EntityimageUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimageid")]
        public string Entityimageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public double? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismaster")]
        public bool? Ismaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

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
        [JsonProperty(PropertyName = "record1id_account")]
        public MicrosoftDynamicsCRMaccount Record1idAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer Record1idActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_appointment")]
        public MicrosoftDynamicsCRMappointment Record1idAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_campaign")]
        public MicrosoftDynamicsCRMcampaign Record1idCampaign { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_campaignactivity")]
        public MicrosoftDynamicsCRMcampaignactivity Record1idCampaignactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_competitor")]
        public MicrosoftDynamicsCRMcompetitor Record1idCompetitor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_constraintbasedgroup")]
        public MicrosoftDynamicsCRMconstraintbasedgroup Record1idConstraintbasedgroup { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_contact")]
        public MicrosoftDynamicsCRMcontact Record1idContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_contract")]
        public MicrosoftDynamicsCRMcontract Record1idContract { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_email")]
        public MicrosoftDynamicsCRMemail Record1idEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_entitlement")]
        public MicrosoftDynamicsCRMentitlement Record1idEntitlement { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_equipment")]
        public MicrosoftDynamicsCRMequipment Record1idEquipment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_fax")]
        public MicrosoftDynamicsCRMfax Record1idFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_goal")]
        public MicrosoftDynamicsCRMgoal Record1idGoal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_incident")]
        public MicrosoftDynamicsCRMincident Record1idIncident { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_invoice")]
        public MicrosoftDynamicsCRMinvoice Record1idInvoice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_knowledgearticle")]
        public MicrosoftDynamicsCRMknowledgearticle Record1idKnowledgearticle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_knowledgebaserecord")]
        public MicrosoftDynamicsCRMknowledgebaserecord Record1idKnowledgebaserecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_lead")]
        public MicrosoftDynamicsCRMlead Record1idLead { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_letter")]
        public MicrosoftDynamicsCRMletter Record1idLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_list")]
        public MicrosoftDynamicsCRMlist Record1idList { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_opportunity")]
        public MicrosoftDynamicsCRMopportunity Record1idOpportunity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_phonecall")]
        public MicrosoftDynamicsCRMphonecall Record1idPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_position")]
        public MicrosoftDynamicsCRMposition Record1idPosition { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_pricelevel")]
        public MicrosoftDynamicsCRMpricelevel Record1idPricelevel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_product")]
        public MicrosoftDynamicsCRMproduct Record1idProduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_quote")]
        public MicrosoftDynamicsCRMquote Record1idQuote { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMrecurringappointmentmaster Record1idRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_resourcegroup")]
        public MicrosoftDynamicsCRMresourcegroup Record1idResourcegroup { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_salesorder")]
        public MicrosoftDynamicsCRMsalesorder Record1idSalesorder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_serviceappointment")]
        public MicrosoftDynamicsCRMserviceappointment Record1idServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_socialactivity")]
        public MicrosoftDynamicsCRMsocialactivity Record1idSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_socialprofile")]
        public MicrosoftDynamicsCRMsocialprofile Record1idSocialprofile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_systemuser")]
        public MicrosoftDynamicsCRMsystemuser Record1idSystemuser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_task")]
        public MicrosoftDynamicsCRMtask Record1idTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_team")]
        public MicrosoftDynamicsCRMteam Record1idTeam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1id_territory")]
        public MicrosoftDynamicsCRMterritory Record1idTerritory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1objecttypecode")]
        public int? Record1objecttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record1roleid")]
        public MicrosoftDynamicsCRMconnectionrole Record1roleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_account")]
        public MicrosoftDynamicsCRMaccount Record2idAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer Record2idActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_appointment")]
        public MicrosoftDynamicsCRMappointment Record2idAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_campaign")]
        public MicrosoftDynamicsCRMcampaign Record2idCampaign { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_campaignactivity")]
        public MicrosoftDynamicsCRMcampaignactivity Record2idCampaignactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_competitor")]
        public MicrosoftDynamicsCRMcompetitor Record2idCompetitor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_constraintbasedgroup")]
        public MicrosoftDynamicsCRMconstraintbasedgroup Record2idConstraintbasedgroup { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_contact")]
        public MicrosoftDynamicsCRMcontact Record2idContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_contract")]
        public MicrosoftDynamicsCRMcontract Record2idContract { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_email")]
        public MicrosoftDynamicsCRMemail Record2idEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_entitlement")]
        public MicrosoftDynamicsCRMentitlement Record2idEntitlement { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_equipment")]
        public MicrosoftDynamicsCRMequipment Record2idEquipment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_fax")]
        public MicrosoftDynamicsCRMfax Record2idFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_goal")]
        public MicrosoftDynamicsCRMgoal Record2idGoal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_incident")]
        public MicrosoftDynamicsCRMincident Record2idIncident { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_invoice")]
        public MicrosoftDynamicsCRMinvoice Record2idInvoice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_knowledgearticle")]
        public MicrosoftDynamicsCRMknowledgearticle Record2idKnowledgearticle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_knowledgebaserecord")]
        public MicrosoftDynamicsCRMknowledgebaserecord Record2idKnowledgebaserecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_lead")]
        public MicrosoftDynamicsCRMlead Record2idLead { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_letter")]
        public MicrosoftDynamicsCRMletter Record2idLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_list")]
        public MicrosoftDynamicsCRMlist Record2idList { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_opportunity")]
        public MicrosoftDynamicsCRMopportunity Record2idOpportunity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_phonecall")]
        public MicrosoftDynamicsCRMphonecall Record2idPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_position")]
        public MicrosoftDynamicsCRMposition Record2idPosition { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_pricelevel")]
        public MicrosoftDynamicsCRMpricelevel Record2idPricelevel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_product")]
        public MicrosoftDynamicsCRMproduct Record2idProduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_quote")]
        public MicrosoftDynamicsCRMquote Record2idQuote { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMrecurringappointmentmaster Record2idRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_resourcegroup")]
        public MicrosoftDynamicsCRMresourcegroup Record2idResourcegroup { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_salesorder")]
        public MicrosoftDynamicsCRMsalesorder Record2idSalesorder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_serviceappointment")]
        public MicrosoftDynamicsCRMserviceappointment Record2idServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_socialactivity")]
        public MicrosoftDynamicsCRMsocialactivity Record2idSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_socialprofile")]
        public MicrosoftDynamicsCRMsocialprofile Record2idSocialprofile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_systemuser")]
        public MicrosoftDynamicsCRMsystemuser Record2idSystemuser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_task")]
        public MicrosoftDynamicsCRMtask Record2idTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_team")]
        public MicrosoftDynamicsCRMteam Record2idTeam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2id_territory")]
        public MicrosoftDynamicsCRMterritory Record2idTerritory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2objecttypecode")]
        public int? Record2objecttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "record2roleid")]
        public MicrosoftDynamicsCRMconnectionrole Record2roleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "relatedconnectionid")]
        public MicrosoftDynamicsCRMconnection Relatedconnectionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public object Versionnumber { get; set; }

    }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Resources;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admin28.Models
{
    public enum BooleanType
    {
        T, F
    }

    public enum AgencyType
    {
        FWPD, GDPD, JCSO, LQPD, LWPD, LXPD, MHPD, MRPD, MSPD, OPD, OPPD, OTHER, PKPD, PVPD, RPPD, SHPD, SHWPD, WWPD
    }


    public class JC_HC_AGENCYMetadata
    {
        [Required]
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public short ID { get; set; }

        [Required]
        [Display(Name = "AGENCY")]
        [StringLength(6)]
        public string AG_ID { get; set; }

        [Required]
        [Display(Name = "UNITS ARRIVED")]
        [Range(1, 99)]
        public short UNITS { get; set; }
    }

    public class JC_HC_CURENTMetadata
    {
        [Required]
        [Key, Column(Order = 0)]
        public int EID { get; set; }

        [Required]
        [Display(Name = "CALL TYPE")]
        [StringLength(16)]
        public string TYCOD { get; set; }

        [Display(Name = "SUBTYPE")]
        [DisplayFormat(NullDisplayText = "NONE")]
        [StringLength(16)]
        public string SUB_TYCOD { get; set; }

        [Display(Name = "LAST UPDATE")]
        [DisplayFormat(NullDisplayText = "N/A")]
        [StringLength(16)]
        public string UDTS { get; set; }

        [Display(Name = "CALL CLOSED")]
        [DisplayFormat(NullDisplayText = "OPEN")]
        [StringLength(16)]
        public string XDTS { get; set; }

        [Display(Name = "STREET NO")]
        [DisplayFormat(NullDisplayText = "N/A")]
        [StringLength(15)]
        public string ESTNUM { get; set; }

        [Display(Name = "DIRECTIONAL")]
        [DisplayFormat(NullDisplayText = "N/A")]
        [StringLength(2)]
        public string EDIRPRE { get; set; }

        [Display(Name = "STREET NAME")]
        [DisplayFormat(NullDisplayText = "N/A")]
        [StringLength(30)]
        public string EFEANME { get; set; }

        [Display(Name = "STREET TYPE")]
        [DisplayFormat(NullDisplayText = "N/A")]
        [StringLength(4)]
        public string EFEATYP { get; set; }

        [Display(Name = "UNITS ARRIVED")]
        [DisplayFormat(NullDisplayText = "0")]
        public Nullable<short> UNIT_COUNT { get; set; }

        [Display(Name = "LOI SENT")]
        [StringLength(1)]
        public string LOI_SENT { get; set; }

        [Display(Name = "HOT CALL SENT")]
        [StringLength(1)]
        public string HC_SENT { get; set; }

        [Display(Name = "AGENCY")]
        [DisplayFormat(NullDisplayText = "NONE")]
        [StringLength(6)]
        public string AG_ID { get; set; }

        [Display(Name = "LOI EVAL")]
        [StringLength(1)]
        public string LOI_EVAL { get; set; }

        [Display(Name = "COUNT EVAL")]
        [StringLength(1)]
        public string UNIT_EVAL { get; set; }

        [Display(Name = "TYPE EVAL")]
        [StringLength(1)]
        public string TYPE_EVAL { get; set; }

        [Required]
        [Display(Name = "EVENT NO")]
        [Key, Column(Order = 1)]
        [StringLength(12)]
        public string NUM_1 { get; set; }

        [Display(Name = "CROSS 1")]
        [DisplayFormat(NullDisplayText = "N/A")]
        [StringLength(34)]
        public string XSTREET1 { get; set; }

        [Display(Name = "CROSS 2")]
        [DisplayFormat(NullDisplayText = "N/A")]
        [StringLength(34)]
        public string XSTREET2 { get; set; }

        [DisplayFormat(DataFormatString = "{0:#}")]
        public Nullable<int> ESZ { get; set; }

        [DisplayFormat(NullDisplayText = "N/A")]
        [StringLength(4000)]
        public string COMMENTS { get; set; }

        [Required]
        [Display(Name = "CALL ENTERED")]
        [Key, Column(Order = 2)]
        [StringLength(16)]
        public string AD_TS { get; set; }
    }

    public class JC_HC_LOIMetadata
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Display(Name = "HUNDRED BLOCK")]
        [DisplayFormat(NullDisplayText = "N/A")]
        [StringLength(8)]
        public string HNDR_BLCK { get; set; }

        [Display(Name = "LOCATION GROUP")]
        [DisplayFormat(NullDisplayText = "NONE")]
        [StringLength(10)]
        public string LOI_GRP_ID { get; set; }

        [DisplayFormat(DataFormatString = "{0:#}")]
        public Nullable<int> ESZ { get; set; }

        [DisplayFormat(NullDisplayText = "N/A")]
        [StringLength(15)]
        public string ZIP { get; set; }

        [Display(Name = "STREET NAME")]
        [DisplayFormat(NullDisplayText = "N/A")]
        [StringLength(30)]
        public string EFEANME { get; set; }

        [Display(Name = "STREET NUMBER")]
        [DisplayFormat(NullDisplayText = "N/A")]
        [StringLength(15)]
        public string ESTNUM { get; set; }

        [Display(Name = "DIRECTIONAL")]
        [DisplayFormat(NullDisplayText = "N/A")]
        [StringLength(2)]
        public string EDIRPRE { get; set; }

        [Display(Name = "STREET TYPE")]
        [DisplayFormat(NullDisplayText = "N/A")]
        [StringLength(4)]
        public string EFEATYP { get; set; }

        [Display(Name = "COMMON NAME")]
        [DisplayFormat(NullDisplayText = "NONE")]
        [StringLength(300)]
        public string COMMON_NAME { get; set; }

        [DisplayFormat(NullDisplayText = "COUNTY")]
        [StringLength(50)]
        public string CITY { get; set; }

        [Required]
        [StringLength(1)]
        public string ACTIVE { get; set; }

        [DisplayFormat(NullDisplayText = "N/A")]
        [StringLength(300)]
        public string ADDRESS { get; set; }
    }

    public class JC_HC_SENTMetadata
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:#}")]
        public int EID { get; set; }

        [Display(Name = "AGENCY")]
        [DisplayFormat(NullDisplayText = "NONE")]
        [StringLength(6)]
        public string AG_ID { get; set; }

        [Display(Name = "CALL TYPE")]
        [DisplayFormat(NullDisplayText = "N/A")]
        [StringLength(16)]
        public string TYCOD { get; set; }

        [Display(Name = "SUBTYPE")]
        [DisplayFormat(NullDisplayText = "NONE")]
        [StringLength(16)]
        public string SUB_TYCOD { get; set; }

        [Required]
        [Display(Name = "SENT DATE")]
        [StringLength(20)]
        public string SENT_DT { get; set; }

        [Display(Name = "EMAIL BODY")]
        [DisplayFormat(NullDisplayText = "N/A")]
        [StringLength(4000)]
        public string EMAIL_SENT { get; set; }

        [Display(Name = "EVENT NO")]
        [DisplayFormat(NullDisplayText = "N/A")]
        [StringLength(20)]
        public string NUM_1 { get; set; }
    }

    public class JC_HC_TYPESMetadata
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [Display(Name = "CALL TYPE")]
        [StringLength(16)]
        public string TYCOD { get; set; }

        [Display(Name = "SUBTYPE")]
        [DisplayFormat(NullDisplayText = "NONE")]
        public string SUB_TYCOD { get; set; }

        [Required]
        [StringLength(9)]
        public string AGENCY { get; set; }

        [Required]
        [StringLength(1)]
        public string PRIORITY { get; set; }

        [Display(Name = "COUNT LIMIT")]
        public Nullable<short> UN_CNT { get; set; }

        [Required]
        [Display(Name = "ALWAYS SEND")]
        [StringLength(1)]
        public string ALWYS_SND { get; set; }

        [Display(Name = "NEVER SEND")]
        [DisplayFormat(NullDisplayText = "F")]
        [StringLength(1)]
        public string NEVR_SND { get; set; }

        [Display(Name = "NOT FOR PUBLICATION")]
        [DisplayFormat(NullDisplayText = "F")]
        [StringLength(1)]
        public string NOT4PUB { get; set; }
    }

    public class JC_HC_USERSMetadata
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [Display(Name = "LAST NAME")]
        [StringLength(40)]
        public string LNAME { get; set; }
        
        [Required]
        [Display(Name = "FIRST NAME")]
        [StringLength(20)]
        public string FNAME { get; set; }

        [Display(Name = "AGENCY")]
        [DisplayFormat(NullDisplayText = "N/A")]
        [StringLength(6)]
        public string AG_ID { get; set; }

        [Required]
        [StringLength(75)]
        public string EMAIL { get; set; }

        [Required]
        [Display(Name = "OUT OF OFFICE")]
        [StringLength(1)]
        public string OOF { get; set; }

        [Display(Name = "LOCATION GROUP")]
        [DisplayFormat(NullDisplayText = "NONE")]
        [StringLength(50)]
        public string LOI_GRPS { get; set; }

        [DisplayFormat(DataFormatString = "{0:#}", NullDisplayText = "0")]
        public Nullable<int> ESZ { get; set; }

        [DisplayFormat(NullDisplayText = "N/A")]
        [StringLength(15)]
        public string ZIP { get; set; }

        [Required]
        [Display(Name = "OFFICER")]
        [StringLength(1)]
        public string LEO { get; set; }

        [StringLength(15)]
        public string ZIP2 { get; set; }

        [StringLength(15)]
        public string ZIP3 { get; set; }

        [StringLength(6)]
        public string RECD1 { get; set; }

        [StringLength(6)]
        public string RECD2 { get; set; }

        [StringLength(6)]
        public string RECD3 { get; set; }

        [StringLength(6)]
        public string RECD4 { get; set; }

        [StringLength(6)]
        public string RECD5 { get; set; }

        [StringLength(6)]
        public string RECD6 { get; set; }
    }

    public class JC_HC_USR_SNDMetadata
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Display(Name = "USER ID")]
        [DisplayFormat(DataFormatString = "{0:#}", NullDisplayText = "0")]
        public Nullable<int> USR_ID { get; set; }

        [DisplayFormat(DataFormatString = "{0:#}", NullDisplayText = "0")]
        public Nullable<int> ESZ { get; set; }

        [Display(Name = "AGENCY ID")]
        [DisplayFormat(DataFormatString = "{0:#}", NullDisplayText = "0")]
        public Nullable<int> AGY_ID { get; set; }

        [Display(Name = "LOCATION GROUP ID")]
        [DisplayFormat(NullDisplayText = "NONE")]
        public string GRP_ID { get; set; }

        [Display(Name = "LOCATION ID")]
        [DisplayFormat(DataFormatString = "{0:#}", NullDisplayText = "0")]
        public Nullable<int> LOI_ID { get; set; }
    }
}
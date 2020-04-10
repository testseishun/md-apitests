namespace md_api_tests.Utils.Tester.Model
{
    public class UserModel
    {
        private FirmType firmType = FirmType.IP;
        private RegistrationType registrationType = RegistrationType.Business;
        private PaymentStatus paymentStatus = PaymentStatus.Actual;
        private ReportingStatus reportingStatus = ReportingStatus.ON;
        private EmployeeMode employeeMode = EmployeeMode.ON;
        private TaxSystem taxSystem = TaxSystem.USN_6_ENVD;
        private PriceListType priceListType = PriceListType.UsnMax12Month;
        private OsnoMode osnoMode = OsnoMode.OFF;
        private string clientId = "0";
        private string login;

        public FirmType FirmType { get => firmType; set => firmType = value; }
        public RegistrationType RegistrationType { get => registrationType; set => registrationType = value; }
        public PaymentStatus PaymentStatus { get => paymentStatus; set => paymentStatus = value; }
        public ReportingStatus ReportingStatus { get => reportingStatus; set => reportingStatus = value; }
        public EmployeeMode EmployeeMode { get => employeeMode; set => employeeMode = value; }
        public TaxSystem TaxSystem { get => taxSystem; set => taxSystem = value; }
        public PriceListType PriceListType { get => priceListType; set => priceListType = value; }
        public OsnoMode OsnoMode { get => osnoMode; set => osnoMode = value; }
        public string ClientId { get => clientId; set => clientId = value; }
        public string Login { get => login; set => login = value; }

        public UserModel()
        {
            login = UserHelper.GetUserLogin();
        }

        public UserModel(RegistrationType registrationType, FirmType firmType, PriceListType priceListType, PaymentStatus paymentStatus)
        {
            this.registrationType = registrationType;
            this.firmType = firmType;
            this.priceListType = priceListType;
            this.paymentStatus = paymentStatus;
            login = UserHelper.GetUserLogin();
        }

        public bool GetOsnoMode()
        {
            switch (OsnoMode)
            {
                case OsnoMode.ON:
                    return true;
                case OsnoMode.OFF:
                    return false;
                default:
                    return false;
            }
        }

        public string GetUsnSize()
        {
            switch (TaxSystem)
            {
                case TaxSystem.USN_15:
                    return "15";
                case TaxSystem.USN_15_ENVD:
                    return "15";
                case TaxSystem.USN_6:
                    return "6";
                case TaxSystem.USN_6_ENVD:
                    return "6";
                default: return "0";
            }
        }

        public bool GetEmployeeMode()
        {
            switch (EmployeeMode)
            {
                case EmployeeMode.ON:
                    return true;
                case EmployeeMode.OFF:
                    return false;
                default: return false;
            }
        }

        public bool GetEnvd()
        {
            switch (TaxSystem)
            {
                case TaxSystem.USN_6_ENVD:
                    return true;
                case TaxSystem.USN_6:
                    return false;
                case TaxSystem.USN_15:
                    return false;
                case TaxSystem.USN_15_ENVD:
                    return true;
                case TaxSystem.ENVD:
                    return true;
                case TaxSystem.OSNO_ENVD:
                    return true;
                case TaxSystem.OSNO:
                    return false;
                case TaxSystem.OFFICE:
                    return false;
                default: return true;
            }
        }

        public bool GetUsn()
        {
            switch (TaxSystem)
            {
                case TaxSystem.USN_6_ENVD:
                    return true;
                case TaxSystem.USN_6:
                    return true;
                case TaxSystem.USN_15:
                    return true;
                case TaxSystem.USN_15_ENVD:
                    return true;
                case TaxSystem.ENVD:
                    return false;
                case TaxSystem.OSNO:
                    return false;
                case TaxSystem.OSNO_ENVD:
                    return false;
                case TaxSystem.OFFICE:
                    return false;
                default: return true;
            }
        }

        public bool GetReportingStatus()
        {
            switch (ReportingStatus)
            {
                case ReportingStatus.ON:
                    return true;
                case ReportingStatus.OFF:
                    return false;
                default: return true;
            }
        }

        public bool GetFirmType()
        {
            switch (FirmType)
            {
                case FirmType.IP:
                    return false;
                case FirmType.OOO:
                    return true;
                default: return false;
            }
        }
    }

    public enum FirmType
    {
        IP,
        OOO
    }

    public enum RegistrationType
    {
        Business,
        UsnAccountant,
        Office
    }

    public enum PaymentStatus
    {
        Actual,
        Trial,
        Expired
    }

    public enum ReportingStatus
    {
        ON,
        OFF
    }

    public enum EmployeeMode
    {
        ON,
        OFF
    }

    public enum TaxSystem
    {
        USN_6_ENVD,
        USN_6,
        USN_15,
        USN_15_ENVD,
        ENVD,
        OSNO,
        OSNO_ENVD,
        OFFICE
    }

    public enum PriceListType
    {
        UsnMax12Month,
        ProfessionalUsn,
        ProfessionalOsno,
        Office,
        OfficePro
    }

    public enum OsnoMode
    {
        ON,
        OFF
    }
}

using System.Data.Entity.Migrations;

namespace HboFactFind.EF.Migrations
{
    public partial class InitofDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BreakDownOfLiabilities",
                c => new
                {
                    Id = c.Long(false, true),
                    PageSevenId = c.Long(false),
                    MoregateLoadCreditOwner = c.String(),
                    Lender = c.String(),
                    Amount = c.String(),
                    RepaymentType = c.String(),
                    RepaymentDate = c.DateTime(false),
                    CreatedDateTime = c.DateTime(false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PageSevens", t => t.PageSevenId, true)
                .Index(t => t.PageSevenId);

            CreateTable(
                "dbo.PageSevens",
                c => new
                {
                    Id = c.Long(false, true),
                    Home = c.Decimal(false, 18, 2),
                    OtherProperty = c.Decimal(false, 18, 2),
                    CashDeposits = c.Decimal(false, 18, 2),
                    InvestmentBonds = c.Decimal(false, 18, 2),
                    PensionFunds = c.Decimal(false, 18, 2),
                    Isa = c.Decimal(false, 18, 2),
                    Collectives = c.Decimal(false, 18, 2),
                    Shares = c.Decimal(false, 18, 2),
                    BuisnessAssets = c.Decimal(false, 18, 2),
                    OtherAssets = c.Decimal(false, 18, 2),
                    TotalAssets = c.Decimal(false, 18, 2),
                    MainMortgage = c.Decimal(false, 18, 2),
                    CreditCards = c.Decimal(false, 18, 2),
                    Overdraft = c.Decimal(false, 18, 2),
                    LoansHp = c.Decimal(false, 18, 2),
                    OtherMortgage = c.Decimal(false, 18, 2),
                    OtherLending = c.Decimal(false, 18, 2),
                    TotalDebt = c.Decimal(false, 18, 2),
                    AssetsNotes = c.String(),
                    FactFindId = c.Long(false),
                    CreatedDateTime = c.DateTime(false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FactFinds", t => t.FactFindId, true)
                .Index(t => t.FactFindId);

            CreateTable(
                "dbo.FactFinds",
                c => new
                {
                    Id = c.Long(false),
                    ClientOneName = c.String(),
                    ClientTwoName = c.String(),
                    UserId = c.Long(false),
                    CompletionDateTime = c.DateTime(false),
                    PageOneClientOneId = c.Long(false),
                    PageTwoClientOneId = c.Long(false),
                    PageThreeClientOneId = c.Long(false),
                    PageFourClientOneId = c.Long(false),
                    PageFiveClientOneId = c.Long(false),
                    PageSixClientOneId = c.Long(false),
                    PageSevenClientOneId = c.Long(false),
                    PageEightClientOneId = c.Long(false),
                    PageNineClientOneId = c.Long(false),
                    PageTenClientOneId = c.Long(false),
                    CreatedDateTime = c.DateTime(false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PageEights", t => t.Id)
                .ForeignKey("dbo.PageFives", t => t.Id)
                .ForeignKey("dbo.PageFours", t => t.Id)
                .ForeignKey("dbo.PageNines", t => t.Id)
                .ForeignKey("dbo.PageOnes", t => t.Id)
                .ForeignKey("dbo.PageSevens", t => t.Id)
                .ForeignKey("dbo.PageSixes", t => t.Id)
                .ForeignKey("dbo.PageTens", t => t.Id)
                .ForeignKey("dbo.PageThrees", t => t.Id)
                .ForeignKey("dbo.PageTwoes", t => t.Id)
                .Index(t => t.Id);

            CreateTable(
                "dbo.PageEights",
                c => new
                {
                    Id = c.Long(false, true),
                    RequiredEmergancyFund = c.String(),
                    PlannedExpenditure = c.String(),
                    MadeAWill = c.Boolean(false),
                    WillNotes = c.String(),
                    FactFindId = c.Long(false),
                    CreatedDateTime = c.DateTime(false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FactFinds", t => t.FactFindId, true)
                .Index(t => t.FactFindId);

            CreateTable(
                "dbo.PageFives",
                c => new
                {
                    Id = c.Long(false, true),
                    GrossEmploymentIncome = c.Decimal(false, 18, 2),
                    GrossSelfEmploymentIncome = c.Decimal(false, 18, 2),
                    GroddPrivatePensionIncome = c.Decimal(false, 18, 2),
                    GrossStatePension = c.Decimal(false, 18, 2),
                    AdditionalIncome = c.Decimal(false, 18, 2),
                    TotalAnnualIncome = c.Decimal(false, 18, 2),
                    TotalGrossMonthlyIncome = c.Decimal(false, 18, 2),
                    TotalNetMonthlyIncome = c.Decimal(false, 18, 2),
                    TaxRate = c.Int(false),
                    AnyChangesToIncome = c.Boolean(false),
                    AnyChangesToTax = c.Boolean(false),
                    IncomeNotes = c.String(),
                    FactFindId = c.Long(false),
                    CreatedDateTime = c.DateTime(false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FactFinds", t => t.FactFindId, true)
                .Index(t => t.FactFindId);

            CreateTable(
                "dbo.PageFours",
                c => new
                {
                    Id = c.Long(false, true),
                    AnyFinancialDependants = c.Boolean(false),
                    FactFindId = c.Long(false),
                    CreatedDateTime = c.DateTime(false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FactFinds", t => t.FactFindId, true)
                .Index(t => t.FactFindId);

            CreateTable(
                "dbo.FinancialDependants",
                c => new
                {
                    Id = c.Long(false, true),
                    PageFourId = c.Long(false),
                    DependantName = c.String(),
                    DateOfBirth = c.DateTime(false),
                    DependantOn = c.String(),
                    AgeOfIndependance = c.String(),
                    RelationshipAndReason = c.String(),
                    CreatedDateTime = c.DateTime(false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PageFours", t => t.PageFourId, true)
                .Index(t => t.PageFourId);

            CreateTable(
                "dbo.NonFinancialDependants",
                c => new
                {
                    Id = c.Long(false, true),
                    PageFourId = c.Long(false),
                    Name = c.String(),
                    DateOfBirth = c.DateTime(false),
                    Relationship = c.String(),
                    Notes = c.String(),
                    CreatedDateTime = c.DateTime(false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PageFours", t => t.PageFourId, true)
                .Index(t => t.PageFourId);

            CreateTable(
                "dbo.PageNines",
                c => new
                {
                    Id = c.Long(false, true),
                    PersonalProtectionPriority = c.Int(false),
                    PensionPlanningPriority = c.Int(false),
                    OptionsAtRetirementPriority = c.Int(false),
                    SavingsAndInvestmentsPriority = c.Int(false),
                    EstatePlanningPriority = c.Int(false),
                    MortgageNeedsPriority = c.Int(false),
                    EquityReleasePriority = c.Int(false),
                    LongTermCarePriority = c.Int(false),
                    GeneralInsuranceNeedsPriority = c.Int(false),
                    PrioritiesNotes = c.String(),
                    FactFindId = c.Long(false),
                    CreatedDateTime = c.DateTime(false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FactFinds", t => t.FactFindId, true)
                .Index(t => t.FactFindId);

            CreateTable(
                "dbo.PageOnes",
                c => new
                {
                    Id = c.Long(false, true),
                    Title = c.Int(false),
                    Forename = c.String(),
                    Surnames = c.String(),
                    AddressLineOne = c.String(),
                    AddressLineTwo = c.String(),
                    AddressLineThree = c.String(),
                    County = c.String(),
                    PostCode = c.String(),
                    EmailAddress = c.String(),
                    HomeTelephone = c.String(),
                    MobileTelephone = c.String(),
                    DateOfBirth = c.DateTime(false),
                    Sex = c.Int(false),
                    MartialStatus = c.Int(false),
                    GoodHealth = c.Boolean(false),
                    Smoked = c.Boolean(false),
                    NationalInsuranceNumber = c.String(),
                    Nationality = c.String(),
                    CountryOfBirth = c.String(),
                    CountryOfResidence = c.String(),
                    Domicile = c.String(),
                    TaxationResidency = c.String(),
                    ExtraInformation = c.String(),
                    FactFindId = c.Long(false),
                    CreatedDateTime = c.DateTime(false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FactFinds", t => t.FactFindId, true)
                .Index(t => t.FactFindId);

            CreateTable(
                "dbo.PageSixes",
                c => new
                {
                    Id = c.Long(false, true),
                    MortageRent = c.Decimal(false, 18, 2),
                    CouncilTax = c.Decimal(false, 18, 2),
                    Utilities = c.Decimal(false, 18, 2),
                    FoodShopping = c.Decimal(false, 18, 2),
                    TvSateliteCableInternet = c.Decimal(false, 18, 2),
                    Phone = c.Decimal(false, 18, 2),
                    Transportation = c.Decimal(false, 18, 2),
                    Financials = c.Decimal(false, 18, 2),
                    LoansCreditStoreCardRepayments = c.Decimal(false, 18, 2),
                    Savings = c.Decimal(false, 18, 2),
                    Insurance = c.Decimal(false, 18, 2),
                    PensionContributions = c.Decimal(false, 18, 2),
                    Miscellaneious = c.Decimal(false, 18, 2),
                    Holidays = c.Decimal(false, 18, 2),
                    RegularSubscriptions = c.Decimal(false, 18, 2),
                    Clothing = c.Decimal(false, 18, 2),
                    Other = c.Decimal(false, 18, 2),
                    TotalOutgoings = c.Decimal(false, 18, 2),
                    SurplusIncome = c.Decimal(false, 18, 2),
                    FinancialGoalCommitment = c.Decimal(false, 18, 2),
                    OutGoingsNotes = c.String(),
                    FactFindId = c.Long(false),
                    CreatedDateTime = c.DateTime(false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FactFinds", t => t.FactFindId, true)
                .Index(t => t.FactFindId);

            CreateTable(
                "dbo.PageTens",
                c => new
                {
                    Id = c.Long(false, true),
                    ExistingPlansNotes = c.String(),
                    FactFindId = c.Long(false),
                    CreatedDateTime = c.DateTime(false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FactFinds", t => t.FactFindId, true)
                .Index(t => t.FactFindId);

            CreateTable(
                "dbo.PensionPolicies",
                c => new
                {
                    Id = c.Long(false, true),
                    Contribution = c.Decimal(false, 18, 2),
                    Frequency = c.String(),
                    Pci = c.Boolean(false),
                    AdditionalLifeCover = c.Decimal(false, 18, 2),
                    LastValuation = c.Decimal(false, 18, 2),
                    PageTenId = c.Long(false),
                    Owner = c.String(),
                    Provider = c.String(),
                    PolicyNumber = c.String(),
                    ProductPlanType = c.String(),
                    InForce = c.Boolean(false),
                    CreatedDateTime = c.DateTime(false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PageTens", t => t.PageTenId, true)
                .Index(t => t.PageTenId);

            CreateTable(
                "dbo.ProtectionAndInsurancePolicies",
                c => new
                {
                    Id = c.Long(false, true),
                    GrossPremium = c.Decimal(false, 18, 2),
                    PremiumFrequency = c.String(),
                    Waiver = c.Boolean(false),
                    InTrust = c.Boolean(false),
                    Term = c.String(),
                    LifeCover = c.Decimal(false, 18, 2),
                    CICCover = c.Decimal(false, 18, 2),
                    PageTenId = c.Long(false),
                    Owner = c.String(),
                    Provider = c.String(),
                    PolicyNumber = c.String(),
                    ProductPlanType = c.String(),
                    InForce = c.Boolean(false),
                    CreatedDateTime = c.DateTime(false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PageTens", t => t.PageTenId, true)
                .Index(t => t.PageTenId);

            CreateTable(
                "dbo.SavingsAndInvestmentPolicies",
                c => new
                {
                    Id = c.Long(false, true),
                    Contrbution = c.Decimal(false, 18, 2),
                    Frequency = c.String(),
                    InTrust = c.Boolean(false),
                    LastValuation = c.Decimal(false, 18, 2),
                    PageTenId = c.Long(false),
                    Owner = c.String(),
                    Provider = c.String(),
                    PolicyNumber = c.String(),
                    ProductPlanType = c.String(),
                    InForce = c.Boolean(false),
                    CreatedDateTime = c.DateTime(false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PageTens", t => t.PageTenId, true)
                .Index(t => t.PageTenId);

            CreateTable(
                "dbo.PageThrees",
                c => new
                {
                    Id = c.Long(false, true),
                    Solicitor = c.String(),
                    Accountant = c.String(),
                    AdviserOther = c.String(),
                    FactFindId = c.Long(false),
                    CreatedDateTime = c.DateTime(false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FactFinds", t => t.FactFindId, true)
                .Index(t => t.FactFindId);

            CreateTable(
                "dbo.PageTwoes",
                c => new
                {
                    Id = c.Long(false, true),
                    EmploymentStatus = c.Int(false),
                    Occupation = c.String(),
                    DetailsOfEmployer = c.String(),
                    EmploymentStartDate = c.DateTime(false),
                    IntendedRetirementAge = c.Int(false),
                    FactFindId = c.Long(false),
                    CreatedDateTime = c.DateTime(false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FactFinds", t => t.FactFindId, true)
                .Index(t => t.FactFindId);

            CreateTable(
                "dbo.Users",
                c => new
                {
                    Id = c.Long(false, true),
                    FirstName = c.String(false),
                    SecondName = c.String(false),
                    EmailAddress = c.String(false),
                    PasswordHash = c.String(),
                    PasswordSalt = c.String(),
                    SessionToken = c.String(),
                    IsAdmin = c.Boolean(false),
                    LastLoggedIn = c.DateTime(false),
                    CreatedDateTime = c.DateTime(false),
                })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropForeignKey("dbo.BreakDownOfLiabilities", "PageSevenId", "dbo.PageSevens");
            DropForeignKey("dbo.PageSevens", "FactFindId", "dbo.FactFinds");
            DropForeignKey("dbo.FactFinds", "Id", "dbo.PageTwoes");
            DropForeignKey("dbo.PageTwoes", "FactFindId", "dbo.FactFinds");
            DropForeignKey("dbo.FactFinds", "Id", "dbo.PageThrees");
            DropForeignKey("dbo.PageThrees", "FactFindId", "dbo.FactFinds");
            DropForeignKey("dbo.FactFinds", "Id", "dbo.PageTens");
            DropForeignKey("dbo.SavingsAndInvestmentPolicies", "PageTenId", "dbo.PageTens");
            DropForeignKey("dbo.ProtectionAndInsurancePolicies", "PageTenId", "dbo.PageTens");
            DropForeignKey("dbo.PensionPolicies", "PageTenId", "dbo.PageTens");
            DropForeignKey("dbo.PageTens", "FactFindId", "dbo.FactFinds");
            DropForeignKey("dbo.FactFinds", "Id", "dbo.PageSixes");
            DropForeignKey("dbo.PageSixes", "FactFindId", "dbo.FactFinds");
            DropForeignKey("dbo.FactFinds", "Id", "dbo.PageSevens");
            DropForeignKey("dbo.FactFinds", "Id", "dbo.PageOnes");
            DropForeignKey("dbo.PageOnes", "FactFindId", "dbo.FactFinds");
            DropForeignKey("dbo.FactFinds", "Id", "dbo.PageNines");
            DropForeignKey("dbo.PageNines", "FactFindId", "dbo.FactFinds");
            DropForeignKey("dbo.FactFinds", "Id", "dbo.PageFours");
            DropForeignKey("dbo.NonFinancialDependants", "PageFourId", "dbo.PageFours");
            DropForeignKey("dbo.FinancialDependants", "PageFourId", "dbo.PageFours");
            DropForeignKey("dbo.PageFours", "FactFindId", "dbo.FactFinds");
            DropForeignKey("dbo.FactFinds", "Id", "dbo.PageFives");
            DropForeignKey("dbo.PageFives", "FactFindId", "dbo.FactFinds");
            DropForeignKey("dbo.FactFinds", "Id", "dbo.PageEights");
            DropForeignKey("dbo.PageEights", "FactFindId", "dbo.FactFinds");
            DropIndex("dbo.PageTwoes", new[] {"FactFindId"});
            DropIndex("dbo.PageThrees", new[] {"FactFindId"});
            DropIndex("dbo.SavingsAndInvestmentPolicies", new[] {"PageTenId"});
            DropIndex("dbo.ProtectionAndInsurancePolicies", new[] {"PageTenId"});
            DropIndex("dbo.PensionPolicies", new[] {"PageTenId"});
            DropIndex("dbo.PageTens", new[] {"FactFindId"});
            DropIndex("dbo.PageSixes", new[] {"FactFindId"});
            DropIndex("dbo.PageOnes", new[] {"FactFindId"});
            DropIndex("dbo.PageNines", new[] {"FactFindId"});
            DropIndex("dbo.NonFinancialDependants", new[] {"PageFourId"});
            DropIndex("dbo.FinancialDependants", new[] {"PageFourId"});
            DropIndex("dbo.PageFours", new[] {"FactFindId"});
            DropIndex("dbo.PageFives", new[] {"FactFindId"});
            DropIndex("dbo.PageEights", new[] {"FactFindId"});
            DropIndex("dbo.FactFinds", new[] {"Id"});
            DropIndex("dbo.PageSevens", new[] {"FactFindId"});
            DropIndex("dbo.BreakDownOfLiabilities", new[] {"PageSevenId"});
            DropTable("dbo.Users");
            DropTable("dbo.PageTwoes");
            DropTable("dbo.PageThrees");
            DropTable("dbo.SavingsAndInvestmentPolicies");
            DropTable("dbo.ProtectionAndInsurancePolicies");
            DropTable("dbo.PensionPolicies");
            DropTable("dbo.PageTens");
            DropTable("dbo.PageSixes");
            DropTable("dbo.PageOnes");
            DropTable("dbo.PageNines");
            DropTable("dbo.NonFinancialDependants");
            DropTable("dbo.FinancialDependants");
            DropTable("dbo.PageFours");
            DropTable("dbo.PageFives");
            DropTable("dbo.PageEights");
            DropTable("dbo.FactFinds");
            DropTable("dbo.PageSevens");
            DropTable("dbo.BreakDownOfLiabilities");
        }
    }
}
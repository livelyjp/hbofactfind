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
                    ClientOneHome = c.Decimal(false, 18, 2),
                    ClientOneOtherProperty = c.Decimal(false, 18, 2),
                    ClientOneCashDeposits = c.Decimal(false, 18, 2),
                    ClientOneInvestmentBonds = c.Decimal(false, 18, 2),
                    ClientOnePensionFunds = c.Decimal(false, 18, 2),
                    ClientOneIsa = c.Decimal(false, 18, 2),
                    ClientOneCollectives = c.Decimal(false, 18, 2),
                    ClientOneShares = c.Decimal(false, 18, 2),
                    ClientOneBuisnessAssets = c.Decimal(false, 18, 2),
                    ClientOneOtherAssets = c.Decimal(false, 18, 2),
                    ClientOneTotalAssets = c.Decimal(false, 18, 2),
                    ClientOneMainMortgage = c.Decimal(false, 18, 2),
                    ClientOneCreditCards = c.Decimal(false, 18, 2),
                    ClientOneOverdraft = c.Decimal(false, 18, 2),
                    ClientOneLoansHp = c.Decimal(false, 18, 2),
                    ClientOneOtherMortgage = c.Decimal(false, 18, 2),
                    ClientOneOtherLending = c.Decimal(false, 18, 2),
                    ClientOneTotalDebt = c.Decimal(false, 18, 2),
                    ClientTwoHome = c.Decimal(false, 18, 2),
                    ClientTwoOtherProperty = c.Decimal(false, 18, 2),
                    ClientTwoCashDeposits = c.Decimal(false, 18, 2),
                    ClientTwoInvestmentBonds = c.Decimal(false, 18, 2),
                    ClientTwoPensionFunds = c.Decimal(false, 18, 2),
                    ClientTwoIsa = c.Decimal(false, 18, 2),
                    ClientTwoCollectives = c.Decimal(false, 18, 2),
                    ClientTwoShares = c.Decimal(false, 18, 2),
                    ClientTwoBuisnessAssets = c.Decimal(false, 18, 2),
                    ClientTwoOtherAssets = c.Decimal(false, 18, 2),
                    ClientTwoTotalAssets = c.Decimal(false, 18, 2),
                    ClientTwoMainMortgage = c.Decimal(false, 18, 2),
                    ClientTwoCreditCards = c.Decimal(false, 18, 2),
                    ClientTwoOverdraft = c.Decimal(false, 18, 2),
                    ClientTwoLoansHp = c.Decimal(false, 18, 2),
                    ClientTwoOtherMortgage = c.Decimal(false, 18, 2),
                    ClientTwoOtherLending = c.Decimal(false, 18, 2),
                    ClientTwoTotalDebt = c.Decimal(false, 18, 2),
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
                    ClientOneRequiredEmergancyFund = c.String(),
                    ClientOnePlannedExpenditure = c.String(),
                    ClientOneMadeAWill = c.Boolean(false),
                    ClientOneWillNotes = c.String(),
                    ClientTwoRequiredEmergancyFund = c.String(),
                    ClientTwoPlannedExpenditure = c.String(),
                    ClientTwoMadeAWill = c.Boolean(false),
                    ClientTwoWillNotes = c.String(),
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
                    ClientOneGrossEmploymentIncome = c.Decimal(false, 18, 2),
                    ClientOneGrossSelfEmploymentIncome = c.Decimal(false, 18, 2),
                    ClientOneGroddPrivatePensionIncome = c.Decimal(false, 18, 2),
                    ClientOneGrossStatePension = c.Decimal(false, 18, 2),
                    ClientOneAdditionalIncome = c.Decimal(false, 18, 2),
                    ClientOneTotalAnnualIncome = c.Decimal(false, 18, 2),
                    ClientOneTotalGrossMonthlyIncome = c.Decimal(false, 18, 2),
                    ClientOneTotalNetMonthlyIncome = c.Decimal(false, 18, 2),
                    ClientOneTaxRate = c.Int(false),
                    ClientOneAnyChangesToIncome = c.Boolean(false),
                    ClientOneAnyChangesToTax = c.Boolean(false),
                    ClientOneIncomeNotes = c.String(),
                    ClientTwoGrossEmploymentIncome = c.Decimal(false, 18, 2),
                    ClientTwoGrossSelfEmploymentIncome = c.Decimal(false, 18, 2),
                    ClientTwoGroddPrivatePensionIncome = c.Decimal(false, 18, 2),
                    ClientTwoGrossStatePension = c.Decimal(false, 18, 2),
                    ClientTwoAdditionalIncome = c.Decimal(false, 18, 2),
                    ClientTwoTotalAnnualIncome = c.Decimal(false, 18, 2),
                    ClientTwoTotalGrossMonthlyIncome = c.Decimal(false, 18, 2),
                    ClientTwoTotalNetMonthlyIncome = c.Decimal(false, 18, 2),
                    ClientTwoTaxRate = c.Int(false),
                    ClientTwoAnyChangesToIncome = c.Boolean(false),
                    ClientTwoAnyChangesToTax = c.Boolean(false),
                    ClientTwoIncomeNotes = c.String(),
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
                    ClientOnePersonalProtectionPriority = c.Int(false),
                    ClientOnePensionPlanningPriority = c.Int(false),
                    ClientOneOptionsAtRetirementPriority = c.Int(false),
                    ClientOneSavingsAndInvestmentsPriority = c.Int(false),
                    ClientOneEstatePlanningPriority = c.Int(false),
                    ClientOneMortgageNeedsPriority = c.Int(false),
                    ClientOneEquityReleasePriority = c.Int(false),
                    ClientOneLongTermCarePriority = c.Int(false),
                    ClientOneGeneralInsuranceNeedsPriority = c.Int(false),
                    ClientOnePrioritiesNotes = c.String(),
                    ClientTwoPersonalProtectionPriority = c.Int(false),
                    ClientTwoPensionPlanningPriority = c.Int(false),
                    ClientTwoOptionsAtRetirementPriority = c.Int(false),
                    ClientTwoSavingsAndInvestmentsPriority = c.Int(false),
                    ClientTwoEstatePlanningPriority = c.Int(false),
                    ClientTwoMortgageNeedsPriority = c.Int(false),
                    ClientTwoEquityReleasePriority = c.Int(false),
                    ClientTwoLongTermCarePriority = c.Int(false),
                    ClientTwoGeneralInsuranceNeedsPriority = c.Int(false),
                    ClientTwoPrioritiesNotes = c.String(),
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
                    ClientOneTitle = c.Int(false),
                    ClientOneForename = c.String(),
                    ClientOneSurnames = c.String(),
                    ClientOneAddressLineOne = c.String(),
                    ClientOneAddressLineTwo = c.String(),
                    ClientOneAddressLineThree = c.String(),
                    ClientOneCounty = c.String(),
                    ClientOnePostCode = c.String(),
                    ClientOneEmailAddress = c.String(),
                    ClientOneHomeTelephone = c.String(),
                    ClientOneMobileTelephone = c.String(),
                    ClientOneDateOfBirth = c.DateTime(false),
                    ClientOneSex = c.Int(false),
                    ClientOneMartialStatus = c.Int(false),
                    ClientOneGoodHealth = c.Boolean(false),
                    ClientOneSmoked = c.Boolean(false),
                    ClientOneNationalInsuranceNumber = c.String(),
                    ClientOneNationality = c.String(),
                    ClientOneCountryOfBirth = c.String(),
                    ClientOneCountryOfResidence = c.String(),
                    ClientOneDomicile = c.String(),
                    ClientOneTaxationResidency = c.String(),
                    ClientOneExtraInformation = c.String(),
                    ClientTwoTitle = c.Int(false),
                    ClientTwoForename = c.String(),
                    ClientTwoSurnames = c.String(),
                    ClientTwoAddressLineOne = c.String(),
                    ClientTwoAddressLineTwo = c.String(),
                    ClientTwoAddressLineThree = c.String(),
                    ClientTwoCounty = c.String(),
                    ClientTwoPostCode = c.String(),
                    ClientTwoEmailAddress = c.String(),
                    ClientTwoHomeTelephone = c.String(),
                    ClientTwoMobileTelephone = c.String(),
                    ClientTwoDateOfBirth = c.DateTime(false),
                    ClientTwoSex = c.Int(false),
                    ClientTwoMartialStatus = c.Int(false),
                    ClientTwoGoodHealth = c.Boolean(false),
                    ClientTwoSmoked = c.Boolean(false),
                    ClientTwoNationalInsuranceNumber = c.String(),
                    ClientTwoNationality = c.String(),
                    ClientTwoCountryOfBirth = c.String(),
                    ClientTwoCountryOfResidence = c.String(),
                    ClientTwoDomicile = c.String(),
                    ClientTwoTaxationResidency = c.String(),
                    ClientTwoExtraInformation = c.String(),
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
                    ClientOneMortageRent = c.Decimal(false, 18, 2),
                    ClientOneCouncilTax = c.Decimal(false, 18, 2),
                    ClientOneUtilities = c.Decimal(false, 18, 2),
                    ClientOneFoodShopping = c.Decimal(false, 18, 2),
                    ClientOneTvSateliteCableInternet = c.Decimal(false, 18, 2),
                    ClientOnePhone = c.Decimal(false, 18, 2),
                    ClientOneTransportation = c.Decimal(false, 18, 2),
                    ClientOneFinancials = c.Decimal(false, 18, 2),
                    ClientOneLoansCreditStoreCardRepayments = c.Decimal(false, 18, 2),
                    ClientOneSavings = c.Decimal(false, 18, 2),
                    ClientOneInsurance = c.Decimal(false, 18, 2),
                    ClientOnePensionContributions = c.Decimal(false, 18, 2),
                    ClientOneMiscellaneious = c.Decimal(false, 18, 2),
                    ClientOneHolidays = c.Decimal(false, 18, 2),
                    ClientOneRegularSubscriptions = c.Decimal(false, 18, 2),
                    ClientOneClothing = c.Decimal(false, 18, 2),
                    ClientOneOther = c.Decimal(false, 18, 2),
                    ClientOneTotalOutgoings = c.Decimal(false, 18, 2),
                    ClientOneSurplusIncome = c.Decimal(false, 18, 2),
                    ClientOneFinancialGoalCommitment = c.Decimal(false, 18, 2),
                    ClientTwoMortageRent = c.Decimal(false, 18, 2),
                    ClientTwoCouncilTax = c.Decimal(false, 18, 2),
                    ClientTwoUtilities = c.Decimal(false, 18, 2),
                    ClientTwoFoodShopping = c.Decimal(false, 18, 2),
                    ClientTwoTvSateliteCableInternet = c.Decimal(false, 18, 2),
                    ClientTwoPhone = c.Decimal(false, 18, 2),
                    ClientTwoTransportation = c.Decimal(false, 18, 2),
                    ClientTwoFinancials = c.Decimal(false, 18, 2),
                    ClientTwoLoansCreditStoreCardRepayments = c.Decimal(false, 18, 2),
                    ClientTwoSavings = c.Decimal(false, 18, 2),
                    ClientTwoInsurance = c.Decimal(false, 18, 2),
                    ClientTwoPensionContributions = c.Decimal(false, 18, 2),
                    ClientTwoMiscellaneious = c.Decimal(false, 18, 2),
                    ClientTwoHolidays = c.Decimal(false, 18, 2),
                    ClientTwoRegularSubscriptions = c.Decimal(false, 18, 2),
                    ClientTwoClothing = c.Decimal(false, 18, 2),
                    ClientTwoOther = c.Decimal(false, 18, 2),
                    ClientTwoTotalOutgoings = c.Decimal(false, 18, 2),
                    ClientTwoSurplusIncome = c.Decimal(false, 18, 2),
                    ClientTwoFinancialGoalCommitment = c.Decimal(false, 18, 2),
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
                    ClientOneSolicitor = c.String(),
                    ClientOneAccountant = c.String(),
                    ClientOneAdviserOther = c.String(),
                    ClientTwoSolicitor = c.String(),
                    ClientTwoAccountant = c.String(),
                    ClientTwoAdviserOther = c.String(),
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
                    ClientOneEmploymentStatus = c.Int(false),
                    ClientOneOccupation = c.String(),
                    ClientOneDetailsOfEmployer = c.String(),
                    ClientOneEmploymentStartDate = c.DateTime(false),
                    ClientOneIntendedRetirementAge = c.Int(false),
                    ClientTwoStatusEmploymentStatus = c.Int(false),
                    ClientTwoOccupation = c.String(),
                    ClientTwoDetailsOfEmployer = c.String(),
                    ClientTwoEmploymentStartDate = c.DateTime(false),
                    ClientTwoIntendedRetirementAge = c.Int(false),
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
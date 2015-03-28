namespace HboFactFind.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitofDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BreakDownOfLiabilities",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        PageSevenId = c.Long(nullable: false),
                        MoregateLoadCreditOwner = c.String(),
                        Lender = c.String(),
                        Amount = c.String(),
                        RepaymentType = c.String(),
                        RepaymentDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        CreatedDateTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PageSevens", t => t.PageSevenId, cascadeDelete: true)
                .Index(t => t.PageSevenId);
            
            CreateTable(
                "dbo.PageSevens",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ClientOneHome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneOtherProperty = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneCashDeposits = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneInvestmentBonds = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOnePensionFunds = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneIsa = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneCollectives = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneShares = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneBuisnessAssets = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneOtherAssets = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneTotalAssets = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneMainMortgage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneCreditCards = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneOverdraft = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneLoansHp = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneOtherMortgage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneOtherLending = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneTotalDebt = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoHome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoOtherProperty = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoCashDeposits = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoInvestmentBonds = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoPensionFunds = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoIsa = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoCollectives = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoShares = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoBuisnessAssets = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoOtherAssets = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoTotalAssets = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoMainMortgage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoCreditCards = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoOverdraft = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoLoansHp = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoOtherMortgage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoOtherLending = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoTotalDebt = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AssetsNotes = c.String(),
                        CreatedDateTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FactFinds",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ClientOneName = c.String(),
                        ClientTwoName = c.String(),
                        UserId = c.Long(nullable: false),
                        CompletionDateTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        PageOneId = c.Long(nullable: false),
                        PageTwoId = c.Long(nullable: false),
                        PageThreeId = c.Long(nullable: false),
                        PageFourId = c.Long(nullable: false),
                        PageFiveId = c.Long(nullable: false),
                        PageSixId = c.Long(nullable: false),
                        PageSevenId = c.Long(nullable: false),
                        PageEightId = c.Long(nullable: false),
                        PageNineId = c.Long(nullable: false),
                        PageTenId = c.Long(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PageEights", t => t.PageEightId)
                .ForeignKey("dbo.PageFives", t => t.PageFiveId)
                .ForeignKey("dbo.PageFours", t => t.PageFourId)
                .ForeignKey("dbo.PageNines", t => t.PageNineId)
                .ForeignKey("dbo.PageOnes", t => t.PageOneId)
                .ForeignKey("dbo.PageSevens", t => t.PageSevenId)
                .ForeignKey("dbo.PageSixes", t => t.PageSixId)
                .ForeignKey("dbo.PageTens", t => t.PageTenId)
                .ForeignKey("dbo.PageThrees", t => t.PageThreeId)
                .ForeignKey("dbo.PageTwoes", t => t.PageTwoId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.PageOneId)
                .Index(t => t.PageTwoId)
                .Index(t => t.PageThreeId)
                .Index(t => t.PageFourId)
                .Index(t => t.PageFiveId)
                .Index(t => t.PageSixId)
                .Index(t => t.PageSevenId)
                .Index(t => t.PageEightId)
                .Index(t => t.PageNineId)
                .Index(t => t.PageTenId);
            
            CreateTable(
                "dbo.PageEights",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ClientOneRequiredEmergancyFund = c.String(),
                        ClientOnePlannedExpenditure = c.String(),
                        ClientOneMadeAWill = c.Boolean(nullable: false),
                        ClientOneWillNotes = c.String(),
                        ClientTwoRequiredEmergancyFund = c.String(),
                        ClientTwoPlannedExpenditure = c.String(),
                        ClientTwoMadeAWill = c.Boolean(nullable: false),
                        ClientTwoWillNotes = c.String(),
                        CreatedDateTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PageFives",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ClientOneGrossEmploymentIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneGrossSelfEmploymentIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneGroddPrivatePensionIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneGrossStatePension = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneAdditionalIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneTotalAnnualIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneTotalGrossMonthlyIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneTotalNetMonthlyIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneTaxRate = c.Int(nullable: false),
                        ClientOneAnyChangesToIncome = c.Boolean(nullable: false),
                        ClientOneAnyChangesToTax = c.Boolean(nullable: false),
                        ClientOneIncomeNotes = c.String(),
                        ClientTwoGrossEmploymentIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoGrossSelfEmploymentIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoGroddPrivatePensionIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoGrossStatePension = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoAdditionalIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoTotalAnnualIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoTotalGrossMonthlyIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoTotalNetMonthlyIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoTaxRate = c.Int(nullable: false),
                        ClientTwoAnyChangesToIncome = c.Boolean(nullable: false),
                        ClientTwoAnyChangesToTax = c.Boolean(nullable: false),
                        ClientTwoIncomeNotes = c.String(),
                        CreatedDateTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PageFours",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        AnyFinancialDependants = c.Boolean(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FinancialDependants",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        PageFourId = c.Long(nullable: false),
                        DependantName = c.String(),
                        DateOfBirth = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        DependantOn = c.String(),
                        AgeOfIndependance = c.String(),
                        RelationshipAndReason = c.String(),
                        CreatedDateTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PageFours", t => t.PageFourId, cascadeDelete: true)
                .Index(t => t.PageFourId);
            
            CreateTable(
                "dbo.NonFinancialDependants",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        PageFourId = c.Long(nullable: false),
                        Name = c.String(),
                        DateOfBirth = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Relationship = c.String(),
                        Notes = c.String(),
                        CreatedDateTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PageFours", t => t.PageFourId, cascadeDelete: true)
                .Index(t => t.PageFourId);
            
            CreateTable(
                "dbo.PageNines",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ClientOnePersonalProtectionPriority = c.Int(nullable: false),
                        ClientOnePensionPlanningPriority = c.Int(nullable: false),
                        ClientOneOptionsAtRetirementPriority = c.Int(nullable: false),
                        ClientOneSavingsAndInvestmentsPriority = c.Int(nullable: false),
                        ClientOneEstatePlanningPriority = c.Int(nullable: false),
                        ClientOneMortgageNeedsPriority = c.Int(nullable: false),
                        ClientOneEquityReleasePriority = c.Int(nullable: false),
                        ClientOneLongTermCarePriority = c.Int(nullable: false),
                        ClientOneGeneralInsuranceNeedsPriority = c.Int(nullable: false),
                        ClientOnePrioritiesNotes = c.String(),
                        ClientTwoPersonalProtectionPriority = c.Int(nullable: false),
                        ClientTwoPensionPlanningPriority = c.Int(nullable: false),
                        ClientTwoOptionsAtRetirementPriority = c.Int(nullable: false),
                        ClientTwoSavingsAndInvestmentsPriority = c.Int(nullable: false),
                        ClientTwoEstatePlanningPriority = c.Int(nullable: false),
                        ClientTwoMortgageNeedsPriority = c.Int(nullable: false),
                        ClientTwoEquityReleasePriority = c.Int(nullable: false),
                        ClientTwoLongTermCarePriority = c.Int(nullable: false),
                        ClientTwoGeneralInsuranceNeedsPriority = c.Int(nullable: false),
                        ClientTwoPrioritiesNotes = c.String(),
                        CreatedDateTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PageOnes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ClientOneTitle = c.Int(nullable: false),
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
                        ClientOneDateOfBirth = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        ClientOneSex = c.Int(nullable: false),
                        ClientOneMartialStatus = c.Int(nullable: false),
                        ClientOneGoodHealth = c.Boolean(nullable: false),
                        ClientOneSmoked = c.Boolean(nullable: false),
                        ClientOneNationalInsuranceNumber = c.String(),
                        ClientOneNationality = c.String(),
                        ClientOneCountryOfBirth = c.String(),
                        ClientOneCountryOfResidence = c.String(),
                        ClientOneDomicile = c.String(),
                        ClientOneTaxationResidency = c.String(),
                        ClientOneExtraInformation = c.String(),
                        ClientTwoTitle = c.Int(nullable: false),
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
                        ClientTwoDateOfBirth = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        ClientTwoSex = c.Int(nullable: false),
                        ClientTwoMartialStatus = c.Int(nullable: false),
                        ClientTwoGoodHealth = c.Boolean(nullable: false),
                        ClientTwoSmoked = c.Boolean(nullable: false),
                        ClientTwoNationalInsuranceNumber = c.String(),
                        ClientTwoNationality = c.String(),
                        ClientTwoCountryOfBirth = c.String(),
                        ClientTwoCountryOfResidence = c.String(),
                        ClientTwoDomicile = c.String(),
                        ClientTwoTaxationResidency = c.String(),
                        ClientTwoExtraInformation = c.String(),
                        CreatedDateTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PageSixes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ClientOneMortageRent = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneCouncilTax = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneUtilities = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneFoodShopping = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneTvSateliteCableInternet = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOnePhone = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneTransportation = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneFinancials = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneLoansCreditStoreCardRepayments = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneSavings = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneInsurance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOnePensionContributions = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneMiscellaneious = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneHolidays = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneRegularSubscriptions = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneClothing = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneOther = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneTotalOutgoings = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneSurplusIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientOneFinancialGoalCommitment = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoMortageRent = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoCouncilTax = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoUtilities = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoFoodShopping = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoTvSateliteCableInternet = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoPhone = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoTransportation = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoFinancials = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoLoansCreditStoreCardRepayments = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoSavings = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoInsurance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoPensionContributions = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoMiscellaneious = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoHolidays = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoRegularSubscriptions = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoClothing = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoOther = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoTotalOutgoings = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoSurplusIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientTwoFinancialGoalCommitment = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OutGoingsNotes = c.String(),
                        CreatedDateTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PageTens",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ExistingPlansNotes = c.String(),
                        CreatedDateTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PensionPolicies",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Contribution = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Frequency = c.String(),
                        Pci = c.Boolean(nullable: false),
                        AdditionalLifeCover = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LastValuation = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PageTenId = c.Long(nullable: false),
                        Owner = c.String(),
                        Provider = c.String(),
                        PolicyNumber = c.String(),
                        ProductPlanType = c.String(),
                        InForce = c.Boolean(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PageTens", t => t.PageTenId, cascadeDelete: true)
                .Index(t => t.PageTenId);
            
            CreateTable(
                "dbo.ProtectionAndInsurancePolicies",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        GrossPremium = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PremiumFrequency = c.String(),
                        Waiver = c.Boolean(nullable: false),
                        InTrust = c.Boolean(nullable: false),
                        Term = c.String(),
                        LifeCover = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CICCover = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PageTenId = c.Long(nullable: false),
                        Owner = c.String(),
                        Provider = c.String(),
                        PolicyNumber = c.String(),
                        ProductPlanType = c.String(),
                        InForce = c.Boolean(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PageTens", t => t.PageTenId, cascadeDelete: true)
                .Index(t => t.PageTenId);
            
            CreateTable(
                "dbo.SavingsAndInvestmentPolicies",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Contrbution = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Frequency = c.String(),
                        InTrust = c.Boolean(nullable: false),
                        LastValuation = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PageTenId = c.Long(nullable: false),
                        Owner = c.String(),
                        Provider = c.String(),
                        PolicyNumber = c.String(),
                        ProductPlanType = c.String(),
                        InForce = c.Boolean(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PageTens", t => t.PageTenId, cascadeDelete: true)
                .Index(t => t.PageTenId);
            
            CreateTable(
                "dbo.PageThrees",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ClientOneSolicitor = c.String(),
                        ClientOneAccountant = c.String(),
                        ClientOneAdviserOther = c.String(),
                        ClientTwoSolicitor = c.String(),
                        ClientTwoAccountant = c.String(),
                        ClientTwoAdviserOther = c.String(),
                        CreatedDateTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PageTwoes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ClientOneEmploymentStatus = c.Int(nullable: false),
                        ClientOneOccupation = c.String(),
                        ClientOneDetailsOfEmployer = c.String(),
                        ClientOneEmploymentStartDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        ClientOneIntendedRetirementAge = c.Int(nullable: false),
                        ClientTwoStatusEmploymentStatus = c.Int(nullable: false),
                        ClientTwoOccupation = c.String(),
                        ClientTwoDetailsOfEmployer = c.String(),
                        ClientTwoEmploymentStartDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        ClientTwoIntendedRetirementAge = c.Int(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        SecondName = c.String(nullable: false),
                        EmailAddress = c.String(nullable: false),
                        PasswordHash = c.String(),
                        PasswordSalt = c.String(),
                        IsAdmin = c.Boolean(nullable: false),
                        LastLoggedIn = c.DateTime(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FactFinds", "UserId", "dbo.Users");
            DropForeignKey("dbo.FactFinds", "PageTwoId", "dbo.PageTwoes");
            DropForeignKey("dbo.FactFinds", "PageThreeId", "dbo.PageThrees");
            DropForeignKey("dbo.FactFinds", "PageTenId", "dbo.PageTens");
            DropForeignKey("dbo.SavingsAndInvestmentPolicies", "PageTenId", "dbo.PageTens");
            DropForeignKey("dbo.ProtectionAndInsurancePolicies", "PageTenId", "dbo.PageTens");
            DropForeignKey("dbo.PensionPolicies", "PageTenId", "dbo.PageTens");
            DropForeignKey("dbo.FactFinds", "PageSixId", "dbo.PageSixes");
            DropForeignKey("dbo.FactFinds", "PageSevenId", "dbo.PageSevens");
            DropForeignKey("dbo.FactFinds", "PageOneId", "dbo.PageOnes");
            DropForeignKey("dbo.FactFinds", "PageNineId", "dbo.PageNines");
            DropForeignKey("dbo.FactFinds", "PageFourId", "dbo.PageFours");
            DropForeignKey("dbo.NonFinancialDependants", "PageFourId", "dbo.PageFours");
            DropForeignKey("dbo.FinancialDependants", "PageFourId", "dbo.PageFours");
            DropForeignKey("dbo.FactFinds", "PageFiveId", "dbo.PageFives");
            DropForeignKey("dbo.FactFinds", "PageEightId", "dbo.PageEights");
            DropForeignKey("dbo.BreakDownOfLiabilities", "PageSevenId", "dbo.PageSevens");
            DropIndex("dbo.SavingsAndInvestmentPolicies", new[] { "PageTenId" });
            DropIndex("dbo.ProtectionAndInsurancePolicies", new[] { "PageTenId" });
            DropIndex("dbo.PensionPolicies", new[] { "PageTenId" });
            DropIndex("dbo.NonFinancialDependants", new[] { "PageFourId" });
            DropIndex("dbo.FinancialDependants", new[] { "PageFourId" });
            DropIndex("dbo.FactFinds", new[] { "PageTenId" });
            DropIndex("dbo.FactFinds", new[] { "PageNineId" });
            DropIndex("dbo.FactFinds", new[] { "PageEightId" });
            DropIndex("dbo.FactFinds", new[] { "PageSevenId" });
            DropIndex("dbo.FactFinds", new[] { "PageSixId" });
            DropIndex("dbo.FactFinds", new[] { "PageFiveId" });
            DropIndex("dbo.FactFinds", new[] { "PageFourId" });
            DropIndex("dbo.FactFinds", new[] { "PageThreeId" });
            DropIndex("dbo.FactFinds", new[] { "PageTwoId" });
            DropIndex("dbo.FactFinds", new[] { "PageOneId" });
            DropIndex("dbo.FactFinds", new[] { "UserId" });
            DropIndex("dbo.BreakDownOfLiabilities", new[] { "PageSevenId" });
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

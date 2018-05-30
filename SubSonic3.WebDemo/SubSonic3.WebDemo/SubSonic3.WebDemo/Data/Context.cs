


using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using SubSonic.DataProviders;
using SubSonic.Extensions;
using SubSonic.Linq.Structure;
using SubSonic.Query;
using SubSonic.Schema;
using System.Data.Common;
using System.Collections.Generic;

namespace AdventureWorks.Data
{
    public partial class NorthwindDB : IQuerySurface
    {

        public IDataProvider DataProvider;
        public DbQueryProvider provider;
        
        public bool TestMode
		{
            get
			{
                return DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            }
        }

        public NorthwindDB() 
        { 
            DataProvider = ProviderFactory.GetProvider("AdventureWorksDBConn");
            Init();
        }

        public NorthwindDB(string connectionStringName)
        {
            DataProvider = ProviderFactory.GetProvider(connectionStringName);
            Init();
        }

		public NorthwindDB(string connectionString, string providerName)
        {
            DataProvider = ProviderFactory.GetProvider(connectionString,providerName);
            Init();
        }

		public ITable FindByPrimaryKey(string pkName)
        {
            return DataProvider.Schema.Tables.SingleOrDefault(x => x.PrimaryKey.Name.Equals(pkName, StringComparison.InvariantCultureIgnoreCase));
        }

        public Query<T> GetQuery<T>()
        {
            return new Query<T>(provider);
        }
        
        public ITable FindTable(string tableName)
        {
            return DataProvider.FindTable(tableName);
        }
               
        public IDataProvider Provider
        {
            get { return DataProvider; }
            set {DataProvider=value;}
        }
        
        public DbQueryProvider QueryProvider
        {
            get { return provider; }
        }
        
        BatchQuery _batch = null;
        public void Queue<T>(IQueryable<T> qry)
        {
            if (_batch == null)
                _batch = new BatchQuery(Provider, QueryProvider);
            _batch.Queue(qry);
        }

        public void Queue(ISqlQuery qry)
        {
            if (_batch == null)
                _batch = new BatchQuery(Provider, QueryProvider);
            _batch.Queue(qry);
        }

        public void ExecuteTransaction(IList<DbCommand> commands)
		{
            if(!TestMode)
			{
                using(var connection = commands[0].Connection)
				{
                   if (connection.State == ConnectionState.Closed)
                        connection.Open();
                   
                   using (var trans = connection.BeginTransaction()) 
				   {
                        foreach (var cmd in commands) 
						{
                            cmd.Transaction = trans;
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                        }
                        trans.Commit();
                    }
                    connection.Close();
                }
            }
        }

        public IDataReader ExecuteBatch()
        {
            if (_batch == null)
                throw new InvalidOperationException("There's nothing in the queue");
            if(!TestMode)
                return _batch.ExecuteReader();
            return null;
        }
			
        public Query<ProductProductPhoto> ProductProductPhotos { get; set; }
        public Query<StoreContact> StoreContacts { get; set; }
        public Query<Address> Addresses { get; set; }
        public Query<ProductReview> ProductReviews { get; set; }
        public Query<TransactionHistory> TransactionHistories { get; set; }
        public Query<AddressType> AddressTypes { get; set; }
        public Query<ProductSubcategory> ProductSubcategories { get; set; }
        public Query<AWBuildVersion> AWBuildVersions { get; set; }
        public Query<TransactionHistoryArchive> TransactionHistoryArchives { get; set; }
        public Query<ProductVendor> ProductVendors { get; set; }
        public Query<BillOfMaterial> BillOfMaterials { get; set; }
        public Query<UnitMeasure> UnitMeasures { get; set; }
        public Query<Vendor> Vendors { get; set; }
        public Query<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public Query<Contact> Contacts { get; set; }
        public Query<VendorAddress> VendorAddresses { get; set; }
        public Query<VendorContact> VendorContacts { get; set; }
        public Query<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }
        public Query<ContactCreditCard> ContactCreditCards { get; set; }
        public Query<WorkOrder> WorkOrders { get; set; }
        public Query<ContactType> ContactTypes { get; set; }
        public Query<CountryRegionCurrency> CountryRegionCurrencies { get; set; }
        public Query<WorkOrderRouting> WorkOrderRoutings { get; set; }
        public Query<CountryRegion> CountryRegions { get; set; }
        public Query<CreditCard> CreditCards { get; set; }
        public Query<Culture> Cultures { get; set; }
        public Query<Currency> Currencies { get; set; }
        public Query<SalesOrderDetail> SalesOrderDetails { get; set; }
        public Query<CurrencyRate> CurrencyRates { get; set; }
        public Query<Customer> Customers { get; set; }
        public Query<SalesOrderHeader> SalesOrderHeaders { get; set; }
        public Query<CustomerAddress> CustomerAddresses { get; set; }
        public Query<Department> Departments { get; set; }
        public Query<Document> Documents { get; set; }
        public Query<Employee> Employees { get; set; }
        public Query<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; }
        public Query<SalesPerson> SalesPeople { get; set; }
        public Query<EmployeeAddress> EmployeeAddresses { get; set; }
        public Query<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }
        public Query<EmployeePayHistory> EmployeePayHistories { get; set; }
        public Query<SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; }
        public Query<Illustration> Illustrations { get; set; }
        public Query<SalesReason> SalesReasons { get; set; }
        public Query<Individual> Individuals { get; set; }
        public Query<SalesTaxRate> SalesTaxRates { get; set; }
        public Query<JobCandidate> JobCandidates { get; set; }
        public Query<Location> Locations { get; set; }
        public Query<SalesTerritory> SalesTerritories { get; set; }
        public Query<Product> Products { get; set; }
        public Query<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }
        public Query<ScrapReason> ScrapReasons { get; set; }
        public Query<Shift> Shifts { get; set; }
        public Query<ProductCategory> ProductCategories { get; set; }
        public Query<ShipMethod> ShipMethods { get; set; }
        public Query<ProductCostHistory> ProductCostHistories { get; set; }
        public Query<ProductDescription> ProductDescriptions { get; set; }
        public Query<ShoppingCartItem> ShoppingCartItems { get; set; }
        public Query<ProductDocument> ProductDocuments { get; set; }
        public Query<ProductInventory> ProductInventories { get; set; }
        public Query<SpecialOffer> SpecialOffers { get; set; }
        public Query<ProductListPriceHistory> ProductListPriceHistories { get; set; }
        public Query<SpecialOfferProduct> SpecialOfferProducts { get; set; }
        public Query<ProductModel> ProductModels { get; set; }
        public Query<StateProvince> StateProvinces { get; set; }
        public Query<ProductModelIllustration> ProductModelIllustrations { get; set; }
        public Query<DatabaseLog> DatabaseLogs { get; set; }
        public Query<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }
        public Query<ErrorLog> ErrorLogs { get; set; }
        public Query<Store> Stores { get; set; }
        public Query<ProductPhoto> ProductPhotos { get; set; }

			

        #region ' Aggregates and SubSonic Queries '
        public Select SelectColumns(params string[] columns)
        {
            return new Select(DataProvider, columns);
        }

        public Select Select
        {
            get { return new Select(this.Provider); }
        }

        public Insert Insert
		{
            get { return new Insert(this.Provider); }
        }

        public Update<T> Update<T>() where T:new()
		{
            return new Update<T>(this.Provider);
        }

        public SqlQuery Delete<T>(Expression<Func<T,bool>> column) where T:new()
        {
            LambdaExpression lamda = column;
            SqlQuery result = new Delete<T>(this.Provider);
            result = result.From<T>();
            result.Constraints=lamda.ParseConstraints().ToList();
            return result;
        }

        public SqlQuery Max<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = DataProvider.FindTable(objectName).Name;
            return new Select(DataProvider, new Aggregate(colName, AggregateFunction.Max)).From(tableName);
        }

        public SqlQuery Min<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.Min)).From(tableName);
        }

        public SqlQuery Sum<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.Sum)).From(tableName);
        }

        public SqlQuery Avg<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.Avg)).From(tableName);
        }

        public SqlQuery Count<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.Count)).From(tableName);
        }

        public SqlQuery Variance<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.Var)).From(tableName);
        }

        public SqlQuery StandardDeviation<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.StDev)).From(tableName);
        }

        #endregion

        void Init()
        {
            provider = new DbQueryProvider(this.Provider);

            #region ' Query Defs '
            ProductProductPhotos = new Query<ProductProductPhoto>(provider);
            StoreContacts = new Query<StoreContact>(provider);
            Addresses = new Query<Address>(provider);
            ProductReviews = new Query<ProductReview>(provider);
            TransactionHistories = new Query<TransactionHistory>(provider);
            AddressTypes = new Query<AddressType>(provider);
            ProductSubcategories = new Query<ProductSubcategory>(provider);
            AWBuildVersions = new Query<AWBuildVersion>(provider);
            TransactionHistoryArchives = new Query<TransactionHistoryArchive>(provider);
            ProductVendors = new Query<ProductVendor>(provider);
            BillOfMaterials = new Query<BillOfMaterial>(provider);
            UnitMeasures = new Query<UnitMeasure>(provider);
            Vendors = new Query<Vendor>(provider);
            PurchaseOrderDetails = new Query<PurchaseOrderDetail>(provider);
            Contacts = new Query<Contact>(provider);
            VendorAddresses = new Query<VendorAddress>(provider);
            VendorContacts = new Query<VendorContact>(provider);
            PurchaseOrderHeaders = new Query<PurchaseOrderHeader>(provider);
            ContactCreditCards = new Query<ContactCreditCard>(provider);
            WorkOrders = new Query<WorkOrder>(provider);
            ContactTypes = new Query<ContactType>(provider);
            CountryRegionCurrencies = new Query<CountryRegionCurrency>(provider);
            WorkOrderRoutings = new Query<WorkOrderRouting>(provider);
            CountryRegions = new Query<CountryRegion>(provider);
            CreditCards = new Query<CreditCard>(provider);
            Cultures = new Query<Culture>(provider);
            Currencies = new Query<Currency>(provider);
            SalesOrderDetails = new Query<SalesOrderDetail>(provider);
            CurrencyRates = new Query<CurrencyRate>(provider);
            Customers = new Query<Customer>(provider);
            SalesOrderHeaders = new Query<SalesOrderHeader>(provider);
            CustomerAddresses = new Query<CustomerAddress>(provider);
            Departments = new Query<Department>(provider);
            Documents = new Query<Document>(provider);
            Employees = new Query<Employee>(provider);
            SalesOrderHeaderSalesReasons = new Query<SalesOrderHeaderSalesReason>(provider);
            SalesPeople = new Query<SalesPerson>(provider);
            EmployeeAddresses = new Query<EmployeeAddress>(provider);
            EmployeeDepartmentHistories = new Query<EmployeeDepartmentHistory>(provider);
            EmployeePayHistories = new Query<EmployeePayHistory>(provider);
            SalesPersonQuotaHistories = new Query<SalesPersonQuotaHistory>(provider);
            Illustrations = new Query<Illustration>(provider);
            SalesReasons = new Query<SalesReason>(provider);
            Individuals = new Query<Individual>(provider);
            SalesTaxRates = new Query<SalesTaxRate>(provider);
            JobCandidates = new Query<JobCandidate>(provider);
            Locations = new Query<Location>(provider);
            SalesTerritories = new Query<SalesTerritory>(provider);
            Products = new Query<Product>(provider);
            SalesTerritoryHistories = new Query<SalesTerritoryHistory>(provider);
            ScrapReasons = new Query<ScrapReason>(provider);
            Shifts = new Query<Shift>(provider);
            ProductCategories = new Query<ProductCategory>(provider);
            ShipMethods = new Query<ShipMethod>(provider);
            ProductCostHistories = new Query<ProductCostHistory>(provider);
            ProductDescriptions = new Query<ProductDescription>(provider);
            ShoppingCartItems = new Query<ShoppingCartItem>(provider);
            ProductDocuments = new Query<ProductDocument>(provider);
            ProductInventories = new Query<ProductInventory>(provider);
            SpecialOffers = new Query<SpecialOffer>(provider);
            ProductListPriceHistories = new Query<ProductListPriceHistory>(provider);
            SpecialOfferProducts = new Query<SpecialOfferProduct>(provider);
            ProductModels = new Query<ProductModel>(provider);
            StateProvinces = new Query<StateProvince>(provider);
            ProductModelIllustrations = new Query<ProductModelIllustration>(provider);
            DatabaseLogs = new Query<DatabaseLog>(provider);
            ProductModelProductDescriptionCultures = new Query<ProductModelProductDescriptionCulture>(provider);
            ErrorLogs = new Query<ErrorLog>(provider);
            Stores = new Query<Store>(provider);
            ProductPhotos = new Query<ProductPhoto>(provider);
            #endregion


            #region ' Schemas '
        	if(DataProvider.Schema.Tables.Count == 0)
			{
            	DataProvider.Schema.Tables.Add(new ProductProductPhotoTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new StoreContactTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new AddressTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ProductReviewTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TransactionHistoryTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new AddressTypeTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ProductSubcategoryTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new AWBuildVersionTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TransactionHistoryArchiveTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ProductVendorTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new BillOfMaterialsTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new UnitMeasureTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new VendorTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new PurchaseOrderDetailTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ContactTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new VendorAddressTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new VendorContactTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new PurchaseOrderHeaderTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ContactCreditCardTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new WorkOrderTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ContactTypeTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new CountryRegionCurrencyTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new WorkOrderRoutingTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new CountryRegionTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new CreditCardTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new CultureTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new CurrencyTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new SalesOrderDetailTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new CurrencyRateTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new CustomerTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new SalesOrderHeaderTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new CustomerAddressTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new DepartmentTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new DocumentTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new EmployeeTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new SalesOrderHeaderSalesReasonTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new SalesPersonTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new EmployeeAddressTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new EmployeeDepartmentHistoryTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new EmployeePayHistoryTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new SalesPersonQuotaHistoryTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new IllustrationTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new SalesReasonTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new IndividualTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new SalesTaxRateTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new JobCandidateTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new LocationTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new SalesTerritoryTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ProductTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new SalesTerritoryHistoryTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ScrapReasonTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ShiftTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ProductCategoryTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ShipMethodTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ProductCostHistoryTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ProductDescriptionTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ShoppingCartItemTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ProductDocumentTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ProductInventoryTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new SpecialOfferTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ProductListPriceHistoryTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new SpecialOfferProductTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ProductModelTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new StateProvinceTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ProductModelIllustrationTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new DatabaseLogTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ProductModelProductDescriptionCultureTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ErrorLogTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new StoreTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ProductPhotoTable(DataProvider));
            }
            #endregion
        }
    }
}
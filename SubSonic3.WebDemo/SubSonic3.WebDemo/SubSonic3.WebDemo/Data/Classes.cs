


using System;
using System.ComponentModel;
using System.Linq;

namespace AdventureWorks.Data
{
    
    
    
    
    /// <summary>
    /// A class which represents the ProductProductPhoto table in the Northwind Database.
    /// This class is queryable through NorthwindDB.ProductProductPhoto 
    /// </summary>

	public partial class ProductProductPhoto: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public ProductProductPhoto(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnProductIDChanging(int value);
        partial void OnProductIDChanged();
		
		private int _ProductID;
		public int ProductID { 
		    get{
		        return _ProductID;
		    } 
		    set{
		        this.OnProductIDChanging(value);
                this.SendPropertyChanging();
                this._ProductID = value;
                this.SendPropertyChanged("ProductID");
                this.OnProductIDChanged();
		    }
		}
		
        partial void OnProductPhotoIDChanging(int value);
        partial void OnProductPhotoIDChanged();
		
		private int _ProductPhotoID;
		public int ProductPhotoID { 
		    get{
		        return _ProductPhotoID;
		    } 
		    set{
		        this.OnProductPhotoIDChanging(value);
                this.SendPropertyChanging();
                this._ProductPhotoID = value;
                this.SendPropertyChanged("ProductPhotoID");
                this.OnProductPhotoIDChanged();
		    }
		}
		
        partial void OnPrimaryChanging(bool value);
        partial void OnPrimaryChanged();
		
		private bool _Primary;
		public bool Primary { 
		    get{
		        return _Primary;
		    } 
		    set{
		        this.OnPrimaryChanging(value);
                this.SendPropertyChanging();
                this._Primary = value;
                this.SendPropertyChanged("Primary");
                this.OnPrimaryChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Product> Products
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Products
                       where items.ProductID == _ProductID
                       select items;
            }
        }

        public IQueryable<ProductPhoto> ProductPhotos
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.ProductPhotos
                       where items.ProductPhotoID == _ProductPhotoID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the StoreContact table in the Northwind Database.
    /// This class is queryable through NorthwindDB.StoreContact 
    /// </summary>

	public partial class StoreContact: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public StoreContact(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnCustomerIDChanging(int value);
        partial void OnCustomerIDChanged();
		
		private int _CustomerID;
		public int CustomerID { 
		    get{
		        return _CustomerID;
		    } 
		    set{
		        this.OnCustomerIDChanging(value);
                this.SendPropertyChanging();
                this._CustomerID = value;
                this.SendPropertyChanged("CustomerID");
                this.OnCustomerIDChanged();
		    }
		}
		
        partial void OnContactIDChanging(int value);
        partial void OnContactIDChanged();
		
		private int _ContactID;
		public int ContactID { 
		    get{
		        return _ContactID;
		    } 
		    set{
		        this.OnContactIDChanging(value);
                this.SendPropertyChanging();
                this._ContactID = value;
                this.SendPropertyChanged("ContactID");
                this.OnContactIDChanged();
		    }
		}
		
        partial void OnContactTypeIDChanging(int value);
        partial void OnContactTypeIDChanged();
		
		private int _ContactTypeID;
		public int ContactTypeID { 
		    get{
		        return _ContactTypeID;
		    } 
		    set{
		        this.OnContactTypeIDChanging(value);
                this.SendPropertyChanging();
                this._ContactTypeID = value;
                this.SendPropertyChanged("ContactTypeID");
                this.OnContactTypeIDChanged();
		    }
		}
		
        partial void OnrowguidChanging(Guid value);
        partial void OnrowguidChanged();
		
		private Guid _rowguid;
		public Guid rowguid { 
		    get{
		        return _rowguid;
		    } 
		    set{
		        this.OnrowguidChanging(value);
                this.SendPropertyChanging();
                this._rowguid = value;
                this.SendPropertyChanged("rowguid");
                this.OnrowguidChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Contact> Contacts
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Contacts
                       where items.ContactID == _ContactID
                       select items;
            }
        }

        public IQueryable<ContactType> ContactTypes
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.ContactTypes
                       where items.ContactTypeID == _ContactTypeID
                       select items;
            }
        }

        public IQueryable<Store> Stores
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Stores
                       where items.CustomerID == _CustomerID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the Address table in the Northwind Database.
    /// This class is queryable through NorthwindDB.Address 
    /// </summary>

	public partial class Address: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public Address(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnAddressIDChanging(int value);
        partial void OnAddressIDChanged();
		
		private int _AddressID;
		public int AddressID { 
		    get{
		        return _AddressID;
		    } 
		    set{
		        this.OnAddressIDChanging(value);
                this.SendPropertyChanging();
                this._AddressID = value;
                this.SendPropertyChanged("AddressID");
                this.OnAddressIDChanged();
		    }
		}
		
        partial void OnAddressLine1Changing(string value);
        partial void OnAddressLine1Changed();
		
		private string _AddressLine1;
		public string AddressLine1 { 
		    get{
		        return _AddressLine1;
		    } 
		    set{
		        this.OnAddressLine1Changing(value);
                this.SendPropertyChanging();
                this._AddressLine1 = value;
                this.SendPropertyChanged("AddressLine1");
                this.OnAddressLine1Changed();
		    }
		}
		
        partial void OnAddressLine2Changing(string value);
        partial void OnAddressLine2Changed();
		
		private string _AddressLine2;
		public string AddressLine2 { 
		    get{
		        return _AddressLine2;
		    } 
		    set{
		        this.OnAddressLine2Changing(value);
                this.SendPropertyChanging();
                this._AddressLine2 = value;
                this.SendPropertyChanged("AddressLine2");
                this.OnAddressLine2Changed();
		    }
		}
		
        partial void OnCityChanging(string value);
        partial void OnCityChanged();
		
		private string _City;
		public string City { 
		    get{
		        return _City;
		    } 
		    set{
		        this.OnCityChanging(value);
                this.SendPropertyChanging();
                this._City = value;
                this.SendPropertyChanged("City");
                this.OnCityChanged();
		    }
		}
		
        partial void OnStateProvinceIDChanging(int value);
        partial void OnStateProvinceIDChanged();
		
		private int _StateProvinceID;
		public int StateProvinceID { 
		    get{
		        return _StateProvinceID;
		    } 
		    set{
		        this.OnStateProvinceIDChanging(value);
                this.SendPropertyChanging();
                this._StateProvinceID = value;
                this.SendPropertyChanged("StateProvinceID");
                this.OnStateProvinceIDChanged();
		    }
		}
		
        partial void OnPostalCodeChanging(string value);
        partial void OnPostalCodeChanged();
		
		private string _PostalCode;
		public string PostalCode { 
		    get{
		        return _PostalCode;
		    } 
		    set{
		        this.OnPostalCodeChanging(value);
                this.SendPropertyChanging();
                this._PostalCode = value;
                this.SendPropertyChanged("PostalCode");
                this.OnPostalCodeChanged();
		    }
		}
		
        partial void OnrowguidChanging(Guid value);
        partial void OnrowguidChanged();
		
		private Guid _rowguid;
		public Guid rowguid { 
		    get{
		        return _rowguid;
		    } 
		    set{
		        this.OnrowguidChanging(value);
                this.SendPropertyChanging();
                this._rowguid = value;
                this.SendPropertyChanged("rowguid");
                this.OnrowguidChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<SalesOrderHeader> SalesOrderHeaders
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SalesOrderHeaders
                       where items.BillToAddressID == _AddressID
                       select items;
            }
        }

        public IQueryable<SalesOrderHeader> SalesOrderHeaders1
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SalesOrderHeaders
                       where items.ShipToAddressID == _AddressID
                       select items;
            }
        }

        public IQueryable<VendorAddress> VendorAddresses
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.VendorAddresses
                       where items.AddressID == _AddressID
                       select items;
            }
        }

        public IQueryable<StateProvince> StateProvinces
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.StateProvinces
                       where items.StateProvinceID == _StateProvinceID
                       select items;
            }
        }

        public IQueryable<CustomerAddress> CustomerAddresses
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.CustomerAddresses
                       where items.AddressID == _AddressID
                       select items;
            }
        }

        public IQueryable<EmployeeAddress> EmployeeAddresses
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.EmployeeAddresses
                       where items.AddressID == _AddressID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the ProductReview table in the Northwind Database.
    /// This class is queryable through NorthwindDB.ProductReview 
    /// </summary>

	public partial class ProductReview: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public ProductReview(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnProductReviewIDChanging(int value);
        partial void OnProductReviewIDChanged();
		
		private int _ProductReviewID;
		public int ProductReviewID { 
		    get{
		        return _ProductReviewID;
		    } 
		    set{
		        this.OnProductReviewIDChanging(value);
                this.SendPropertyChanging();
                this._ProductReviewID = value;
                this.SendPropertyChanged("ProductReviewID");
                this.OnProductReviewIDChanged();
		    }
		}
		
        partial void OnProductIDChanging(int value);
        partial void OnProductIDChanged();
		
		private int _ProductID;
		public int ProductID { 
		    get{
		        return _ProductID;
		    } 
		    set{
		        this.OnProductIDChanging(value);
                this.SendPropertyChanging();
                this._ProductID = value;
                this.SendPropertyChanged("ProductID");
                this.OnProductIDChanged();
		    }
		}
		
        partial void OnReviewerNameChanging(string value);
        partial void OnReviewerNameChanged();
		
		private string _ReviewerName;
		public string ReviewerName { 
		    get{
		        return _ReviewerName;
		    } 
		    set{
		        this.OnReviewerNameChanging(value);
                this.SendPropertyChanging();
                this._ReviewerName = value;
                this.SendPropertyChanged("ReviewerName");
                this.OnReviewerNameChanged();
		    }
		}
		
        partial void OnReviewDateChanging(DateTime value);
        partial void OnReviewDateChanged();
		
		private DateTime _ReviewDate;
		public DateTime ReviewDate { 
		    get{
		        return _ReviewDate;
		    } 
		    set{
		        this.OnReviewDateChanging(value);
                this.SendPropertyChanging();
                this._ReviewDate = value;
                this.SendPropertyChanged("ReviewDate");
                this.OnReviewDateChanged();
		    }
		}
		
        partial void OnEmailAddressChanging(string value);
        partial void OnEmailAddressChanged();
		
		private string _EmailAddress;
		public string EmailAddress { 
		    get{
		        return _EmailAddress;
		    } 
		    set{
		        this.OnEmailAddressChanging(value);
                this.SendPropertyChanging();
                this._EmailAddress = value;
                this.SendPropertyChanged("EmailAddress");
                this.OnEmailAddressChanged();
		    }
		}
		
        partial void OnRatingChanging(int value);
        partial void OnRatingChanged();
		
		private int _Rating;
		public int Rating { 
		    get{
		        return _Rating;
		    } 
		    set{
		        this.OnRatingChanging(value);
                this.SendPropertyChanging();
                this._Rating = value;
                this.SendPropertyChanged("Rating");
                this.OnRatingChanged();
		    }
		}
		
        partial void OnCommentsChanging(string value);
        partial void OnCommentsChanged();
		
		private string _Comments;
		public string Comments { 
		    get{
		        return _Comments;
		    } 
		    set{
		        this.OnCommentsChanging(value);
                this.SendPropertyChanging();
                this._Comments = value;
                this.SendPropertyChanged("Comments");
                this.OnCommentsChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Product> Products
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Products
                       where items.ProductID == _ProductID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TransactionHistory table in the Northwind Database.
    /// This class is queryable through NorthwindDB.TransactionHistory 
    /// </summary>

	public partial class TransactionHistory: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TransactionHistory(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnTransactionIDChanging(int value);
        partial void OnTransactionIDChanged();
		
		private int _TransactionID;
		public int TransactionID { 
		    get{
		        return _TransactionID;
		    } 
		    set{
		        this.OnTransactionIDChanging(value);
                this.SendPropertyChanging();
                this._TransactionID = value;
                this.SendPropertyChanged("TransactionID");
                this.OnTransactionIDChanged();
		    }
		}
		
        partial void OnProductIDChanging(int value);
        partial void OnProductIDChanged();
		
		private int _ProductID;
		public int ProductID { 
		    get{
		        return _ProductID;
		    } 
		    set{
		        this.OnProductIDChanging(value);
                this.SendPropertyChanging();
                this._ProductID = value;
                this.SendPropertyChanged("ProductID");
                this.OnProductIDChanged();
		    }
		}
		
        partial void OnReferenceOrderIDChanging(int value);
        partial void OnReferenceOrderIDChanged();
		
		private int _ReferenceOrderID;
		public int ReferenceOrderID { 
		    get{
		        return _ReferenceOrderID;
		    } 
		    set{
		        this.OnReferenceOrderIDChanging(value);
                this.SendPropertyChanging();
                this._ReferenceOrderID = value;
                this.SendPropertyChanged("ReferenceOrderID");
                this.OnReferenceOrderIDChanged();
		    }
		}
		
        partial void OnReferenceOrderLineIDChanging(int value);
        partial void OnReferenceOrderLineIDChanged();
		
		private int _ReferenceOrderLineID;
		public int ReferenceOrderLineID { 
		    get{
		        return _ReferenceOrderLineID;
		    } 
		    set{
		        this.OnReferenceOrderLineIDChanging(value);
                this.SendPropertyChanging();
                this._ReferenceOrderLineID = value;
                this.SendPropertyChanged("ReferenceOrderLineID");
                this.OnReferenceOrderLineIDChanged();
		    }
		}
		
        partial void OnTransactionDateChanging(DateTime value);
        partial void OnTransactionDateChanged();
		
		private DateTime _TransactionDate;
		public DateTime TransactionDate { 
		    get{
		        return _TransactionDate;
		    } 
		    set{
		        this.OnTransactionDateChanging(value);
                this.SendPropertyChanging();
                this._TransactionDate = value;
                this.SendPropertyChanged("TransactionDate");
                this.OnTransactionDateChanged();
		    }
		}
		
        partial void OnTransactionTypeChanging(string value);
        partial void OnTransactionTypeChanged();
		
		private string _TransactionType;
		public string TransactionType { 
		    get{
		        return _TransactionType;
		    } 
		    set{
		        this.OnTransactionTypeChanging(value);
                this.SendPropertyChanging();
                this._TransactionType = value;
                this.SendPropertyChanged("TransactionType");
                this.OnTransactionTypeChanged();
		    }
		}
		
        partial void OnQuantityChanging(int value);
        partial void OnQuantityChanged();
		
		private int _Quantity;
		public int Quantity { 
		    get{
		        return _Quantity;
		    } 
		    set{
		        this.OnQuantityChanging(value);
                this.SendPropertyChanging();
                this._Quantity = value;
                this.SendPropertyChanged("Quantity");
                this.OnQuantityChanged();
		    }
		}
		
        partial void OnActualCostChanging(decimal value);
        partial void OnActualCostChanged();
		
		private decimal _ActualCost;
		public decimal ActualCost { 
		    get{
		        return _ActualCost;
		    } 
		    set{
		        this.OnActualCostChanging(value);
                this.SendPropertyChanging();
                this._ActualCost = value;
                this.SendPropertyChanged("ActualCost");
                this.OnActualCostChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Product> Products
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Products
                       where items.ProductID == _ProductID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the AddressType table in the Northwind Database.
    /// This class is queryable through NorthwindDB.AddressType 
    /// </summary>

	public partial class AddressType: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public AddressType(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnAddressTypeIDChanging(int value);
        partial void OnAddressTypeIDChanged();
		
		private int _AddressTypeID;
		public int AddressTypeID { 
		    get{
		        return _AddressTypeID;
		    } 
		    set{
		        this.OnAddressTypeIDChanging(value);
                this.SendPropertyChanging();
                this._AddressTypeID = value;
                this.SendPropertyChanged("AddressTypeID");
                this.OnAddressTypeIDChanged();
		    }
		}
		
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
		
		private string _Name;
		public string Name { 
		    get{
		        return _Name;
		    } 
		    set{
		        this.OnNameChanging(value);
                this.SendPropertyChanging();
                this._Name = value;
                this.SendPropertyChanged("Name");
                this.OnNameChanged();
		    }
		}
		
        partial void OnrowguidChanging(Guid value);
        partial void OnrowguidChanged();
		
		private Guid _rowguid;
		public Guid rowguid { 
		    get{
		        return _rowguid;
		    } 
		    set{
		        this.OnrowguidChanging(value);
                this.SendPropertyChanging();
                this._rowguid = value;
                this.SendPropertyChanged("rowguid");
                this.OnrowguidChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<VendorAddress> VendorAddresses
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.VendorAddresses
                       where items.AddressTypeID == _AddressTypeID
                       select items;
            }
        }

        public IQueryable<CustomerAddress> CustomerAddresses
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.CustomerAddresses
                       where items.AddressTypeID == _AddressTypeID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the ProductSubcategory table in the Northwind Database.
    /// This class is queryable through NorthwindDB.ProductSubcategory 
    /// </summary>

	public partial class ProductSubcategory: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public ProductSubcategory(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnProductSubcategoryIDChanging(int value);
        partial void OnProductSubcategoryIDChanged();
		
		private int _ProductSubcategoryID;
		public int ProductSubcategoryID { 
		    get{
		        return _ProductSubcategoryID;
		    } 
		    set{
		        this.OnProductSubcategoryIDChanging(value);
                this.SendPropertyChanging();
                this._ProductSubcategoryID = value;
                this.SendPropertyChanged("ProductSubcategoryID");
                this.OnProductSubcategoryIDChanged();
		    }
		}
		
        partial void OnProductCategoryIDChanging(int value);
        partial void OnProductCategoryIDChanged();
		
		private int _ProductCategoryID;
		public int ProductCategoryID { 
		    get{
		        return _ProductCategoryID;
		    } 
		    set{
		        this.OnProductCategoryIDChanging(value);
                this.SendPropertyChanging();
                this._ProductCategoryID = value;
                this.SendPropertyChanged("ProductCategoryID");
                this.OnProductCategoryIDChanged();
		    }
		}
		
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
		
		private string _Name;
		public string Name { 
		    get{
		        return _Name;
		    } 
		    set{
		        this.OnNameChanging(value);
                this.SendPropertyChanging();
                this._Name = value;
                this.SendPropertyChanged("Name");
                this.OnNameChanged();
		    }
		}
		
        partial void OnrowguidChanging(Guid value);
        partial void OnrowguidChanged();
		
		private Guid _rowguid;
		public Guid rowguid { 
		    get{
		        return _rowguid;
		    } 
		    set{
		        this.OnrowguidChanging(value);
                this.SendPropertyChanging();
                this._rowguid = value;
                this.SendPropertyChanged("rowguid");
                this.OnrowguidChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Product> Products
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Products
                       where items.ProductSubcategoryID == _ProductSubcategoryID
                       select items;
            }
        }

        public IQueryable<ProductCategory> ProductCategories
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.ProductCategories
                       where items.ProductCategoryID == _ProductCategoryID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the AWBuildVersion table in the Northwind Database.
    /// This class is queryable through NorthwindDB.AWBuildVersion 
    /// </summary>

	public partial class AWBuildVersion: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public AWBuildVersion(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnSystemInformationIDChanging(byte[] value);
        partial void OnSystemInformationIDChanged();
		
		private byte[] _SystemInformationID;
		public byte[] SystemInformationID { 
		    get{
		        return _SystemInformationID;
		    } 
		    set{
		        this.OnSystemInformationIDChanging(value);
                this.SendPropertyChanging();
                this._SystemInformationID = value;
                this.SendPropertyChanged("SystemInformationID");
                this.OnSystemInformationIDChanged();
		    }
		}
		
        partial void OnDatabaseVersionChanging(string value);
        partial void OnDatabaseVersionChanged();
		
		private string _DatabaseVersion;
		public string DatabaseVersion { 
		    get{
		        return _DatabaseVersion;
		    } 
		    set{
		        this.OnDatabaseVersionChanging(value);
                this.SendPropertyChanging();
                this._DatabaseVersion = value;
                this.SendPropertyChanged("DatabaseVersion");
                this.OnDatabaseVersionChanged();
		    }
		}
		
        partial void OnVersionDateChanging(DateTime value);
        partial void OnVersionDateChanged();
		
		private DateTime _VersionDate;
		public DateTime VersionDate { 
		    get{
		        return _VersionDate;
		    } 
		    set{
		        this.OnVersionDateChanging(value);
                this.SendPropertyChanging();
                this._VersionDate = value;
                this.SendPropertyChanged("VersionDate");
                this.OnVersionDateChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TransactionHistoryArchive table in the Northwind Database.
    /// This class is queryable through NorthwindDB.TransactionHistoryArchive 
    /// </summary>

	public partial class TransactionHistoryArchive: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TransactionHistoryArchive(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnTransactionIDChanging(int value);
        partial void OnTransactionIDChanged();
		
		private int _TransactionID;
		public int TransactionID { 
		    get{
		        return _TransactionID;
		    } 
		    set{
		        this.OnTransactionIDChanging(value);
                this.SendPropertyChanging();
                this._TransactionID = value;
                this.SendPropertyChanged("TransactionID");
                this.OnTransactionIDChanged();
		    }
		}
		
        partial void OnProductIDChanging(int value);
        partial void OnProductIDChanged();
		
		private int _ProductID;
		public int ProductID { 
		    get{
		        return _ProductID;
		    } 
		    set{
		        this.OnProductIDChanging(value);
                this.SendPropertyChanging();
                this._ProductID = value;
                this.SendPropertyChanged("ProductID");
                this.OnProductIDChanged();
		    }
		}
		
        partial void OnReferenceOrderIDChanging(int value);
        partial void OnReferenceOrderIDChanged();
		
		private int _ReferenceOrderID;
		public int ReferenceOrderID { 
		    get{
		        return _ReferenceOrderID;
		    } 
		    set{
		        this.OnReferenceOrderIDChanging(value);
                this.SendPropertyChanging();
                this._ReferenceOrderID = value;
                this.SendPropertyChanged("ReferenceOrderID");
                this.OnReferenceOrderIDChanged();
		    }
		}
		
        partial void OnReferenceOrderLineIDChanging(int value);
        partial void OnReferenceOrderLineIDChanged();
		
		private int _ReferenceOrderLineID;
		public int ReferenceOrderLineID { 
		    get{
		        return _ReferenceOrderLineID;
		    } 
		    set{
		        this.OnReferenceOrderLineIDChanging(value);
                this.SendPropertyChanging();
                this._ReferenceOrderLineID = value;
                this.SendPropertyChanged("ReferenceOrderLineID");
                this.OnReferenceOrderLineIDChanged();
		    }
		}
		
        partial void OnTransactionDateChanging(DateTime value);
        partial void OnTransactionDateChanged();
		
		private DateTime _TransactionDate;
		public DateTime TransactionDate { 
		    get{
		        return _TransactionDate;
		    } 
		    set{
		        this.OnTransactionDateChanging(value);
                this.SendPropertyChanging();
                this._TransactionDate = value;
                this.SendPropertyChanged("TransactionDate");
                this.OnTransactionDateChanged();
		    }
		}
		
        partial void OnTransactionTypeChanging(string value);
        partial void OnTransactionTypeChanged();
		
		private string _TransactionType;
		public string TransactionType { 
		    get{
		        return _TransactionType;
		    } 
		    set{
		        this.OnTransactionTypeChanging(value);
                this.SendPropertyChanging();
                this._TransactionType = value;
                this.SendPropertyChanged("TransactionType");
                this.OnTransactionTypeChanged();
		    }
		}
		
        partial void OnQuantityChanging(int value);
        partial void OnQuantityChanged();
		
		private int _Quantity;
		public int Quantity { 
		    get{
		        return _Quantity;
		    } 
		    set{
		        this.OnQuantityChanging(value);
                this.SendPropertyChanging();
                this._Quantity = value;
                this.SendPropertyChanged("Quantity");
                this.OnQuantityChanged();
		    }
		}
		
        partial void OnActualCostChanging(decimal value);
        partial void OnActualCostChanged();
		
		private decimal _ActualCost;
		public decimal ActualCost { 
		    get{
		        return _ActualCost;
		    } 
		    set{
		        this.OnActualCostChanging(value);
                this.SendPropertyChanging();
                this._ActualCost = value;
                this.SendPropertyChanged("ActualCost");
                this.OnActualCostChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the ProductVendor table in the Northwind Database.
    /// This class is queryable through NorthwindDB.ProductVendor 
    /// </summary>

	public partial class ProductVendor: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public ProductVendor(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnProductIDChanging(int value);
        partial void OnProductIDChanged();
		
		private int _ProductID;
		public int ProductID { 
		    get{
		        return _ProductID;
		    } 
		    set{
		        this.OnProductIDChanging(value);
                this.SendPropertyChanging();
                this._ProductID = value;
                this.SendPropertyChanged("ProductID");
                this.OnProductIDChanged();
		    }
		}
		
        partial void OnVendorIDChanging(int value);
        partial void OnVendorIDChanged();
		
		private int _VendorID;
		public int VendorID { 
		    get{
		        return _VendorID;
		    } 
		    set{
		        this.OnVendorIDChanging(value);
                this.SendPropertyChanging();
                this._VendorID = value;
                this.SendPropertyChanged("VendorID");
                this.OnVendorIDChanged();
		    }
		}
		
        partial void OnAverageLeadTimeChanging(int value);
        partial void OnAverageLeadTimeChanged();
		
		private int _AverageLeadTime;
		public int AverageLeadTime { 
		    get{
		        return _AverageLeadTime;
		    } 
		    set{
		        this.OnAverageLeadTimeChanging(value);
                this.SendPropertyChanging();
                this._AverageLeadTime = value;
                this.SendPropertyChanged("AverageLeadTime");
                this.OnAverageLeadTimeChanged();
		    }
		}
		
        partial void OnStandardPriceChanging(decimal value);
        partial void OnStandardPriceChanged();
		
		private decimal _StandardPrice;
		public decimal StandardPrice { 
		    get{
		        return _StandardPrice;
		    } 
		    set{
		        this.OnStandardPriceChanging(value);
                this.SendPropertyChanging();
                this._StandardPrice = value;
                this.SendPropertyChanged("StandardPrice");
                this.OnStandardPriceChanged();
		    }
		}
		
        partial void OnLastReceiptCostChanging(decimal? value);
        partial void OnLastReceiptCostChanged();
		
		private decimal? _LastReceiptCost;
		public decimal? LastReceiptCost { 
		    get{
		        return _LastReceiptCost;
		    } 
		    set{
		        this.OnLastReceiptCostChanging(value);
                this.SendPropertyChanging();
                this._LastReceiptCost = value;
                this.SendPropertyChanged("LastReceiptCost");
                this.OnLastReceiptCostChanged();
		    }
		}
		
        partial void OnLastReceiptDateChanging(DateTime? value);
        partial void OnLastReceiptDateChanged();
		
		private DateTime? _LastReceiptDate;
		public DateTime? LastReceiptDate { 
		    get{
		        return _LastReceiptDate;
		    } 
		    set{
		        this.OnLastReceiptDateChanging(value);
                this.SendPropertyChanging();
                this._LastReceiptDate = value;
                this.SendPropertyChanged("LastReceiptDate");
                this.OnLastReceiptDateChanged();
		    }
		}
		
        partial void OnMinOrderQtyChanging(int value);
        partial void OnMinOrderQtyChanged();
		
		private int _MinOrderQty;
		public int MinOrderQty { 
		    get{
		        return _MinOrderQty;
		    } 
		    set{
		        this.OnMinOrderQtyChanging(value);
                this.SendPropertyChanging();
                this._MinOrderQty = value;
                this.SendPropertyChanged("MinOrderQty");
                this.OnMinOrderQtyChanged();
		    }
		}
		
        partial void OnMaxOrderQtyChanging(int value);
        partial void OnMaxOrderQtyChanged();
		
		private int _MaxOrderQty;
		public int MaxOrderQty { 
		    get{
		        return _MaxOrderQty;
		    } 
		    set{
		        this.OnMaxOrderQtyChanging(value);
                this.SendPropertyChanging();
                this._MaxOrderQty = value;
                this.SendPropertyChanged("MaxOrderQty");
                this.OnMaxOrderQtyChanged();
		    }
		}
		
        partial void OnOnOrderQtyChanging(int? value);
        partial void OnOnOrderQtyChanged();
		
		private int? _OnOrderQty;
		public int? OnOrderQty { 
		    get{
		        return _OnOrderQty;
		    } 
		    set{
		        this.OnOnOrderQtyChanging(value);
                this.SendPropertyChanging();
                this._OnOrderQty = value;
                this.SendPropertyChanged("OnOrderQty");
                this.OnOnOrderQtyChanged();
		    }
		}
		
        partial void OnUnitMeasureCodeChanging(string value);
        partial void OnUnitMeasureCodeChanged();
		
		private string _UnitMeasureCode;
		public string UnitMeasureCode { 
		    get{
		        return _UnitMeasureCode;
		    } 
		    set{
		        this.OnUnitMeasureCodeChanging(value);
                this.SendPropertyChanging();
                this._UnitMeasureCode = value;
                this.SendPropertyChanged("UnitMeasureCode");
                this.OnUnitMeasureCodeChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Product> Products
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Products
                       where items.ProductID == _ProductID
                       select items;
            }
        }

        public IQueryable<UnitMeasure> UnitMeasures
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.UnitMeasures
                       where items.UnitMeasureCode == _UnitMeasureCode
                       select items;
            }
        }

        public IQueryable<Vendor> Vendors
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Vendors
                       where items.VendorID == _VendorID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the BillOfMaterials table in the Northwind Database.
    /// This class is queryable through NorthwindDB.BillOfMaterial 
    /// </summary>

	public partial class BillOfMaterial: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public BillOfMaterial(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnBillOfMaterialsIDChanging(int value);
        partial void OnBillOfMaterialsIDChanged();
		
		private int _BillOfMaterialsID;
		public int BillOfMaterialsID { 
		    get{
		        return _BillOfMaterialsID;
		    } 
		    set{
		        this.OnBillOfMaterialsIDChanging(value);
                this.SendPropertyChanging();
                this._BillOfMaterialsID = value;
                this.SendPropertyChanged("BillOfMaterialsID");
                this.OnBillOfMaterialsIDChanged();
		    }
		}
		
        partial void OnProductAssemblyIDChanging(int? value);
        partial void OnProductAssemblyIDChanged();
		
		private int? _ProductAssemblyID;
		public int? ProductAssemblyID { 
		    get{
		        return _ProductAssemblyID;
		    } 
		    set{
		        this.OnProductAssemblyIDChanging(value);
                this.SendPropertyChanging();
                this._ProductAssemblyID = value;
                this.SendPropertyChanged("ProductAssemblyID");
                this.OnProductAssemblyIDChanged();
		    }
		}
		
        partial void OnComponentIDChanging(int value);
        partial void OnComponentIDChanged();
		
		private int _ComponentID;
		public int ComponentID { 
		    get{
		        return _ComponentID;
		    } 
		    set{
		        this.OnComponentIDChanging(value);
                this.SendPropertyChanging();
                this._ComponentID = value;
                this.SendPropertyChanged("ComponentID");
                this.OnComponentIDChanged();
		    }
		}
		
        partial void OnStartDateChanging(DateTime value);
        partial void OnStartDateChanged();
		
		private DateTime _StartDate;
		public DateTime StartDate { 
		    get{
		        return _StartDate;
		    } 
		    set{
		        this.OnStartDateChanging(value);
                this.SendPropertyChanging();
                this._StartDate = value;
                this.SendPropertyChanged("StartDate");
                this.OnStartDateChanged();
		    }
		}
		
        partial void OnEndDateChanging(DateTime? value);
        partial void OnEndDateChanged();
		
		private DateTime? _EndDate;
		public DateTime? EndDate { 
		    get{
		        return _EndDate;
		    } 
		    set{
		        this.OnEndDateChanging(value);
                this.SendPropertyChanging();
                this._EndDate = value;
                this.SendPropertyChanged("EndDate");
                this.OnEndDateChanged();
		    }
		}
		
        partial void OnUnitMeasureCodeChanging(string value);
        partial void OnUnitMeasureCodeChanged();
		
		private string _UnitMeasureCode;
		public string UnitMeasureCode { 
		    get{
		        return _UnitMeasureCode;
		    } 
		    set{
		        this.OnUnitMeasureCodeChanging(value);
                this.SendPropertyChanging();
                this._UnitMeasureCode = value;
                this.SendPropertyChanged("UnitMeasureCode");
                this.OnUnitMeasureCodeChanged();
		    }
		}
		
        partial void OnBOMLevelChanging(short value);
        partial void OnBOMLevelChanged();
		
		private short _BOMLevel;
		public short BOMLevel { 
		    get{
		        return _BOMLevel;
		    } 
		    set{
		        this.OnBOMLevelChanging(value);
                this.SendPropertyChanging();
                this._BOMLevel = value;
                this.SendPropertyChanged("BOMLevel");
                this.OnBOMLevelChanged();
		    }
		}
		
        partial void OnPerAssemblyQtyChanging(decimal value);
        partial void OnPerAssemblyQtyChanged();
		
		private decimal _PerAssemblyQty;
		public decimal PerAssemblyQty { 
		    get{
		        return _PerAssemblyQty;
		    } 
		    set{
		        this.OnPerAssemblyQtyChanging(value);
                this.SendPropertyChanging();
                this._PerAssemblyQty = value;
                this.SendPropertyChanged("PerAssemblyQty");
                this.OnPerAssemblyQtyChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Product> Products
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Products
                       where items.ProductID == _ProductAssemblyID
                       select items;
            }
        }

        public IQueryable<Product> Products1
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Products
                       where items.ProductID == _ComponentID
                       select items;
            }
        }

        public IQueryable<UnitMeasure> UnitMeasures
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.UnitMeasures
                       where items.UnitMeasureCode == _UnitMeasureCode
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the UnitMeasure table in the Northwind Database.
    /// This class is queryable through NorthwindDB.UnitMeasure 
    /// </summary>

	public partial class UnitMeasure: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public UnitMeasure(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnUnitMeasureCodeChanging(string value);
        partial void OnUnitMeasureCodeChanged();
		
		private string _UnitMeasureCode;
		public string UnitMeasureCode { 
		    get{
		        return _UnitMeasureCode;
		    } 
		    set{
		        this.OnUnitMeasureCodeChanging(value);
                this.SendPropertyChanging();
                this._UnitMeasureCode = value;
                this.SendPropertyChanged("UnitMeasureCode");
                this.OnUnitMeasureCodeChanged();
		    }
		}
		
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
		
		private string _Name;
		public string Name { 
		    get{
		        return _Name;
		    } 
		    set{
		        this.OnNameChanging(value);
                this.SendPropertyChanging();
                this._Name = value;
                this.SendPropertyChanged("Name");
                this.OnNameChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Product> Products
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Products
                       where items.SizeUnitMeasureCode == _UnitMeasureCode
                       select items;
            }
        }

        public IQueryable<Product> Products1
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Products
                       where items.WeightUnitMeasureCode == _UnitMeasureCode
                       select items;
            }
        }

        public IQueryable<ProductVendor> ProductVendors
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.ProductVendors
                       where items.UnitMeasureCode == _UnitMeasureCode
                       select items;
            }
        }

        public IQueryable<BillOfMaterial> BillOfMaterials
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.BillOfMaterials
                       where items.UnitMeasureCode == _UnitMeasureCode
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the Vendor table in the Northwind Database.
    /// This class is queryable through NorthwindDB.Vendor 
    /// </summary>

	public partial class Vendor: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public Vendor(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnVendorIDChanging(int value);
        partial void OnVendorIDChanged();
		
		private int _VendorID;
		public int VendorID { 
		    get{
		        return _VendorID;
		    } 
		    set{
		        this.OnVendorIDChanging(value);
                this.SendPropertyChanging();
                this._VendorID = value;
                this.SendPropertyChanged("VendorID");
                this.OnVendorIDChanged();
		    }
		}
		
        partial void OnAccountNumberChanging(string value);
        partial void OnAccountNumberChanged();
		
		private string _AccountNumber;
		public string AccountNumber { 
		    get{
		        return _AccountNumber;
		    } 
		    set{
		        this.OnAccountNumberChanging(value);
                this.SendPropertyChanging();
                this._AccountNumber = value;
                this.SendPropertyChanged("AccountNumber");
                this.OnAccountNumberChanged();
		    }
		}
		
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
		
		private string _Name;
		public string Name { 
		    get{
		        return _Name;
		    } 
		    set{
		        this.OnNameChanging(value);
                this.SendPropertyChanging();
                this._Name = value;
                this.SendPropertyChanged("Name");
                this.OnNameChanged();
		    }
		}
		
        partial void OnCreditRatingChanging(byte[] value);
        partial void OnCreditRatingChanged();
		
		private byte[] _CreditRating;
		public byte[] CreditRating { 
		    get{
		        return _CreditRating;
		    } 
		    set{
		        this.OnCreditRatingChanging(value);
                this.SendPropertyChanging();
                this._CreditRating = value;
                this.SendPropertyChanged("CreditRating");
                this.OnCreditRatingChanged();
		    }
		}
		
        partial void OnPreferredVendorStatusChanging(bool value);
        partial void OnPreferredVendorStatusChanged();
		
		private bool _PreferredVendorStatus;
		public bool PreferredVendorStatus { 
		    get{
		        return _PreferredVendorStatus;
		    } 
		    set{
		        this.OnPreferredVendorStatusChanging(value);
                this.SendPropertyChanging();
                this._PreferredVendorStatus = value;
                this.SendPropertyChanged("PreferredVendorStatus");
                this.OnPreferredVendorStatusChanged();
		    }
		}
		
        partial void OnActiveFlagChanging(bool value);
        partial void OnActiveFlagChanged();
		
		private bool _ActiveFlag;
		public bool ActiveFlag { 
		    get{
		        return _ActiveFlag;
		    } 
		    set{
		        this.OnActiveFlagChanging(value);
                this.SendPropertyChanging();
                this._ActiveFlag = value;
                this.SendPropertyChanged("ActiveFlag");
                this.OnActiveFlagChanged();
		    }
		}
		
        partial void OnPurchasingWebServiceURLChanging(string value);
        partial void OnPurchasingWebServiceURLChanged();
		
		private string _PurchasingWebServiceURL;
		public string PurchasingWebServiceURL { 
		    get{
		        return _PurchasingWebServiceURL;
		    } 
		    set{
		        this.OnPurchasingWebServiceURLChanging(value);
                this.SendPropertyChanging();
                this._PurchasingWebServiceURL = value;
                this.SendPropertyChanged("PurchasingWebServiceURL");
                this.OnPurchasingWebServiceURLChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<ProductVendor> ProductVendors
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.ProductVendors
                       where items.VendorID == _VendorID
                       select items;
            }
        }

        public IQueryable<PurchaseOrderHeader> PurchaseOrderHeaders
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.PurchaseOrderHeaders
                       where items.VendorID == _VendorID
                       select items;
            }
        }

        public IQueryable<VendorAddress> VendorAddresses
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.VendorAddresses
                       where items.VendorID == _VendorID
                       select items;
            }
        }

        public IQueryable<VendorContact> VendorContacts
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.VendorContacts
                       where items.VendorID == _VendorID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the PurchaseOrderDetail table in the Northwind Database.
    /// This class is queryable through NorthwindDB.PurchaseOrderDetail 
    /// </summary>

	public partial class PurchaseOrderDetail: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public PurchaseOrderDetail(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnPurchaseOrderIDChanging(int value);
        partial void OnPurchaseOrderIDChanged();
		
		private int _PurchaseOrderID;
		public int PurchaseOrderID { 
		    get{
		        return _PurchaseOrderID;
		    } 
		    set{
		        this.OnPurchaseOrderIDChanging(value);
                this.SendPropertyChanging();
                this._PurchaseOrderID = value;
                this.SendPropertyChanged("PurchaseOrderID");
                this.OnPurchaseOrderIDChanged();
		    }
		}
		
        partial void OnPurchaseOrderDetailIDChanging(int value);
        partial void OnPurchaseOrderDetailIDChanged();
		
		private int _PurchaseOrderDetailID;
		public int PurchaseOrderDetailID { 
		    get{
		        return _PurchaseOrderDetailID;
		    } 
		    set{
		        this.OnPurchaseOrderDetailIDChanging(value);
                this.SendPropertyChanging();
                this._PurchaseOrderDetailID = value;
                this.SendPropertyChanged("PurchaseOrderDetailID");
                this.OnPurchaseOrderDetailIDChanged();
		    }
		}
		
        partial void OnDueDateChanging(DateTime value);
        partial void OnDueDateChanged();
		
		private DateTime _DueDate;
		public DateTime DueDate { 
		    get{
		        return _DueDate;
		    } 
		    set{
		        this.OnDueDateChanging(value);
                this.SendPropertyChanging();
                this._DueDate = value;
                this.SendPropertyChanged("DueDate");
                this.OnDueDateChanged();
		    }
		}
		
        partial void OnOrderQtyChanging(short value);
        partial void OnOrderQtyChanged();
		
		private short _OrderQty;
		public short OrderQty { 
		    get{
		        return _OrderQty;
		    } 
		    set{
		        this.OnOrderQtyChanging(value);
                this.SendPropertyChanging();
                this._OrderQty = value;
                this.SendPropertyChanged("OrderQty");
                this.OnOrderQtyChanged();
		    }
		}
		
        partial void OnProductIDChanging(int value);
        partial void OnProductIDChanged();
		
		private int _ProductID;
		public int ProductID { 
		    get{
		        return _ProductID;
		    } 
		    set{
		        this.OnProductIDChanging(value);
                this.SendPropertyChanging();
                this._ProductID = value;
                this.SendPropertyChanged("ProductID");
                this.OnProductIDChanged();
		    }
		}
		
        partial void OnUnitPriceChanging(decimal value);
        partial void OnUnitPriceChanged();
		
		private decimal _UnitPrice;
		public decimal UnitPrice { 
		    get{
		        return _UnitPrice;
		    } 
		    set{
		        this.OnUnitPriceChanging(value);
                this.SendPropertyChanging();
                this._UnitPrice = value;
                this.SendPropertyChanged("UnitPrice");
                this.OnUnitPriceChanged();
		    }
		}
		
        partial void OnLineTotalChanging(decimal value);
        partial void OnLineTotalChanged();
		
		private decimal _LineTotal;
		public decimal LineTotal { 
		    get{
		        return _LineTotal;
		    } 
		    set{
		        this.OnLineTotalChanging(value);
                this.SendPropertyChanging();
                this._LineTotal = value;
                this.SendPropertyChanged("LineTotal");
                this.OnLineTotalChanged();
		    }
		}
		
        partial void OnReceivedQtyChanging(decimal value);
        partial void OnReceivedQtyChanged();
		
		private decimal _ReceivedQty;
		public decimal ReceivedQty { 
		    get{
		        return _ReceivedQty;
		    } 
		    set{
		        this.OnReceivedQtyChanging(value);
                this.SendPropertyChanging();
                this._ReceivedQty = value;
                this.SendPropertyChanged("ReceivedQty");
                this.OnReceivedQtyChanged();
		    }
		}
		
        partial void OnRejectedQtyChanging(decimal value);
        partial void OnRejectedQtyChanged();
		
		private decimal _RejectedQty;
		public decimal RejectedQty { 
		    get{
		        return _RejectedQty;
		    } 
		    set{
		        this.OnRejectedQtyChanging(value);
                this.SendPropertyChanging();
                this._RejectedQty = value;
                this.SendPropertyChanged("RejectedQty");
                this.OnRejectedQtyChanged();
		    }
		}
		
        partial void OnStockedQtyChanging(decimal value);
        partial void OnStockedQtyChanged();
		
		private decimal _StockedQty;
		public decimal StockedQty { 
		    get{
		        return _StockedQty;
		    } 
		    set{
		        this.OnStockedQtyChanging(value);
                this.SendPropertyChanging();
                this._StockedQty = value;
                this.SendPropertyChanged("StockedQty");
                this.OnStockedQtyChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Product> Products
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Products
                       where items.ProductID == _ProductID
                       select items;
            }
        }

        public IQueryable<PurchaseOrderHeader> PurchaseOrderHeaders
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.PurchaseOrderHeaders
                       where items.PurchaseOrderID == _PurchaseOrderID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the Contact table in the Northwind Database.
    /// This class is queryable through NorthwindDB.Contact 
    /// </summary>

	public partial class Contact: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public Contact(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnContactIDChanging(int value);
        partial void OnContactIDChanged();
		
		private int _ContactID;
		public int ContactID { 
		    get{
		        return _ContactID;
		    } 
		    set{
		        this.OnContactIDChanging(value);
                this.SendPropertyChanging();
                this._ContactID = value;
                this.SendPropertyChanged("ContactID");
                this.OnContactIDChanged();
		    }
		}
		
        partial void OnNameStyleChanging(bool value);
        partial void OnNameStyleChanged();
		
		private bool _NameStyle;
		public bool NameStyle { 
		    get{
		        return _NameStyle;
		    } 
		    set{
		        this.OnNameStyleChanging(value);
                this.SendPropertyChanging();
                this._NameStyle = value;
                this.SendPropertyChanged("NameStyle");
                this.OnNameStyleChanged();
		    }
		}
		
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
		
		private string _Title;
		public string Title { 
		    get{
		        return _Title;
		    } 
		    set{
		        this.OnTitleChanging(value);
                this.SendPropertyChanging();
                this._Title = value;
                this.SendPropertyChanged("Title");
                this.OnTitleChanged();
		    }
		}
		
        partial void OnFirstNameChanging(string value);
        partial void OnFirstNameChanged();
		
		private string _FirstName;
		public string FirstName { 
		    get{
		        return _FirstName;
		    } 
		    set{
		        this.OnFirstNameChanging(value);
                this.SendPropertyChanging();
                this._FirstName = value;
                this.SendPropertyChanged("FirstName");
                this.OnFirstNameChanged();
		    }
		}
		
        partial void OnMiddleNameChanging(string value);
        partial void OnMiddleNameChanged();
		
		private string _MiddleName;
		public string MiddleName { 
		    get{
		        return _MiddleName;
		    } 
		    set{
		        this.OnMiddleNameChanging(value);
                this.SendPropertyChanging();
                this._MiddleName = value;
                this.SendPropertyChanged("MiddleName");
                this.OnMiddleNameChanged();
		    }
		}
		
        partial void OnLastNameChanging(string value);
        partial void OnLastNameChanged();
		
		private string _LastName;
		public string LastName { 
		    get{
		        return _LastName;
		    } 
		    set{
		        this.OnLastNameChanging(value);
                this.SendPropertyChanging();
                this._LastName = value;
                this.SendPropertyChanged("LastName");
                this.OnLastNameChanged();
		    }
		}
		
        partial void OnSuffixChanging(string value);
        partial void OnSuffixChanged();
		
		private string _Suffix;
		public string Suffix { 
		    get{
		        return _Suffix;
		    } 
		    set{
		        this.OnSuffixChanging(value);
                this.SendPropertyChanging();
                this._Suffix = value;
                this.SendPropertyChanged("Suffix");
                this.OnSuffixChanged();
		    }
		}
		
        partial void OnEmailAddressChanging(string value);
        partial void OnEmailAddressChanged();
		
		private string _EmailAddress;
		public string EmailAddress { 
		    get{
		        return _EmailAddress;
		    } 
		    set{
		        this.OnEmailAddressChanging(value);
                this.SendPropertyChanging();
                this._EmailAddress = value;
                this.SendPropertyChanged("EmailAddress");
                this.OnEmailAddressChanged();
		    }
		}
		
        partial void OnEmailPromotionChanging(int value);
        partial void OnEmailPromotionChanged();
		
		private int _EmailPromotion;
		public int EmailPromotion { 
		    get{
		        return _EmailPromotion;
		    } 
		    set{
		        this.OnEmailPromotionChanging(value);
                this.SendPropertyChanging();
                this._EmailPromotion = value;
                this.SendPropertyChanged("EmailPromotion");
                this.OnEmailPromotionChanged();
		    }
		}
		
        partial void OnPhoneChanging(string value);
        partial void OnPhoneChanged();
		
		private string _Phone;
		public string Phone { 
		    get{
		        return _Phone;
		    } 
		    set{
		        this.OnPhoneChanging(value);
                this.SendPropertyChanging();
                this._Phone = value;
                this.SendPropertyChanged("Phone");
                this.OnPhoneChanged();
		    }
		}
		
        partial void OnPasswordHashChanging(string value);
        partial void OnPasswordHashChanged();
		
		private string _PasswordHash;
		public string PasswordHash { 
		    get{
		        return _PasswordHash;
		    } 
		    set{
		        this.OnPasswordHashChanging(value);
                this.SendPropertyChanging();
                this._PasswordHash = value;
                this.SendPropertyChanged("PasswordHash");
                this.OnPasswordHashChanged();
		    }
		}
		
        partial void OnPasswordSaltChanging(string value);
        partial void OnPasswordSaltChanged();
		
		private string _PasswordSalt;
		public string PasswordSalt { 
		    get{
		        return _PasswordSalt;
		    } 
		    set{
		        this.OnPasswordSaltChanging(value);
                this.SendPropertyChanging();
                this._PasswordSalt = value;
                this.SendPropertyChanged("PasswordSalt");
                this.OnPasswordSaltChanged();
		    }
		}
		
        partial void OnAdditionalContactInfoChanging(string value);
        partial void OnAdditionalContactInfoChanged();
		
		private string _AdditionalContactInfo;
		public string AdditionalContactInfo { 
		    get{
		        return _AdditionalContactInfo;
		    } 
		    set{
		        this.OnAdditionalContactInfoChanging(value);
                this.SendPropertyChanging();
                this._AdditionalContactInfo = value;
                this.SendPropertyChanged("AdditionalContactInfo");
                this.OnAdditionalContactInfoChanged();
		    }
		}
		
        partial void OnrowguidChanging(Guid value);
        partial void OnrowguidChanged();
		
		private Guid _rowguid;
		public Guid rowguid { 
		    get{
		        return _rowguid;
		    } 
		    set{
		        this.OnrowguidChanging(value);
                this.SendPropertyChanging();
                this._rowguid = value;
                this.SendPropertyChanged("rowguid");
                this.OnrowguidChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Individual> Individuals
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Individuals
                       where items.ContactID == _ContactID
                       select items;
            }
        }

        public IQueryable<SalesOrderHeader> SalesOrderHeaders
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SalesOrderHeaders
                       where items.ContactID == _ContactID
                       select items;
            }
        }

        public IQueryable<StoreContact> StoreContacts
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.StoreContacts
                       where items.ContactID == _ContactID
                       select items;
            }
        }

        public IQueryable<VendorContact> VendorContacts
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.VendorContacts
                       where items.ContactID == _ContactID
                       select items;
            }
        }

        public IQueryable<ContactCreditCard> ContactCreditCards
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.ContactCreditCards
                       where items.ContactID == _ContactID
                       select items;
            }
        }

        public IQueryable<Employee> Employees
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Employees
                       where items.ContactID == _ContactID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the VendorAddress table in the Northwind Database.
    /// This class is queryable through NorthwindDB.VendorAddress 
    /// </summary>

	public partial class VendorAddress: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public VendorAddress(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnVendorIDChanging(int value);
        partial void OnVendorIDChanged();
		
		private int _VendorID;
		public int VendorID { 
		    get{
		        return _VendorID;
		    } 
		    set{
		        this.OnVendorIDChanging(value);
                this.SendPropertyChanging();
                this._VendorID = value;
                this.SendPropertyChanged("VendorID");
                this.OnVendorIDChanged();
		    }
		}
		
        partial void OnAddressIDChanging(int value);
        partial void OnAddressIDChanged();
		
		private int _AddressID;
		public int AddressID { 
		    get{
		        return _AddressID;
		    } 
		    set{
		        this.OnAddressIDChanging(value);
                this.SendPropertyChanging();
                this._AddressID = value;
                this.SendPropertyChanged("AddressID");
                this.OnAddressIDChanged();
		    }
		}
		
        partial void OnAddressTypeIDChanging(int value);
        partial void OnAddressTypeIDChanged();
		
		private int _AddressTypeID;
		public int AddressTypeID { 
		    get{
		        return _AddressTypeID;
		    } 
		    set{
		        this.OnAddressTypeIDChanging(value);
                this.SendPropertyChanging();
                this._AddressTypeID = value;
                this.SendPropertyChanged("AddressTypeID");
                this.OnAddressTypeIDChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Address> Addresses
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Addresses
                       where items.AddressID == _AddressID
                       select items;
            }
        }

        public IQueryable<AddressType> AddressTypes
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.AddressTypes
                       where items.AddressTypeID == _AddressTypeID
                       select items;
            }
        }

        public IQueryable<Vendor> Vendors
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Vendors
                       where items.VendorID == _VendorID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the VendorContact table in the Northwind Database.
    /// This class is queryable through NorthwindDB.VendorContact 
    /// </summary>

	public partial class VendorContact: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public VendorContact(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnVendorIDChanging(int value);
        partial void OnVendorIDChanged();
		
		private int _VendorID;
		public int VendorID { 
		    get{
		        return _VendorID;
		    } 
		    set{
		        this.OnVendorIDChanging(value);
                this.SendPropertyChanging();
                this._VendorID = value;
                this.SendPropertyChanged("VendorID");
                this.OnVendorIDChanged();
		    }
		}
		
        partial void OnContactIDChanging(int value);
        partial void OnContactIDChanged();
		
		private int _ContactID;
		public int ContactID { 
		    get{
		        return _ContactID;
		    } 
		    set{
		        this.OnContactIDChanging(value);
                this.SendPropertyChanging();
                this._ContactID = value;
                this.SendPropertyChanged("ContactID");
                this.OnContactIDChanged();
		    }
		}
		
        partial void OnContactTypeIDChanging(int value);
        partial void OnContactTypeIDChanged();
		
		private int _ContactTypeID;
		public int ContactTypeID { 
		    get{
		        return _ContactTypeID;
		    } 
		    set{
		        this.OnContactTypeIDChanging(value);
                this.SendPropertyChanging();
                this._ContactTypeID = value;
                this.SendPropertyChanged("ContactTypeID");
                this.OnContactTypeIDChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Contact> Contacts
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Contacts
                       where items.ContactID == _ContactID
                       select items;
            }
        }

        public IQueryable<ContactType> ContactTypes
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.ContactTypes
                       where items.ContactTypeID == _ContactTypeID
                       select items;
            }
        }

        public IQueryable<Vendor> Vendors
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Vendors
                       where items.VendorID == _VendorID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the PurchaseOrderHeader table in the Northwind Database.
    /// This class is queryable through NorthwindDB.PurchaseOrderHeader 
    /// </summary>

	public partial class PurchaseOrderHeader: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public PurchaseOrderHeader(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnPurchaseOrderIDChanging(int value);
        partial void OnPurchaseOrderIDChanged();
		
		private int _PurchaseOrderID;
		public int PurchaseOrderID { 
		    get{
		        return _PurchaseOrderID;
		    } 
		    set{
		        this.OnPurchaseOrderIDChanging(value);
                this.SendPropertyChanging();
                this._PurchaseOrderID = value;
                this.SendPropertyChanged("PurchaseOrderID");
                this.OnPurchaseOrderIDChanged();
		    }
		}
		
        partial void OnRevisionNumberChanging(byte[] value);
        partial void OnRevisionNumberChanged();
		
		private byte[] _RevisionNumber;
		public byte[] RevisionNumber { 
		    get{
		        return _RevisionNumber;
		    } 
		    set{
		        this.OnRevisionNumberChanging(value);
                this.SendPropertyChanging();
                this._RevisionNumber = value;
                this.SendPropertyChanged("RevisionNumber");
                this.OnRevisionNumberChanged();
		    }
		}
		
        partial void OnStatusChanging(byte[] value);
        partial void OnStatusChanged();
		
		private byte[] _Status;
		public byte[] Status { 
		    get{
		        return _Status;
		    } 
		    set{
		        this.OnStatusChanging(value);
                this.SendPropertyChanging();
                this._Status = value;
                this.SendPropertyChanged("Status");
                this.OnStatusChanged();
		    }
		}
		
        partial void OnEmployeeIDChanging(int value);
        partial void OnEmployeeIDChanged();
		
		private int _EmployeeID;
		public int EmployeeID { 
		    get{
		        return _EmployeeID;
		    } 
		    set{
		        this.OnEmployeeIDChanging(value);
                this.SendPropertyChanging();
                this._EmployeeID = value;
                this.SendPropertyChanged("EmployeeID");
                this.OnEmployeeIDChanged();
		    }
		}
		
        partial void OnVendorIDChanging(int value);
        partial void OnVendorIDChanged();
		
		private int _VendorID;
		public int VendorID { 
		    get{
		        return _VendorID;
		    } 
		    set{
		        this.OnVendorIDChanging(value);
                this.SendPropertyChanging();
                this._VendorID = value;
                this.SendPropertyChanged("VendorID");
                this.OnVendorIDChanged();
		    }
		}
		
        partial void OnShipMethodIDChanging(int value);
        partial void OnShipMethodIDChanged();
		
		private int _ShipMethodID;
		public int ShipMethodID { 
		    get{
		        return _ShipMethodID;
		    } 
		    set{
		        this.OnShipMethodIDChanging(value);
                this.SendPropertyChanging();
                this._ShipMethodID = value;
                this.SendPropertyChanged("ShipMethodID");
                this.OnShipMethodIDChanged();
		    }
		}
		
        partial void OnOrderDateChanging(DateTime value);
        partial void OnOrderDateChanged();
		
		private DateTime _OrderDate;
		public DateTime OrderDate { 
		    get{
		        return _OrderDate;
		    } 
		    set{
		        this.OnOrderDateChanging(value);
                this.SendPropertyChanging();
                this._OrderDate = value;
                this.SendPropertyChanged("OrderDate");
                this.OnOrderDateChanged();
		    }
		}
		
        partial void OnShipDateChanging(DateTime? value);
        partial void OnShipDateChanged();
		
		private DateTime? _ShipDate;
		public DateTime? ShipDate { 
		    get{
		        return _ShipDate;
		    } 
		    set{
		        this.OnShipDateChanging(value);
                this.SendPropertyChanging();
                this._ShipDate = value;
                this.SendPropertyChanged("ShipDate");
                this.OnShipDateChanged();
		    }
		}
		
        partial void OnSubTotalChanging(decimal value);
        partial void OnSubTotalChanged();
		
		private decimal _SubTotal;
		public decimal SubTotal { 
		    get{
		        return _SubTotal;
		    } 
		    set{
		        this.OnSubTotalChanging(value);
                this.SendPropertyChanging();
                this._SubTotal = value;
                this.SendPropertyChanged("SubTotal");
                this.OnSubTotalChanged();
		    }
		}
		
        partial void OnTaxAmtChanging(decimal value);
        partial void OnTaxAmtChanged();
		
		private decimal _TaxAmt;
		public decimal TaxAmt { 
		    get{
		        return _TaxAmt;
		    } 
		    set{
		        this.OnTaxAmtChanging(value);
                this.SendPropertyChanging();
                this._TaxAmt = value;
                this.SendPropertyChanged("TaxAmt");
                this.OnTaxAmtChanged();
		    }
		}
		
        partial void OnFreightChanging(decimal value);
        partial void OnFreightChanged();
		
		private decimal _Freight;
		public decimal Freight { 
		    get{
		        return _Freight;
		    } 
		    set{
		        this.OnFreightChanging(value);
                this.SendPropertyChanging();
                this._Freight = value;
                this.SendPropertyChanged("Freight");
                this.OnFreightChanged();
		    }
		}
		
        partial void OnTotalDueChanging(decimal value);
        partial void OnTotalDueChanged();
		
		private decimal _TotalDue;
		public decimal TotalDue { 
		    get{
		        return _TotalDue;
		    } 
		    set{
		        this.OnTotalDueChanging(value);
                this.SendPropertyChanging();
                this._TotalDue = value;
                this.SendPropertyChanged("TotalDue");
                this.OnTotalDueChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<PurchaseOrderDetail> PurchaseOrderDetails
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.PurchaseOrderDetails
                       where items.PurchaseOrderID == _PurchaseOrderID
                       select items;
            }
        }

        public IQueryable<Employee> Employees
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Employees
                       where items.EmployeeID == _EmployeeID
                       select items;
            }
        }

        public IQueryable<Vendor> Vendors
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Vendors
                       where items.VendorID == _VendorID
                       select items;
            }
        }

        public IQueryable<ShipMethod> ShipMethods
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.ShipMethods
                       where items.ShipMethodID == _ShipMethodID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the ContactCreditCard table in the Northwind Database.
    /// This class is queryable through NorthwindDB.ContactCreditCard 
    /// </summary>

	public partial class ContactCreditCard: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public ContactCreditCard(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnContactIDChanging(int value);
        partial void OnContactIDChanged();
		
		private int _ContactID;
		public int ContactID { 
		    get{
		        return _ContactID;
		    } 
		    set{
		        this.OnContactIDChanging(value);
                this.SendPropertyChanging();
                this._ContactID = value;
                this.SendPropertyChanged("ContactID");
                this.OnContactIDChanged();
		    }
		}
		
        partial void OnCreditCardIDChanging(int value);
        partial void OnCreditCardIDChanged();
		
		private int _CreditCardID;
		public int CreditCardID { 
		    get{
		        return _CreditCardID;
		    } 
		    set{
		        this.OnCreditCardIDChanging(value);
                this.SendPropertyChanging();
                this._CreditCardID = value;
                this.SendPropertyChanged("CreditCardID");
                this.OnCreditCardIDChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Contact> Contacts
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Contacts
                       where items.ContactID == _ContactID
                       select items;
            }
        }

        public IQueryable<CreditCard> CreditCards
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.CreditCards
                       where items.CreditCardID == _CreditCardID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the WorkOrder table in the Northwind Database.
    /// This class is queryable through NorthwindDB.WorkOrder 
    /// </summary>

	public partial class WorkOrder: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public WorkOrder(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnWorkOrderIDChanging(int value);
        partial void OnWorkOrderIDChanged();
		
		private int _WorkOrderID;
		public int WorkOrderID { 
		    get{
		        return _WorkOrderID;
		    } 
		    set{
		        this.OnWorkOrderIDChanging(value);
                this.SendPropertyChanging();
                this._WorkOrderID = value;
                this.SendPropertyChanged("WorkOrderID");
                this.OnWorkOrderIDChanged();
		    }
		}
		
        partial void OnProductIDChanging(int value);
        partial void OnProductIDChanged();
		
		private int _ProductID;
		public int ProductID { 
		    get{
		        return _ProductID;
		    } 
		    set{
		        this.OnProductIDChanging(value);
                this.SendPropertyChanging();
                this._ProductID = value;
                this.SendPropertyChanged("ProductID");
                this.OnProductIDChanged();
		    }
		}
		
        partial void OnOrderQtyChanging(int value);
        partial void OnOrderQtyChanged();
		
		private int _OrderQty;
		public int OrderQty { 
		    get{
		        return _OrderQty;
		    } 
		    set{
		        this.OnOrderQtyChanging(value);
                this.SendPropertyChanging();
                this._OrderQty = value;
                this.SendPropertyChanged("OrderQty");
                this.OnOrderQtyChanged();
		    }
		}
		
        partial void OnStockedQtyChanging(int value);
        partial void OnStockedQtyChanged();
		
		private int _StockedQty;
		public int StockedQty { 
		    get{
		        return _StockedQty;
		    } 
		    set{
		        this.OnStockedQtyChanging(value);
                this.SendPropertyChanging();
                this._StockedQty = value;
                this.SendPropertyChanged("StockedQty");
                this.OnStockedQtyChanged();
		    }
		}
		
        partial void OnScrappedQtyChanging(short value);
        partial void OnScrappedQtyChanged();
		
		private short _ScrappedQty;
		public short ScrappedQty { 
		    get{
		        return _ScrappedQty;
		    } 
		    set{
		        this.OnScrappedQtyChanging(value);
                this.SendPropertyChanging();
                this._ScrappedQty = value;
                this.SendPropertyChanged("ScrappedQty");
                this.OnScrappedQtyChanged();
		    }
		}
		
        partial void OnStartDateChanging(DateTime value);
        partial void OnStartDateChanged();
		
		private DateTime _StartDate;
		public DateTime StartDate { 
		    get{
		        return _StartDate;
		    } 
		    set{
		        this.OnStartDateChanging(value);
                this.SendPropertyChanging();
                this._StartDate = value;
                this.SendPropertyChanged("StartDate");
                this.OnStartDateChanged();
		    }
		}
		
        partial void OnEndDateChanging(DateTime? value);
        partial void OnEndDateChanged();
		
		private DateTime? _EndDate;
		public DateTime? EndDate { 
		    get{
		        return _EndDate;
		    } 
		    set{
		        this.OnEndDateChanging(value);
                this.SendPropertyChanging();
                this._EndDate = value;
                this.SendPropertyChanged("EndDate");
                this.OnEndDateChanged();
		    }
		}
		
        partial void OnDueDateChanging(DateTime value);
        partial void OnDueDateChanged();
		
		private DateTime _DueDate;
		public DateTime DueDate { 
		    get{
		        return _DueDate;
		    } 
		    set{
		        this.OnDueDateChanging(value);
                this.SendPropertyChanging();
                this._DueDate = value;
                this.SendPropertyChanged("DueDate");
                this.OnDueDateChanged();
		    }
		}
		
        partial void OnScrapReasonIDChanging(short? value);
        partial void OnScrapReasonIDChanged();
		
		private short? _ScrapReasonID;
		public short? ScrapReasonID { 
		    get{
		        return _ScrapReasonID;
		    } 
		    set{
		        this.OnScrapReasonIDChanging(value);
                this.SendPropertyChanging();
                this._ScrapReasonID = value;
                this.SendPropertyChanged("ScrapReasonID");
                this.OnScrapReasonIDChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Product> Products
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Products
                       where items.ProductID == _ProductID
                       select items;
            }
        }

        public IQueryable<ScrapReason> ScrapReasons
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.ScrapReasons
                       where items.ScrapReasonID == _ScrapReasonID
                       select items;
            }
        }

        public IQueryable<WorkOrderRouting> WorkOrderRoutings
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.WorkOrderRoutings
                       where items.WorkOrderID == _WorkOrderID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the ContactType table in the Northwind Database.
    /// This class is queryable through NorthwindDB.ContactType 
    /// </summary>

	public partial class ContactType: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public ContactType(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnContactTypeIDChanging(int value);
        partial void OnContactTypeIDChanged();
		
		private int _ContactTypeID;
		public int ContactTypeID { 
		    get{
		        return _ContactTypeID;
		    } 
		    set{
		        this.OnContactTypeIDChanging(value);
                this.SendPropertyChanging();
                this._ContactTypeID = value;
                this.SendPropertyChanged("ContactTypeID");
                this.OnContactTypeIDChanged();
		    }
		}
		
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
		
		private string _Name;
		public string Name { 
		    get{
		        return _Name;
		    } 
		    set{
		        this.OnNameChanging(value);
                this.SendPropertyChanging();
                this._Name = value;
                this.SendPropertyChanged("Name");
                this.OnNameChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<StoreContact> StoreContacts
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.StoreContacts
                       where items.ContactTypeID == _ContactTypeID
                       select items;
            }
        }

        public IQueryable<VendorContact> VendorContacts
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.VendorContacts
                       where items.ContactTypeID == _ContactTypeID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the CountryRegionCurrency table in the Northwind Database.
    /// This class is queryable through NorthwindDB.CountryRegionCurrency 
    /// </summary>

	public partial class CountryRegionCurrency: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public CountryRegionCurrency(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnCountryRegionCodeChanging(string value);
        partial void OnCountryRegionCodeChanged();
		
		private string _CountryRegionCode;
		public string CountryRegionCode { 
		    get{
		        return _CountryRegionCode;
		    } 
		    set{
		        this.OnCountryRegionCodeChanging(value);
                this.SendPropertyChanging();
                this._CountryRegionCode = value;
                this.SendPropertyChanged("CountryRegionCode");
                this.OnCountryRegionCodeChanged();
		    }
		}
		
        partial void OnCurrencyCodeChanging(string value);
        partial void OnCurrencyCodeChanged();
		
		private string _CurrencyCode;
		public string CurrencyCode { 
		    get{
		        return _CurrencyCode;
		    } 
		    set{
		        this.OnCurrencyCodeChanging(value);
                this.SendPropertyChanging();
                this._CurrencyCode = value;
                this.SendPropertyChanged("CurrencyCode");
                this.OnCurrencyCodeChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<CountryRegion> CountryRegions
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.CountryRegions
                       where items.CountryRegionCode == _CountryRegionCode
                       select items;
            }
        }

        public IQueryable<Currency> Currencies
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Currencies
                       where items.CurrencyCode == _CurrencyCode
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the WorkOrderRouting table in the Northwind Database.
    /// This class is queryable through NorthwindDB.WorkOrderRouting 
    /// </summary>

	public partial class WorkOrderRouting: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public WorkOrderRouting(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnWorkOrderIDChanging(int value);
        partial void OnWorkOrderIDChanged();
		
		private int _WorkOrderID;
		public int WorkOrderID { 
		    get{
		        return _WorkOrderID;
		    } 
		    set{
		        this.OnWorkOrderIDChanging(value);
                this.SendPropertyChanging();
                this._WorkOrderID = value;
                this.SendPropertyChanged("WorkOrderID");
                this.OnWorkOrderIDChanged();
		    }
		}
		
        partial void OnProductIDChanging(int value);
        partial void OnProductIDChanged();
		
		private int _ProductID;
		public int ProductID { 
		    get{
		        return _ProductID;
		    } 
		    set{
		        this.OnProductIDChanging(value);
                this.SendPropertyChanging();
                this._ProductID = value;
                this.SendPropertyChanged("ProductID");
                this.OnProductIDChanged();
		    }
		}
		
        partial void OnOperationSequenceChanging(short value);
        partial void OnOperationSequenceChanged();
		
		private short _OperationSequence;
		public short OperationSequence { 
		    get{
		        return _OperationSequence;
		    } 
		    set{
		        this.OnOperationSequenceChanging(value);
                this.SendPropertyChanging();
                this._OperationSequence = value;
                this.SendPropertyChanged("OperationSequence");
                this.OnOperationSequenceChanged();
		    }
		}
		
        partial void OnLocationIDChanging(short value);
        partial void OnLocationIDChanged();
		
		private short _LocationID;
		public short LocationID { 
		    get{
		        return _LocationID;
		    } 
		    set{
		        this.OnLocationIDChanging(value);
                this.SendPropertyChanging();
                this._LocationID = value;
                this.SendPropertyChanged("LocationID");
                this.OnLocationIDChanged();
		    }
		}
		
        partial void OnScheduledStartDateChanging(DateTime value);
        partial void OnScheduledStartDateChanged();
		
		private DateTime _ScheduledStartDate;
		public DateTime ScheduledStartDate { 
		    get{
		        return _ScheduledStartDate;
		    } 
		    set{
		        this.OnScheduledStartDateChanging(value);
                this.SendPropertyChanging();
                this._ScheduledStartDate = value;
                this.SendPropertyChanged("ScheduledStartDate");
                this.OnScheduledStartDateChanged();
		    }
		}
		
        partial void OnScheduledEndDateChanging(DateTime value);
        partial void OnScheduledEndDateChanged();
		
		private DateTime _ScheduledEndDate;
		public DateTime ScheduledEndDate { 
		    get{
		        return _ScheduledEndDate;
		    } 
		    set{
		        this.OnScheduledEndDateChanging(value);
                this.SendPropertyChanging();
                this._ScheduledEndDate = value;
                this.SendPropertyChanged("ScheduledEndDate");
                this.OnScheduledEndDateChanged();
		    }
		}
		
        partial void OnActualStartDateChanging(DateTime? value);
        partial void OnActualStartDateChanged();
		
		private DateTime? _ActualStartDate;
		public DateTime? ActualStartDate { 
		    get{
		        return _ActualStartDate;
		    } 
		    set{
		        this.OnActualStartDateChanging(value);
                this.SendPropertyChanging();
                this._ActualStartDate = value;
                this.SendPropertyChanged("ActualStartDate");
                this.OnActualStartDateChanged();
		    }
		}
		
        partial void OnActualEndDateChanging(DateTime? value);
        partial void OnActualEndDateChanged();
		
		private DateTime? _ActualEndDate;
		public DateTime? ActualEndDate { 
		    get{
		        return _ActualEndDate;
		    } 
		    set{
		        this.OnActualEndDateChanging(value);
                this.SendPropertyChanging();
                this._ActualEndDate = value;
                this.SendPropertyChanged("ActualEndDate");
                this.OnActualEndDateChanged();
		    }
		}
		
        partial void OnActualResourceHrsChanging(decimal? value);
        partial void OnActualResourceHrsChanged();
		
		private decimal? _ActualResourceHrs;
		public decimal? ActualResourceHrs { 
		    get{
		        return _ActualResourceHrs;
		    } 
		    set{
		        this.OnActualResourceHrsChanging(value);
                this.SendPropertyChanging();
                this._ActualResourceHrs = value;
                this.SendPropertyChanged("ActualResourceHrs");
                this.OnActualResourceHrsChanged();
		    }
		}
		
        partial void OnPlannedCostChanging(decimal value);
        partial void OnPlannedCostChanged();
		
		private decimal _PlannedCost;
		public decimal PlannedCost { 
		    get{
		        return _PlannedCost;
		    } 
		    set{
		        this.OnPlannedCostChanging(value);
                this.SendPropertyChanging();
                this._PlannedCost = value;
                this.SendPropertyChanged("PlannedCost");
                this.OnPlannedCostChanged();
		    }
		}
		
        partial void OnActualCostChanging(decimal? value);
        partial void OnActualCostChanged();
		
		private decimal? _ActualCost;
		public decimal? ActualCost { 
		    get{
		        return _ActualCost;
		    } 
		    set{
		        this.OnActualCostChanging(value);
                this.SendPropertyChanging();
                this._ActualCost = value;
                this.SendPropertyChanged("ActualCost");
                this.OnActualCostChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Location> Locations
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Locations
                       where items.LocationID == _LocationID
                       select items;
            }
        }

        public IQueryable<WorkOrder> WorkOrders
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.WorkOrders
                       where items.WorkOrderID == _WorkOrderID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the CountryRegion table in the Northwind Database.
    /// This class is queryable through NorthwindDB.CountryRegion 
    /// </summary>

	public partial class CountryRegion: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public CountryRegion(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnCountryRegionCodeChanging(string value);
        partial void OnCountryRegionCodeChanged();
		
		private string _CountryRegionCode;
		public string CountryRegionCode { 
		    get{
		        return _CountryRegionCode;
		    } 
		    set{
		        this.OnCountryRegionCodeChanging(value);
                this.SendPropertyChanging();
                this._CountryRegionCode = value;
                this.SendPropertyChanged("CountryRegionCode");
                this.OnCountryRegionCodeChanged();
		    }
		}
		
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
		
		private string _Name;
		public string Name { 
		    get{
		        return _Name;
		    } 
		    set{
		        this.OnNameChanging(value);
                this.SendPropertyChanging();
                this._Name = value;
                this.SendPropertyChanged("Name");
                this.OnNameChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<StateProvince> StateProvinces
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.StateProvinces
                       where items.CountryRegionCode == _CountryRegionCode
                       select items;
            }
        }

        public IQueryable<CountryRegionCurrency> CountryRegionCurrencies
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.CountryRegionCurrencies
                       where items.CountryRegionCode == _CountryRegionCode
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the CreditCard table in the Northwind Database.
    /// This class is queryable through NorthwindDB.CreditCard 
    /// </summary>

	public partial class CreditCard: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public CreditCard(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnCreditCardIDChanging(int value);
        partial void OnCreditCardIDChanged();
		
		private int _CreditCardID;
		public int CreditCardID { 
		    get{
		        return _CreditCardID;
		    } 
		    set{
		        this.OnCreditCardIDChanging(value);
                this.SendPropertyChanging();
                this._CreditCardID = value;
                this.SendPropertyChanged("CreditCardID");
                this.OnCreditCardIDChanged();
		    }
		}
		
        partial void OnCardTypeChanging(string value);
        partial void OnCardTypeChanged();
		
		private string _CardType;
		public string CardType { 
		    get{
		        return _CardType;
		    } 
		    set{
		        this.OnCardTypeChanging(value);
                this.SendPropertyChanging();
                this._CardType = value;
                this.SendPropertyChanged("CardType");
                this.OnCardTypeChanged();
		    }
		}
		
        partial void OnCardNumberChanging(string value);
        partial void OnCardNumberChanged();
		
		private string _CardNumber;
		public string CardNumber { 
		    get{
		        return _CardNumber;
		    } 
		    set{
		        this.OnCardNumberChanging(value);
                this.SendPropertyChanging();
                this._CardNumber = value;
                this.SendPropertyChanged("CardNumber");
                this.OnCardNumberChanged();
		    }
		}
		
        partial void OnExpMonthChanging(byte[] value);
        partial void OnExpMonthChanged();
		
		private byte[] _ExpMonth;
		public byte[] ExpMonth { 
		    get{
		        return _ExpMonth;
		    } 
		    set{
		        this.OnExpMonthChanging(value);
                this.SendPropertyChanging();
                this._ExpMonth = value;
                this.SendPropertyChanged("ExpMonth");
                this.OnExpMonthChanged();
		    }
		}
		
        partial void OnExpYearChanging(short value);
        partial void OnExpYearChanged();
		
		private short _ExpYear;
		public short ExpYear { 
		    get{
		        return _ExpYear;
		    } 
		    set{
		        this.OnExpYearChanging(value);
                this.SendPropertyChanging();
                this._ExpYear = value;
                this.SendPropertyChanged("ExpYear");
                this.OnExpYearChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<SalesOrderHeader> SalesOrderHeaders
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SalesOrderHeaders
                       where items.CreditCardID == _CreditCardID
                       select items;
            }
        }

        public IQueryable<ContactCreditCard> ContactCreditCards
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.ContactCreditCards
                       where items.CreditCardID == _CreditCardID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the Culture table in the Northwind Database.
    /// This class is queryable through NorthwindDB.Culture 
    /// </summary>

	public partial class Culture: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public Culture(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnCultureIDChanging(string value);
        partial void OnCultureIDChanged();
		
		private string _CultureID;
		public string CultureID { 
		    get{
		        return _CultureID;
		    } 
		    set{
		        this.OnCultureIDChanging(value);
                this.SendPropertyChanging();
                this._CultureID = value;
                this.SendPropertyChanged("CultureID");
                this.OnCultureIDChanged();
		    }
		}
		
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
		
		private string _Name;
		public string Name { 
		    get{
		        return _Name;
		    } 
		    set{
		        this.OnNameChanging(value);
                this.SendPropertyChanging();
                this._Name = value;
                this.SendPropertyChanged("Name");
                this.OnNameChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.ProductModelProductDescriptionCultures
                       where items.CultureID == _CultureID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the Currency table in the Northwind Database.
    /// This class is queryable through NorthwindDB.Currency 
    /// </summary>

	public partial class Currency: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public Currency(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnCurrencyCodeChanging(string value);
        partial void OnCurrencyCodeChanged();
		
		private string _CurrencyCode;
		public string CurrencyCode { 
		    get{
		        return _CurrencyCode;
		    } 
		    set{
		        this.OnCurrencyCodeChanging(value);
                this.SendPropertyChanging();
                this._CurrencyCode = value;
                this.SendPropertyChanged("CurrencyCode");
                this.OnCurrencyCodeChanged();
		    }
		}
		
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
		
		private string _Name;
		public string Name { 
		    get{
		        return _Name;
		    } 
		    set{
		        this.OnNameChanging(value);
                this.SendPropertyChanging();
                this._Name = value;
                this.SendPropertyChanged("Name");
                this.OnNameChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<CountryRegionCurrency> CountryRegionCurrencies
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.CountryRegionCurrencies
                       where items.CurrencyCode == _CurrencyCode
                       select items;
            }
        }

        public IQueryable<CurrencyRate> CurrencyRates
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.CurrencyRates
                       where items.FromCurrencyCode == _CurrencyCode
                       select items;
            }
        }

        public IQueryable<CurrencyRate> CurrencyRates2
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.CurrencyRates
                       where items.ToCurrencyCode == _CurrencyCode
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the SalesOrderDetail table in the Northwind Database.
    /// This class is queryable through NorthwindDB.SalesOrderDetail 
    /// </summary>

	public partial class SalesOrderDetail: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public SalesOrderDetail(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnSalesOrderIDChanging(int value);
        partial void OnSalesOrderIDChanged();
		
		private int _SalesOrderID;
		public int SalesOrderID { 
		    get{
		        return _SalesOrderID;
		    } 
		    set{
		        this.OnSalesOrderIDChanging(value);
                this.SendPropertyChanging();
                this._SalesOrderID = value;
                this.SendPropertyChanged("SalesOrderID");
                this.OnSalesOrderIDChanged();
		    }
		}
		
        partial void OnSalesOrderDetailIDChanging(int value);
        partial void OnSalesOrderDetailIDChanged();
		
		private int _SalesOrderDetailID;
		public int SalesOrderDetailID { 
		    get{
		        return _SalesOrderDetailID;
		    } 
		    set{
		        this.OnSalesOrderDetailIDChanging(value);
                this.SendPropertyChanging();
                this._SalesOrderDetailID = value;
                this.SendPropertyChanged("SalesOrderDetailID");
                this.OnSalesOrderDetailIDChanged();
		    }
		}
		
        partial void OnCarrierTrackingNumberChanging(string value);
        partial void OnCarrierTrackingNumberChanged();
		
		private string _CarrierTrackingNumber;
		public string CarrierTrackingNumber { 
		    get{
		        return _CarrierTrackingNumber;
		    } 
		    set{
		        this.OnCarrierTrackingNumberChanging(value);
                this.SendPropertyChanging();
                this._CarrierTrackingNumber = value;
                this.SendPropertyChanged("CarrierTrackingNumber");
                this.OnCarrierTrackingNumberChanged();
		    }
		}
		
        partial void OnOrderQtyChanging(short value);
        partial void OnOrderQtyChanged();
		
		private short _OrderQty;
		public short OrderQty { 
		    get{
		        return _OrderQty;
		    } 
		    set{
		        this.OnOrderQtyChanging(value);
                this.SendPropertyChanging();
                this._OrderQty = value;
                this.SendPropertyChanged("OrderQty");
                this.OnOrderQtyChanged();
		    }
		}
		
        partial void OnProductIDChanging(int value);
        partial void OnProductIDChanged();
		
		private int _ProductID;
		public int ProductID { 
		    get{
		        return _ProductID;
		    } 
		    set{
		        this.OnProductIDChanging(value);
                this.SendPropertyChanging();
                this._ProductID = value;
                this.SendPropertyChanged("ProductID");
                this.OnProductIDChanged();
		    }
		}
		
        partial void OnSpecialOfferIDChanging(int value);
        partial void OnSpecialOfferIDChanged();
		
		private int _SpecialOfferID;
		public int SpecialOfferID { 
		    get{
		        return _SpecialOfferID;
		    } 
		    set{
		        this.OnSpecialOfferIDChanging(value);
                this.SendPropertyChanging();
                this._SpecialOfferID = value;
                this.SendPropertyChanged("SpecialOfferID");
                this.OnSpecialOfferIDChanged();
		    }
		}
		
        partial void OnUnitPriceChanging(decimal value);
        partial void OnUnitPriceChanged();
		
		private decimal _UnitPrice;
		public decimal UnitPrice { 
		    get{
		        return _UnitPrice;
		    } 
		    set{
		        this.OnUnitPriceChanging(value);
                this.SendPropertyChanging();
                this._UnitPrice = value;
                this.SendPropertyChanged("UnitPrice");
                this.OnUnitPriceChanged();
		    }
		}
		
        partial void OnUnitPriceDiscountChanging(decimal value);
        partial void OnUnitPriceDiscountChanged();
		
		private decimal _UnitPriceDiscount;
		public decimal UnitPriceDiscount { 
		    get{
		        return _UnitPriceDiscount;
		    } 
		    set{
		        this.OnUnitPriceDiscountChanging(value);
                this.SendPropertyChanging();
                this._UnitPriceDiscount = value;
                this.SendPropertyChanged("UnitPriceDiscount");
                this.OnUnitPriceDiscountChanged();
		    }
		}
		
        partial void OnLineTotalChanging(decimal value);
        partial void OnLineTotalChanged();
		
		private decimal _LineTotal;
		public decimal LineTotal { 
		    get{
		        return _LineTotal;
		    } 
		    set{
		        this.OnLineTotalChanging(value);
                this.SendPropertyChanging();
                this._LineTotal = value;
                this.SendPropertyChanged("LineTotal");
                this.OnLineTotalChanged();
		    }
		}
		
        partial void OnrowguidChanging(Guid value);
        partial void OnrowguidChanged();
		
		private Guid _rowguid;
		public Guid rowguid { 
		    get{
		        return _rowguid;
		    } 
		    set{
		        this.OnrowguidChanging(value);
                this.SendPropertyChanging();
                this._rowguid = value;
                this.SendPropertyChanged("rowguid");
                this.OnrowguidChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<SalesOrderHeader> SalesOrderHeaders
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SalesOrderHeaders
                       where items.SalesOrderID == _SalesOrderID
                       select items;
            }
        }

        public IQueryable<SpecialOfferProduct> SpecialOfferProducts
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SpecialOfferProducts
                       where items.ProductID == _ProductID
                       select items;
            }
        }

        public IQueryable<SpecialOfferProduct> SpecialOfferProducts2
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SpecialOfferProducts
                       where items.SpecialOfferID == _ProductID
                       select items;
            }
        }

        public IQueryable<SpecialOfferProduct> SpecialOfferProducts3
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SpecialOfferProducts
                       where items.ProductID == _SpecialOfferID
                       select items;
            }
        }

        public IQueryable<SpecialOfferProduct> SpecialOfferProducts4
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SpecialOfferProducts
                       where items.SpecialOfferID == _SpecialOfferID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the CurrencyRate table in the Northwind Database.
    /// This class is queryable through NorthwindDB.CurrencyRate 
    /// </summary>

	public partial class CurrencyRate: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public CurrencyRate(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnCurrencyRateIDChanging(int value);
        partial void OnCurrencyRateIDChanged();
		
		private int _CurrencyRateID;
		public int CurrencyRateID { 
		    get{
		        return _CurrencyRateID;
		    } 
		    set{
		        this.OnCurrencyRateIDChanging(value);
                this.SendPropertyChanging();
                this._CurrencyRateID = value;
                this.SendPropertyChanged("CurrencyRateID");
                this.OnCurrencyRateIDChanged();
		    }
		}
		
        partial void OnCurrencyRateDateChanging(DateTime value);
        partial void OnCurrencyRateDateChanged();
		
		private DateTime _CurrencyRateDate;
		public DateTime CurrencyRateDate { 
		    get{
		        return _CurrencyRateDate;
		    } 
		    set{
		        this.OnCurrencyRateDateChanging(value);
                this.SendPropertyChanging();
                this._CurrencyRateDate = value;
                this.SendPropertyChanged("CurrencyRateDate");
                this.OnCurrencyRateDateChanged();
		    }
		}
		
        partial void OnFromCurrencyCodeChanging(string value);
        partial void OnFromCurrencyCodeChanged();
		
		private string _FromCurrencyCode;
		public string FromCurrencyCode { 
		    get{
		        return _FromCurrencyCode;
		    } 
		    set{
		        this.OnFromCurrencyCodeChanging(value);
                this.SendPropertyChanging();
                this._FromCurrencyCode = value;
                this.SendPropertyChanged("FromCurrencyCode");
                this.OnFromCurrencyCodeChanged();
		    }
		}
		
        partial void OnToCurrencyCodeChanging(string value);
        partial void OnToCurrencyCodeChanged();
		
		private string _ToCurrencyCode;
		public string ToCurrencyCode { 
		    get{
		        return _ToCurrencyCode;
		    } 
		    set{
		        this.OnToCurrencyCodeChanging(value);
                this.SendPropertyChanging();
                this._ToCurrencyCode = value;
                this.SendPropertyChanged("ToCurrencyCode");
                this.OnToCurrencyCodeChanged();
		    }
		}
		
        partial void OnAverageRateChanging(decimal value);
        partial void OnAverageRateChanged();
		
		private decimal _AverageRate;
		public decimal AverageRate { 
		    get{
		        return _AverageRate;
		    } 
		    set{
		        this.OnAverageRateChanging(value);
                this.SendPropertyChanging();
                this._AverageRate = value;
                this.SendPropertyChanged("AverageRate");
                this.OnAverageRateChanged();
		    }
		}
		
        partial void OnEndOfDayRateChanging(decimal value);
        partial void OnEndOfDayRateChanged();
		
		private decimal _EndOfDayRate;
		public decimal EndOfDayRate { 
		    get{
		        return _EndOfDayRate;
		    } 
		    set{
		        this.OnEndOfDayRateChanging(value);
                this.SendPropertyChanging();
                this._EndOfDayRate = value;
                this.SendPropertyChanged("EndOfDayRate");
                this.OnEndOfDayRateChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<SalesOrderHeader> SalesOrderHeaders
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SalesOrderHeaders
                       where items.CurrencyRateID == _CurrencyRateID
                       select items;
            }
        }

        public IQueryable<Currency> Currencies
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Currencies
                       where items.CurrencyCode == _FromCurrencyCode
                       select items;
            }
        }

        public IQueryable<Currency> Currencies2
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Currencies
                       where items.CurrencyCode == _ToCurrencyCode
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the Customer table in the Northwind Database.
    /// This class is queryable through NorthwindDB.Customer 
    /// </summary>

	public partial class Customer: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public Customer(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnCustomerIDChanging(int value);
        partial void OnCustomerIDChanged();
		
		private int _CustomerID;
		public int CustomerID { 
		    get{
		        return _CustomerID;
		    } 
		    set{
		        this.OnCustomerIDChanging(value);
                this.SendPropertyChanging();
                this._CustomerID = value;
                this.SendPropertyChanged("CustomerID");
                this.OnCustomerIDChanged();
		    }
		}
		
        partial void OnTerritoryIDChanging(int? value);
        partial void OnTerritoryIDChanged();
		
		private int? _TerritoryID;
		public int? TerritoryID { 
		    get{
		        return _TerritoryID;
		    } 
		    set{
		        this.OnTerritoryIDChanging(value);
                this.SendPropertyChanging();
                this._TerritoryID = value;
                this.SendPropertyChanged("TerritoryID");
                this.OnTerritoryIDChanged();
		    }
		}
		
        partial void OnAccountNumberChanging(string value);
        partial void OnAccountNumberChanged();
		
		private string _AccountNumber;
		public string AccountNumber { 
		    get{
		        return _AccountNumber;
		    } 
		    set{
		        this.OnAccountNumberChanging(value);
                this.SendPropertyChanging();
                this._AccountNumber = value;
                this.SendPropertyChanged("AccountNumber");
                this.OnAccountNumberChanged();
		    }
		}
		
        partial void OnCustomerTypeChanging(string value);
        partial void OnCustomerTypeChanged();
		
		private string _CustomerType;
		public string CustomerType { 
		    get{
		        return _CustomerType;
		    } 
		    set{
		        this.OnCustomerTypeChanging(value);
                this.SendPropertyChanging();
                this._CustomerType = value;
                this.SendPropertyChanged("CustomerType");
                this.OnCustomerTypeChanged();
		    }
		}
		
        partial void OnrowguidChanging(Guid value);
        partial void OnrowguidChanged();
		
		private Guid _rowguid;
		public Guid rowguid { 
		    get{
		        return _rowguid;
		    } 
		    set{
		        this.OnrowguidChanging(value);
                this.SendPropertyChanging();
                this._rowguid = value;
                this.SendPropertyChanged("rowguid");
                this.OnrowguidChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<SalesOrderHeader> SalesOrderHeaders
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SalesOrderHeaders
                       where items.CustomerID == _CustomerID
                       select items;
            }
        }

        public IQueryable<Store> Stores
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Stores
                       where items.CustomerID == _CustomerID
                       select items;
            }
        }

        public IQueryable<SalesTerritory> SalesTerritories
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SalesTerritories
                       where items.TerritoryID == _TerritoryID
                       select items;
            }
        }

        public IQueryable<CustomerAddress> CustomerAddresses
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.CustomerAddresses
                       where items.CustomerID == _CustomerID
                       select items;
            }
        }

        public IQueryable<Individual> Individuals
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Individuals
                       where items.CustomerID == _CustomerID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the SalesOrderHeader table in the Northwind Database.
    /// This class is queryable through NorthwindDB.SalesOrderHeader 
    /// </summary>

	public partial class SalesOrderHeader: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public SalesOrderHeader(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnSalesOrderIDChanging(int value);
        partial void OnSalesOrderIDChanged();
		
		private int _SalesOrderID;
		public int SalesOrderID { 
		    get{
		        return _SalesOrderID;
		    } 
		    set{
		        this.OnSalesOrderIDChanging(value);
                this.SendPropertyChanging();
                this._SalesOrderID = value;
                this.SendPropertyChanged("SalesOrderID");
                this.OnSalesOrderIDChanged();
		    }
		}
		
        partial void OnRevisionNumberChanging(byte[] value);
        partial void OnRevisionNumberChanged();
		
		private byte[] _RevisionNumber;
		public byte[] RevisionNumber { 
		    get{
		        return _RevisionNumber;
		    } 
		    set{
		        this.OnRevisionNumberChanging(value);
                this.SendPropertyChanging();
                this._RevisionNumber = value;
                this.SendPropertyChanged("RevisionNumber");
                this.OnRevisionNumberChanged();
		    }
		}
		
        partial void OnOrderDateChanging(DateTime value);
        partial void OnOrderDateChanged();
		
		private DateTime _OrderDate;
		public DateTime OrderDate { 
		    get{
		        return _OrderDate;
		    } 
		    set{
		        this.OnOrderDateChanging(value);
                this.SendPropertyChanging();
                this._OrderDate = value;
                this.SendPropertyChanged("OrderDate");
                this.OnOrderDateChanged();
		    }
		}
		
        partial void OnDueDateChanging(DateTime value);
        partial void OnDueDateChanged();
		
		private DateTime _DueDate;
		public DateTime DueDate { 
		    get{
		        return _DueDate;
		    } 
		    set{
		        this.OnDueDateChanging(value);
                this.SendPropertyChanging();
                this._DueDate = value;
                this.SendPropertyChanged("DueDate");
                this.OnDueDateChanged();
		    }
		}
		
        partial void OnShipDateChanging(DateTime? value);
        partial void OnShipDateChanged();
		
		private DateTime? _ShipDate;
		public DateTime? ShipDate { 
		    get{
		        return _ShipDate;
		    } 
		    set{
		        this.OnShipDateChanging(value);
                this.SendPropertyChanging();
                this._ShipDate = value;
                this.SendPropertyChanged("ShipDate");
                this.OnShipDateChanged();
		    }
		}
		
        partial void OnStatusChanging(byte[] value);
        partial void OnStatusChanged();
		
		private byte[] _Status;
		public byte[] Status { 
		    get{
		        return _Status;
		    } 
		    set{
		        this.OnStatusChanging(value);
                this.SendPropertyChanging();
                this._Status = value;
                this.SendPropertyChanged("Status");
                this.OnStatusChanged();
		    }
		}
		
        partial void OnOnlineOrderFlagChanging(bool value);
        partial void OnOnlineOrderFlagChanged();
		
		private bool _OnlineOrderFlag;
		public bool OnlineOrderFlag { 
		    get{
		        return _OnlineOrderFlag;
		    } 
		    set{
		        this.OnOnlineOrderFlagChanging(value);
                this.SendPropertyChanging();
                this._OnlineOrderFlag = value;
                this.SendPropertyChanged("OnlineOrderFlag");
                this.OnOnlineOrderFlagChanged();
		    }
		}
		
        partial void OnSalesOrderNumberChanging(string value);
        partial void OnSalesOrderNumberChanged();
		
		private string _SalesOrderNumber;
		public string SalesOrderNumber { 
		    get{
		        return _SalesOrderNumber;
		    } 
		    set{
		        this.OnSalesOrderNumberChanging(value);
                this.SendPropertyChanging();
                this._SalesOrderNumber = value;
                this.SendPropertyChanged("SalesOrderNumber");
                this.OnSalesOrderNumberChanged();
		    }
		}
		
        partial void OnPurchaseOrderNumberChanging(string value);
        partial void OnPurchaseOrderNumberChanged();
		
		private string _PurchaseOrderNumber;
		public string PurchaseOrderNumber { 
		    get{
		        return _PurchaseOrderNumber;
		    } 
		    set{
		        this.OnPurchaseOrderNumberChanging(value);
                this.SendPropertyChanging();
                this._PurchaseOrderNumber = value;
                this.SendPropertyChanged("PurchaseOrderNumber");
                this.OnPurchaseOrderNumberChanged();
		    }
		}
		
        partial void OnAccountNumberChanging(string value);
        partial void OnAccountNumberChanged();
		
		private string _AccountNumber;
		public string AccountNumber { 
		    get{
		        return _AccountNumber;
		    } 
		    set{
		        this.OnAccountNumberChanging(value);
                this.SendPropertyChanging();
                this._AccountNumber = value;
                this.SendPropertyChanged("AccountNumber");
                this.OnAccountNumberChanged();
		    }
		}
		
        partial void OnCustomerIDChanging(int value);
        partial void OnCustomerIDChanged();
		
		private int _CustomerID;
		public int CustomerID { 
		    get{
		        return _CustomerID;
		    } 
		    set{
		        this.OnCustomerIDChanging(value);
                this.SendPropertyChanging();
                this._CustomerID = value;
                this.SendPropertyChanged("CustomerID");
                this.OnCustomerIDChanged();
		    }
		}
		
        partial void OnContactIDChanging(int value);
        partial void OnContactIDChanged();
		
		private int _ContactID;
		public int ContactID { 
		    get{
		        return _ContactID;
		    } 
		    set{
		        this.OnContactIDChanging(value);
                this.SendPropertyChanging();
                this._ContactID = value;
                this.SendPropertyChanged("ContactID");
                this.OnContactIDChanged();
		    }
		}
		
        partial void OnSalesPersonIDChanging(int? value);
        partial void OnSalesPersonIDChanged();
		
		private int? _SalesPersonID;
		public int? SalesPersonID { 
		    get{
		        return _SalesPersonID;
		    } 
		    set{
		        this.OnSalesPersonIDChanging(value);
                this.SendPropertyChanging();
                this._SalesPersonID = value;
                this.SendPropertyChanged("SalesPersonID");
                this.OnSalesPersonIDChanged();
		    }
		}
		
        partial void OnTerritoryIDChanging(int? value);
        partial void OnTerritoryIDChanged();
		
		private int? _TerritoryID;
		public int? TerritoryID { 
		    get{
		        return _TerritoryID;
		    } 
		    set{
		        this.OnTerritoryIDChanging(value);
                this.SendPropertyChanging();
                this._TerritoryID = value;
                this.SendPropertyChanged("TerritoryID");
                this.OnTerritoryIDChanged();
		    }
		}
		
        partial void OnBillToAddressIDChanging(int value);
        partial void OnBillToAddressIDChanged();
		
		private int _BillToAddressID;
		public int BillToAddressID { 
		    get{
		        return _BillToAddressID;
		    } 
		    set{
		        this.OnBillToAddressIDChanging(value);
                this.SendPropertyChanging();
                this._BillToAddressID = value;
                this.SendPropertyChanged("BillToAddressID");
                this.OnBillToAddressIDChanged();
		    }
		}
		
        partial void OnShipToAddressIDChanging(int value);
        partial void OnShipToAddressIDChanged();
		
		private int _ShipToAddressID;
		public int ShipToAddressID { 
		    get{
		        return _ShipToAddressID;
		    } 
		    set{
		        this.OnShipToAddressIDChanging(value);
                this.SendPropertyChanging();
                this._ShipToAddressID = value;
                this.SendPropertyChanged("ShipToAddressID");
                this.OnShipToAddressIDChanged();
		    }
		}
		
        partial void OnShipMethodIDChanging(int value);
        partial void OnShipMethodIDChanged();
		
		private int _ShipMethodID;
		public int ShipMethodID { 
		    get{
		        return _ShipMethodID;
		    } 
		    set{
		        this.OnShipMethodIDChanging(value);
                this.SendPropertyChanging();
                this._ShipMethodID = value;
                this.SendPropertyChanged("ShipMethodID");
                this.OnShipMethodIDChanged();
		    }
		}
		
        partial void OnCreditCardIDChanging(int? value);
        partial void OnCreditCardIDChanged();
		
		private int? _CreditCardID;
		public int? CreditCardID { 
		    get{
		        return _CreditCardID;
		    } 
		    set{
		        this.OnCreditCardIDChanging(value);
                this.SendPropertyChanging();
                this._CreditCardID = value;
                this.SendPropertyChanged("CreditCardID");
                this.OnCreditCardIDChanged();
		    }
		}
		
        partial void OnCreditCardApprovalCodeChanging(string value);
        partial void OnCreditCardApprovalCodeChanged();
		
		private string _CreditCardApprovalCode;
		public string CreditCardApprovalCode { 
		    get{
		        return _CreditCardApprovalCode;
		    } 
		    set{
		        this.OnCreditCardApprovalCodeChanging(value);
                this.SendPropertyChanging();
                this._CreditCardApprovalCode = value;
                this.SendPropertyChanged("CreditCardApprovalCode");
                this.OnCreditCardApprovalCodeChanged();
		    }
		}
		
        partial void OnCurrencyRateIDChanging(int? value);
        partial void OnCurrencyRateIDChanged();
		
		private int? _CurrencyRateID;
		public int? CurrencyRateID { 
		    get{
		        return _CurrencyRateID;
		    } 
		    set{
		        this.OnCurrencyRateIDChanging(value);
                this.SendPropertyChanging();
                this._CurrencyRateID = value;
                this.SendPropertyChanged("CurrencyRateID");
                this.OnCurrencyRateIDChanged();
		    }
		}
		
        partial void OnSubTotalChanging(decimal value);
        partial void OnSubTotalChanged();
		
		private decimal _SubTotal;
		public decimal SubTotal { 
		    get{
		        return _SubTotal;
		    } 
		    set{
		        this.OnSubTotalChanging(value);
                this.SendPropertyChanging();
                this._SubTotal = value;
                this.SendPropertyChanged("SubTotal");
                this.OnSubTotalChanged();
		    }
		}
		
        partial void OnTaxAmtChanging(decimal value);
        partial void OnTaxAmtChanged();
		
		private decimal _TaxAmt;
		public decimal TaxAmt { 
		    get{
		        return _TaxAmt;
		    } 
		    set{
		        this.OnTaxAmtChanging(value);
                this.SendPropertyChanging();
                this._TaxAmt = value;
                this.SendPropertyChanged("TaxAmt");
                this.OnTaxAmtChanged();
		    }
		}
		
        partial void OnFreightChanging(decimal value);
        partial void OnFreightChanged();
		
		private decimal _Freight;
		public decimal Freight { 
		    get{
		        return _Freight;
		    } 
		    set{
		        this.OnFreightChanging(value);
                this.SendPropertyChanging();
                this._Freight = value;
                this.SendPropertyChanged("Freight");
                this.OnFreightChanged();
		    }
		}
		
        partial void OnTotalDueChanging(decimal value);
        partial void OnTotalDueChanged();
		
		private decimal _TotalDue;
		public decimal TotalDue { 
		    get{
		        return _TotalDue;
		    } 
		    set{
		        this.OnTotalDueChanging(value);
                this.SendPropertyChanging();
                this._TotalDue = value;
                this.SendPropertyChanged("TotalDue");
                this.OnTotalDueChanged();
		    }
		}
		
        partial void OnCommentChanging(string value);
        partial void OnCommentChanged();
		
		private string _Comment;
		public string Comment { 
		    get{
		        return _Comment;
		    } 
		    set{
		        this.OnCommentChanging(value);
                this.SendPropertyChanging();
                this._Comment = value;
                this.SendPropertyChanged("Comment");
                this.OnCommentChanged();
		    }
		}
		
        partial void OnrowguidChanging(Guid value);
        partial void OnrowguidChanged();
		
		private Guid _rowguid;
		public Guid rowguid { 
		    get{
		        return _rowguid;
		    } 
		    set{
		        this.OnrowguidChanging(value);
                this.SendPropertyChanging();
                this._rowguid = value;
                this.SendPropertyChanged("rowguid");
                this.OnrowguidChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<SalesOrderDetail> SalesOrderDetails
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SalesOrderDetails
                       where items.SalesOrderID == _SalesOrderID
                       select items;
            }
        }

        public IQueryable<Address> Addresses
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Addresses
                       where items.AddressID == _BillToAddressID
                       select items;
            }
        }

        public IQueryable<Address> Addresses2
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Addresses
                       where items.AddressID == _ShipToAddressID
                       select items;
            }
        }

        public IQueryable<Contact> Contacts
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Contacts
                       where items.ContactID == _ContactID
                       select items;
            }
        }

        public IQueryable<CreditCard> CreditCards
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.CreditCards
                       where items.CreditCardID == _CreditCardID
                       select items;
            }
        }

        public IQueryable<CurrencyRate> CurrencyRates
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.CurrencyRates
                       where items.CurrencyRateID == _CurrencyRateID
                       select items;
            }
        }

        public IQueryable<Customer> Customers
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Customers
                       where items.CustomerID == _CustomerID
                       select items;
            }
        }

        public IQueryable<SalesPerson> SalesPeople
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SalesPeople
                       where items.SalesPersonID == _SalesPersonID
                       select items;
            }
        }

        public IQueryable<ShipMethod> ShipMethods
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.ShipMethods
                       where items.ShipMethodID == _ShipMethodID
                       select items;
            }
        }

        public IQueryable<SalesTerritory> SalesTerritories
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SalesTerritories
                       where items.TerritoryID == _TerritoryID
                       select items;
            }
        }

        public IQueryable<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SalesOrderHeaderSalesReasons
                       where items.SalesOrderID == _SalesOrderID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the CustomerAddress table in the Northwind Database.
    /// This class is queryable through NorthwindDB.CustomerAddress 
    /// </summary>

	public partial class CustomerAddress: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public CustomerAddress(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnCustomerIDChanging(int value);
        partial void OnCustomerIDChanged();
		
		private int _CustomerID;
		public int CustomerID { 
		    get{
		        return _CustomerID;
		    } 
		    set{
		        this.OnCustomerIDChanging(value);
                this.SendPropertyChanging();
                this._CustomerID = value;
                this.SendPropertyChanged("CustomerID");
                this.OnCustomerIDChanged();
		    }
		}
		
        partial void OnAddressIDChanging(int value);
        partial void OnAddressIDChanged();
		
		private int _AddressID;
		public int AddressID { 
		    get{
		        return _AddressID;
		    } 
		    set{
		        this.OnAddressIDChanging(value);
                this.SendPropertyChanging();
                this._AddressID = value;
                this.SendPropertyChanged("AddressID");
                this.OnAddressIDChanged();
		    }
		}
		
        partial void OnAddressTypeIDChanging(int value);
        partial void OnAddressTypeIDChanged();
		
		private int _AddressTypeID;
		public int AddressTypeID { 
		    get{
		        return _AddressTypeID;
		    } 
		    set{
		        this.OnAddressTypeIDChanging(value);
                this.SendPropertyChanging();
                this._AddressTypeID = value;
                this.SendPropertyChanged("AddressTypeID");
                this.OnAddressTypeIDChanged();
		    }
		}
		
        partial void OnrowguidChanging(Guid value);
        partial void OnrowguidChanged();
		
		private Guid _rowguid;
		public Guid rowguid { 
		    get{
		        return _rowguid;
		    } 
		    set{
		        this.OnrowguidChanging(value);
                this.SendPropertyChanging();
                this._rowguid = value;
                this.SendPropertyChanged("rowguid");
                this.OnrowguidChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Address> Addresses
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Addresses
                       where items.AddressID == _AddressID
                       select items;
            }
        }

        public IQueryable<AddressType> AddressTypes
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.AddressTypes
                       where items.AddressTypeID == _AddressTypeID
                       select items;
            }
        }

        public IQueryable<Customer> Customers
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Customers
                       where items.CustomerID == _CustomerID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the Department table in the Northwind Database.
    /// This class is queryable through NorthwindDB.Department 
    /// </summary>

	public partial class Department: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public Department(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnDepartmentIDChanging(short value);
        partial void OnDepartmentIDChanged();
		
		private short _DepartmentID;
		public short DepartmentID { 
		    get{
		        return _DepartmentID;
		    } 
		    set{
		        this.OnDepartmentIDChanging(value);
                this.SendPropertyChanging();
                this._DepartmentID = value;
                this.SendPropertyChanged("DepartmentID");
                this.OnDepartmentIDChanged();
		    }
		}
		
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
		
		private string _Name;
		public string Name { 
		    get{
		        return _Name;
		    } 
		    set{
		        this.OnNameChanging(value);
                this.SendPropertyChanging();
                this._Name = value;
                this.SendPropertyChanged("Name");
                this.OnNameChanged();
		    }
		}
		
        partial void OnGroupNameChanging(string value);
        partial void OnGroupNameChanged();
		
		private string _GroupName;
		public string GroupName { 
		    get{
		        return _GroupName;
		    } 
		    set{
		        this.OnGroupNameChanging(value);
                this.SendPropertyChanging();
                this._GroupName = value;
                this.SendPropertyChanged("GroupName");
                this.OnGroupNameChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<EmployeeDepartmentHistory> EmployeeDepartmentHistories
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.EmployeeDepartmentHistories
                       where items.DepartmentID == _DepartmentID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the Document table in the Northwind Database.
    /// This class is queryable through NorthwindDB.Document 
    /// </summary>

	public partial class Document: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public Document(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnDocumentIDChanging(int value);
        partial void OnDocumentIDChanged();
		
		private int _DocumentID;
		public int DocumentID { 
		    get{
		        return _DocumentID;
		    } 
		    set{
		        this.OnDocumentIDChanging(value);
                this.SendPropertyChanging();
                this._DocumentID = value;
                this.SendPropertyChanged("DocumentID");
                this.OnDocumentIDChanged();
		    }
		}
		
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
		
		private string _Title;
		public string Title { 
		    get{
		        return _Title;
		    } 
		    set{
		        this.OnTitleChanging(value);
                this.SendPropertyChanging();
                this._Title = value;
                this.SendPropertyChanged("Title");
                this.OnTitleChanged();
		    }
		}
		
        partial void OnFileNameChanging(string value);
        partial void OnFileNameChanged();
		
		private string _FileName;
		public string FileName { 
		    get{
		        return _FileName;
		    } 
		    set{
		        this.OnFileNameChanging(value);
                this.SendPropertyChanging();
                this._FileName = value;
                this.SendPropertyChanged("FileName");
                this.OnFileNameChanged();
		    }
		}
		
        partial void OnFileExtensionChanging(string value);
        partial void OnFileExtensionChanged();
		
		private string _FileExtension;
		public string FileExtension { 
		    get{
		        return _FileExtension;
		    } 
		    set{
		        this.OnFileExtensionChanging(value);
                this.SendPropertyChanging();
                this._FileExtension = value;
                this.SendPropertyChanged("FileExtension");
                this.OnFileExtensionChanged();
		    }
		}
		
        partial void OnRevisionChanging(string value);
        partial void OnRevisionChanged();
		
		private string _Revision;
		public string Revision { 
		    get{
		        return _Revision;
		    } 
		    set{
		        this.OnRevisionChanging(value);
                this.SendPropertyChanging();
                this._Revision = value;
                this.SendPropertyChanged("Revision");
                this.OnRevisionChanged();
		    }
		}
		
        partial void OnChangeNumberChanging(int value);
        partial void OnChangeNumberChanged();
		
		private int _ChangeNumber;
		public int ChangeNumber { 
		    get{
		        return _ChangeNumber;
		    } 
		    set{
		        this.OnChangeNumberChanging(value);
                this.SendPropertyChanging();
                this._ChangeNumber = value;
                this.SendPropertyChanged("ChangeNumber");
                this.OnChangeNumberChanged();
		    }
		}
		
        partial void OnStatusChanging(byte[] value);
        partial void OnStatusChanged();
		
		private byte[] _Status;
		public byte[] Status { 
		    get{
		        return _Status;
		    } 
		    set{
		        this.OnStatusChanging(value);
                this.SendPropertyChanging();
                this._Status = value;
                this.SendPropertyChanged("Status");
                this.OnStatusChanged();
		    }
		}
		
        partial void OnDocumentSummaryChanging(string value);
        partial void OnDocumentSummaryChanged();
		
		private string _DocumentSummary;
		public string DocumentSummary { 
		    get{
		        return _DocumentSummary;
		    } 
		    set{
		        this.OnDocumentSummaryChanging(value);
                this.SendPropertyChanging();
                this._DocumentSummary = value;
                this.SendPropertyChanged("DocumentSummary");
                this.OnDocumentSummaryChanged();
		    }
		}
		
        partial void OnDocumentXChanging(byte[] value);
        partial void OnDocumentXChanged();
		
		private byte[] _DocumentX;
		public byte[] DocumentX { 
		    get{
		        return _DocumentX;
		    } 
		    set{
		        this.OnDocumentXChanging(value);
                this.SendPropertyChanging();
                this._DocumentX = value;
                this.SendPropertyChanged("DocumentX");
                this.OnDocumentXChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<ProductDocument> ProductDocuments
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.ProductDocuments
                       where items.DocumentID == _DocumentID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the Employee table in the Northwind Database.
    /// This class is queryable through NorthwindDB.Employee 
    /// </summary>

	public partial class Employee: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public Employee(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnEmployeeIDChanging(int value);
        partial void OnEmployeeIDChanged();
		
		private int _EmployeeID;
		public int EmployeeID { 
		    get{
		        return _EmployeeID;
		    } 
		    set{
		        this.OnEmployeeIDChanging(value);
                this.SendPropertyChanging();
                this._EmployeeID = value;
                this.SendPropertyChanged("EmployeeID");
                this.OnEmployeeIDChanged();
		    }
		}
		
        partial void OnNationalIDNumberChanging(string value);
        partial void OnNationalIDNumberChanged();
		
		private string _NationalIDNumber;
		public string NationalIDNumber { 
		    get{
		        return _NationalIDNumber;
		    } 
		    set{
		        this.OnNationalIDNumberChanging(value);
                this.SendPropertyChanging();
                this._NationalIDNumber = value;
                this.SendPropertyChanged("NationalIDNumber");
                this.OnNationalIDNumberChanged();
		    }
		}
		
        partial void OnContactIDChanging(int value);
        partial void OnContactIDChanged();
		
		private int _ContactID;
		public int ContactID { 
		    get{
		        return _ContactID;
		    } 
		    set{
		        this.OnContactIDChanging(value);
                this.SendPropertyChanging();
                this._ContactID = value;
                this.SendPropertyChanged("ContactID");
                this.OnContactIDChanged();
		    }
		}
		
        partial void OnLoginIDChanging(string value);
        partial void OnLoginIDChanged();
		
		private string _LoginID;
		public string LoginID { 
		    get{
		        return _LoginID;
		    } 
		    set{
		        this.OnLoginIDChanging(value);
                this.SendPropertyChanging();
                this._LoginID = value;
                this.SendPropertyChanged("LoginID");
                this.OnLoginIDChanged();
		    }
		}
		
        partial void OnManagerIDChanging(int? value);
        partial void OnManagerIDChanged();
		
		private int? _ManagerID;
		public int? ManagerID { 
		    get{
		        return _ManagerID;
		    } 
		    set{
		        this.OnManagerIDChanging(value);
                this.SendPropertyChanging();
                this._ManagerID = value;
                this.SendPropertyChanged("ManagerID");
                this.OnManagerIDChanged();
		    }
		}
		
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
		
		private string _Title;
		public string Title { 
		    get{
		        return _Title;
		    } 
		    set{
		        this.OnTitleChanging(value);
                this.SendPropertyChanging();
                this._Title = value;
                this.SendPropertyChanged("Title");
                this.OnTitleChanged();
		    }
		}
		
        partial void OnBirthDateChanging(DateTime value);
        partial void OnBirthDateChanged();
		
		private DateTime _BirthDate;
		public DateTime BirthDate { 
		    get{
		        return _BirthDate;
		    } 
		    set{
		        this.OnBirthDateChanging(value);
                this.SendPropertyChanging();
                this._BirthDate = value;
                this.SendPropertyChanged("BirthDate");
                this.OnBirthDateChanged();
		    }
		}
		
        partial void OnMaritalStatusChanging(string value);
        partial void OnMaritalStatusChanged();
		
		private string _MaritalStatus;
		public string MaritalStatus { 
		    get{
		        return _MaritalStatus;
		    } 
		    set{
		        this.OnMaritalStatusChanging(value);
                this.SendPropertyChanging();
                this._MaritalStatus = value;
                this.SendPropertyChanged("MaritalStatus");
                this.OnMaritalStatusChanged();
		    }
		}
		
        partial void OnGenderChanging(string value);
        partial void OnGenderChanged();
		
		private string _Gender;
		public string Gender { 
		    get{
		        return _Gender;
		    } 
		    set{
		        this.OnGenderChanging(value);
                this.SendPropertyChanging();
                this._Gender = value;
                this.SendPropertyChanged("Gender");
                this.OnGenderChanged();
		    }
		}
		
        partial void OnHireDateChanging(DateTime value);
        partial void OnHireDateChanged();
		
		private DateTime _HireDate;
		public DateTime HireDate { 
		    get{
		        return _HireDate;
		    } 
		    set{
		        this.OnHireDateChanging(value);
                this.SendPropertyChanging();
                this._HireDate = value;
                this.SendPropertyChanged("HireDate");
                this.OnHireDateChanged();
		    }
		}
		
        partial void OnSalariedFlagChanging(bool value);
        partial void OnSalariedFlagChanged();
		
		private bool _SalariedFlag;
		public bool SalariedFlag { 
		    get{
		        return _SalariedFlag;
		    } 
		    set{
		        this.OnSalariedFlagChanging(value);
                this.SendPropertyChanging();
                this._SalariedFlag = value;
                this.SendPropertyChanged("SalariedFlag");
                this.OnSalariedFlagChanged();
		    }
		}
		
        partial void OnVacationHoursChanging(short value);
        partial void OnVacationHoursChanged();
		
		private short _VacationHours;
		public short VacationHours { 
		    get{
		        return _VacationHours;
		    } 
		    set{
		        this.OnVacationHoursChanging(value);
                this.SendPropertyChanging();
                this._VacationHours = value;
                this.SendPropertyChanged("VacationHours");
                this.OnVacationHoursChanged();
		    }
		}
		
        partial void OnSickLeaveHoursChanging(short value);
        partial void OnSickLeaveHoursChanged();
		
		private short _SickLeaveHours;
		public short SickLeaveHours { 
		    get{
		        return _SickLeaveHours;
		    } 
		    set{
		        this.OnSickLeaveHoursChanging(value);
                this.SendPropertyChanging();
                this._SickLeaveHours = value;
                this.SendPropertyChanged("SickLeaveHours");
                this.OnSickLeaveHoursChanged();
		    }
		}
		
        partial void OnCurrentFlagChanging(bool value);
        partial void OnCurrentFlagChanged();
		
		private bool _CurrentFlag;
		public bool CurrentFlag { 
		    get{
		        return _CurrentFlag;
		    } 
		    set{
		        this.OnCurrentFlagChanging(value);
                this.SendPropertyChanging();
                this._CurrentFlag = value;
                this.SendPropertyChanged("CurrentFlag");
                this.OnCurrentFlagChanged();
		    }
		}
		
        partial void OnrowguidChanging(Guid value);
        partial void OnrowguidChanged();
		
		private Guid _rowguid;
		public Guid rowguid { 
		    get{
		        return _rowguid;
		    } 
		    set{
		        this.OnrowguidChanging(value);
                this.SendPropertyChanging();
                this._rowguid = value;
                this.SendPropertyChanged("rowguid");
                this.OnrowguidChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<JobCandidate> JobCandidates
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.JobCandidates
                       where items.EmployeeID == _EmployeeID
                       select items;
            }
        }

        public IQueryable<PurchaseOrderHeader> PurchaseOrderHeaders
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.PurchaseOrderHeaders
                       where items.EmployeeID == _EmployeeID
                       select items;
            }
        }

        public IQueryable<SalesPerson> SalesPeople
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SalesPeople
                       where items.SalesPersonID == _EmployeeID
                       select items;
            }
        }

        public IQueryable<Employee> Employees
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Employees
                       where items.EmployeeID == _ManagerID
                       select items;
            }
        }

        public IQueryable<Contact> Contacts
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Contacts
                       where items.ContactID == _ContactID
                       select items;
            }
        }

        public IQueryable<EmployeeAddress> EmployeeAddresses
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.EmployeeAddresses
                       where items.EmployeeID == _EmployeeID
                       select items;
            }
        }

        public IQueryable<EmployeeDepartmentHistory> EmployeeDepartmentHistories
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.EmployeeDepartmentHistories
                       where items.EmployeeID == _EmployeeID
                       select items;
            }
        }

        public IQueryable<EmployeePayHistory> EmployeePayHistories
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.EmployeePayHistories
                       where items.EmployeeID == _EmployeeID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the SalesOrderHeaderSalesReason table in the Northwind Database.
    /// This class is queryable through NorthwindDB.SalesOrderHeaderSalesReason 
    /// </summary>

	public partial class SalesOrderHeaderSalesReason: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public SalesOrderHeaderSalesReason(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnSalesOrderIDChanging(int value);
        partial void OnSalesOrderIDChanged();
		
		private int _SalesOrderID;
		public int SalesOrderID { 
		    get{
		        return _SalesOrderID;
		    } 
		    set{
		        this.OnSalesOrderIDChanging(value);
                this.SendPropertyChanging();
                this._SalesOrderID = value;
                this.SendPropertyChanged("SalesOrderID");
                this.OnSalesOrderIDChanged();
		    }
		}
		
        partial void OnSalesReasonIDChanging(int value);
        partial void OnSalesReasonIDChanged();
		
		private int _SalesReasonID;
		public int SalesReasonID { 
		    get{
		        return _SalesReasonID;
		    } 
		    set{
		        this.OnSalesReasonIDChanging(value);
                this.SendPropertyChanging();
                this._SalesReasonID = value;
                this.SendPropertyChanged("SalesReasonID");
                this.OnSalesReasonIDChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<SalesReason> SalesReasons
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SalesReasons
                       where items.SalesReasonID == _SalesReasonID
                       select items;
            }
        }

        public IQueryable<SalesOrderHeader> SalesOrderHeaders
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SalesOrderHeaders
                       where items.SalesOrderID == _SalesOrderID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the SalesPerson table in the Northwind Database.
    /// This class is queryable through NorthwindDB.SalesPerson 
    /// </summary>

	public partial class SalesPerson: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public SalesPerson(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnSalesPersonIDChanging(int value);
        partial void OnSalesPersonIDChanged();
		
		private int _SalesPersonID;
		public int SalesPersonID { 
		    get{
		        return _SalesPersonID;
		    } 
		    set{
		        this.OnSalesPersonIDChanging(value);
                this.SendPropertyChanging();
                this._SalesPersonID = value;
                this.SendPropertyChanged("SalesPersonID");
                this.OnSalesPersonIDChanged();
		    }
		}
		
        partial void OnTerritoryIDChanging(int? value);
        partial void OnTerritoryIDChanged();
		
		private int? _TerritoryID;
		public int? TerritoryID { 
		    get{
		        return _TerritoryID;
		    } 
		    set{
		        this.OnTerritoryIDChanging(value);
                this.SendPropertyChanging();
                this._TerritoryID = value;
                this.SendPropertyChanged("TerritoryID");
                this.OnTerritoryIDChanged();
		    }
		}
		
        partial void OnSalesQuotaChanging(decimal? value);
        partial void OnSalesQuotaChanged();
		
		private decimal? _SalesQuota;
		public decimal? SalesQuota { 
		    get{
		        return _SalesQuota;
		    } 
		    set{
		        this.OnSalesQuotaChanging(value);
                this.SendPropertyChanging();
                this._SalesQuota = value;
                this.SendPropertyChanged("SalesQuota");
                this.OnSalesQuotaChanged();
		    }
		}
		
        partial void OnBonusChanging(decimal value);
        partial void OnBonusChanged();
		
		private decimal _Bonus;
		public decimal Bonus { 
		    get{
		        return _Bonus;
		    } 
		    set{
		        this.OnBonusChanging(value);
                this.SendPropertyChanging();
                this._Bonus = value;
                this.SendPropertyChanged("Bonus");
                this.OnBonusChanged();
		    }
		}
		
        partial void OnCommissionPctChanging(decimal value);
        partial void OnCommissionPctChanged();
		
		private decimal _CommissionPct;
		public decimal CommissionPct { 
		    get{
		        return _CommissionPct;
		    } 
		    set{
		        this.OnCommissionPctChanging(value);
                this.SendPropertyChanging();
                this._CommissionPct = value;
                this.SendPropertyChanged("CommissionPct");
                this.OnCommissionPctChanged();
		    }
		}
		
        partial void OnSalesYTDChanging(decimal value);
        partial void OnSalesYTDChanged();
		
		private decimal _SalesYTD;
		public decimal SalesYTD { 
		    get{
		        return _SalesYTD;
		    } 
		    set{
		        this.OnSalesYTDChanging(value);
                this.SendPropertyChanging();
                this._SalesYTD = value;
                this.SendPropertyChanged("SalesYTD");
                this.OnSalesYTDChanged();
		    }
		}
		
        partial void OnSalesLastYearChanging(decimal value);
        partial void OnSalesLastYearChanged();
		
		private decimal _SalesLastYear;
		public decimal SalesLastYear { 
		    get{
		        return _SalesLastYear;
		    } 
		    set{
		        this.OnSalesLastYearChanging(value);
                this.SendPropertyChanging();
                this._SalesLastYear = value;
                this.SendPropertyChanged("SalesLastYear");
                this.OnSalesLastYearChanged();
		    }
		}
		
        partial void OnrowguidChanging(Guid value);
        partial void OnrowguidChanged();
		
		private Guid _rowguid;
		public Guid rowguid { 
		    get{
		        return _rowguid;
		    } 
		    set{
		        this.OnrowguidChanging(value);
                this.SendPropertyChanging();
                this._rowguid = value;
                this.SendPropertyChanged("rowguid");
                this.OnrowguidChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<SalesOrderHeader> SalesOrderHeaders
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SalesOrderHeaders
                       where items.SalesPersonID == _SalesPersonID
                       select items;
            }
        }

        public IQueryable<Employee> Employees
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Employees
                       where items.EmployeeID == _SalesPersonID
                       select items;
            }
        }

        public IQueryable<SalesTerritory> SalesTerritories
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SalesTerritories
                       where items.TerritoryID == _TerritoryID
                       select items;
            }
        }

        public IQueryable<SalesPersonQuotaHistory> SalesPersonQuotaHistories
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SalesPersonQuotaHistories
                       where items.SalesPersonID == _SalesPersonID
                       select items;
            }
        }

        public IQueryable<SalesTerritoryHistory> SalesTerritoryHistories
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SalesTerritoryHistories
                       where items.SalesPersonID == _SalesPersonID
                       select items;
            }
        }

        public IQueryable<Store> Stores
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Stores
                       where items.SalesPersonID == _SalesPersonID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the EmployeeAddress table in the Northwind Database.
    /// This class is queryable through NorthwindDB.EmployeeAddress 
    /// </summary>

	public partial class EmployeeAddress: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public EmployeeAddress(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnEmployeeIDChanging(int value);
        partial void OnEmployeeIDChanged();
		
		private int _EmployeeID;
		public int EmployeeID { 
		    get{
		        return _EmployeeID;
		    } 
		    set{
		        this.OnEmployeeIDChanging(value);
                this.SendPropertyChanging();
                this._EmployeeID = value;
                this.SendPropertyChanged("EmployeeID");
                this.OnEmployeeIDChanged();
		    }
		}
		
        partial void OnAddressIDChanging(int value);
        partial void OnAddressIDChanged();
		
		private int _AddressID;
		public int AddressID { 
		    get{
		        return _AddressID;
		    } 
		    set{
		        this.OnAddressIDChanging(value);
                this.SendPropertyChanging();
                this._AddressID = value;
                this.SendPropertyChanged("AddressID");
                this.OnAddressIDChanged();
		    }
		}
		
        partial void OnrowguidChanging(Guid value);
        partial void OnrowguidChanged();
		
		private Guid _rowguid;
		public Guid rowguid { 
		    get{
		        return _rowguid;
		    } 
		    set{
		        this.OnrowguidChanging(value);
                this.SendPropertyChanging();
                this._rowguid = value;
                this.SendPropertyChanged("rowguid");
                this.OnrowguidChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Address> Addresses
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Addresses
                       where items.AddressID == _AddressID
                       select items;
            }
        }

        public IQueryable<Employee> Employees
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Employees
                       where items.EmployeeID == _EmployeeID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the EmployeeDepartmentHistory table in the Northwind Database.
    /// This class is queryable through NorthwindDB.EmployeeDepartmentHistory 
    /// </summary>

	public partial class EmployeeDepartmentHistory: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public EmployeeDepartmentHistory(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnEmployeeIDChanging(int value);
        partial void OnEmployeeIDChanged();
		
		private int _EmployeeID;
		public int EmployeeID { 
		    get{
		        return _EmployeeID;
		    } 
		    set{
		        this.OnEmployeeIDChanging(value);
                this.SendPropertyChanging();
                this._EmployeeID = value;
                this.SendPropertyChanged("EmployeeID");
                this.OnEmployeeIDChanged();
		    }
		}
		
        partial void OnDepartmentIDChanging(short value);
        partial void OnDepartmentIDChanged();
		
		private short _DepartmentID;
		public short DepartmentID { 
		    get{
		        return _DepartmentID;
		    } 
		    set{
		        this.OnDepartmentIDChanging(value);
                this.SendPropertyChanging();
                this._DepartmentID = value;
                this.SendPropertyChanged("DepartmentID");
                this.OnDepartmentIDChanged();
		    }
		}
		
        partial void OnShiftIDChanging(byte[] value);
        partial void OnShiftIDChanged();
		
		private byte[] _ShiftID;
		public byte[] ShiftID { 
		    get{
		        return _ShiftID;
		    } 
		    set{
		        this.OnShiftIDChanging(value);
                this.SendPropertyChanging();
                this._ShiftID = value;
                this.SendPropertyChanged("ShiftID");
                this.OnShiftIDChanged();
		    }
		}
		
        partial void OnStartDateChanging(DateTime value);
        partial void OnStartDateChanged();
		
		private DateTime _StartDate;
		public DateTime StartDate { 
		    get{
		        return _StartDate;
		    } 
		    set{
		        this.OnStartDateChanging(value);
                this.SendPropertyChanging();
                this._StartDate = value;
                this.SendPropertyChanged("StartDate");
                this.OnStartDateChanged();
		    }
		}
		
        partial void OnEndDateChanging(DateTime? value);
        partial void OnEndDateChanged();
		
		private DateTime? _EndDate;
		public DateTime? EndDate { 
		    get{
		        return _EndDate;
		    } 
		    set{
		        this.OnEndDateChanging(value);
                this.SendPropertyChanging();
                this._EndDate = value;
                this.SendPropertyChanged("EndDate");
                this.OnEndDateChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Department> Departments
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Departments
                       where items.DepartmentID == _DepartmentID
                       select items;
            }
        }

        public IQueryable<Employee> Employees
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Employees
                       where items.EmployeeID == _EmployeeID
                       select items;
            }
        }

        public IQueryable<Shift> Shifts
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Shifts
                       where items.ShiftID == _ShiftID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the EmployeePayHistory table in the Northwind Database.
    /// This class is queryable through NorthwindDB.EmployeePayHistory 
    /// </summary>

	public partial class EmployeePayHistory: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public EmployeePayHistory(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnEmployeeIDChanging(int value);
        partial void OnEmployeeIDChanged();
		
		private int _EmployeeID;
		public int EmployeeID { 
		    get{
		        return _EmployeeID;
		    } 
		    set{
		        this.OnEmployeeIDChanging(value);
                this.SendPropertyChanging();
                this._EmployeeID = value;
                this.SendPropertyChanged("EmployeeID");
                this.OnEmployeeIDChanged();
		    }
		}
		
        partial void OnRateChangeDateChanging(DateTime value);
        partial void OnRateChangeDateChanged();
		
		private DateTime _RateChangeDate;
		public DateTime RateChangeDate { 
		    get{
		        return _RateChangeDate;
		    } 
		    set{
		        this.OnRateChangeDateChanging(value);
                this.SendPropertyChanging();
                this._RateChangeDate = value;
                this.SendPropertyChanged("RateChangeDate");
                this.OnRateChangeDateChanged();
		    }
		}
		
        partial void OnRateChanging(decimal value);
        partial void OnRateChanged();
		
		private decimal _Rate;
		public decimal Rate { 
		    get{
		        return _Rate;
		    } 
		    set{
		        this.OnRateChanging(value);
                this.SendPropertyChanging();
                this._Rate = value;
                this.SendPropertyChanged("Rate");
                this.OnRateChanged();
		    }
		}
		
        partial void OnPayFrequencyChanging(byte[] value);
        partial void OnPayFrequencyChanged();
		
		private byte[] _PayFrequency;
		public byte[] PayFrequency { 
		    get{
		        return _PayFrequency;
		    } 
		    set{
		        this.OnPayFrequencyChanging(value);
                this.SendPropertyChanging();
                this._PayFrequency = value;
                this.SendPropertyChanged("PayFrequency");
                this.OnPayFrequencyChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Employee> Employees
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Employees
                       where items.EmployeeID == _EmployeeID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the SalesPersonQuotaHistory table in the Northwind Database.
    /// This class is queryable through NorthwindDB.SalesPersonQuotaHistory 
    /// </summary>

	public partial class SalesPersonQuotaHistory: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public SalesPersonQuotaHistory(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnSalesPersonIDChanging(int value);
        partial void OnSalesPersonIDChanged();
		
		private int _SalesPersonID;
		public int SalesPersonID { 
		    get{
		        return _SalesPersonID;
		    } 
		    set{
		        this.OnSalesPersonIDChanging(value);
                this.SendPropertyChanging();
                this._SalesPersonID = value;
                this.SendPropertyChanged("SalesPersonID");
                this.OnSalesPersonIDChanged();
		    }
		}
		
        partial void OnQuotaDateChanging(DateTime value);
        partial void OnQuotaDateChanged();
		
		private DateTime _QuotaDate;
		public DateTime QuotaDate { 
		    get{
		        return _QuotaDate;
		    } 
		    set{
		        this.OnQuotaDateChanging(value);
                this.SendPropertyChanging();
                this._QuotaDate = value;
                this.SendPropertyChanged("QuotaDate");
                this.OnQuotaDateChanged();
		    }
		}
		
        partial void OnSalesQuotaChanging(decimal value);
        partial void OnSalesQuotaChanged();
		
		private decimal _SalesQuota;
		public decimal SalesQuota { 
		    get{
		        return _SalesQuota;
		    } 
		    set{
		        this.OnSalesQuotaChanging(value);
                this.SendPropertyChanging();
                this._SalesQuota = value;
                this.SendPropertyChanged("SalesQuota");
                this.OnSalesQuotaChanged();
		    }
		}
		
        partial void OnrowguidChanging(Guid value);
        partial void OnrowguidChanged();
		
		private Guid _rowguid;
		public Guid rowguid { 
		    get{
		        return _rowguid;
		    } 
		    set{
		        this.OnrowguidChanging(value);
                this.SendPropertyChanging();
                this._rowguid = value;
                this.SendPropertyChanged("rowguid");
                this.OnrowguidChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<SalesPerson> SalesPeople
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SalesPeople
                       where items.SalesPersonID == _SalesPersonID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the Illustration table in the Northwind Database.
    /// This class is queryable through NorthwindDB.Illustration 
    /// </summary>

	public partial class Illustration: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public Illustration(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnIllustrationIDChanging(int value);
        partial void OnIllustrationIDChanged();
		
		private int _IllustrationID;
		public int IllustrationID { 
		    get{
		        return _IllustrationID;
		    } 
		    set{
		        this.OnIllustrationIDChanging(value);
                this.SendPropertyChanging();
                this._IllustrationID = value;
                this.SendPropertyChanged("IllustrationID");
                this.OnIllustrationIDChanged();
		    }
		}
		
        partial void OnDiagramChanging(string value);
        partial void OnDiagramChanged();
		
		private string _Diagram;
		public string Diagram { 
		    get{
		        return _Diagram;
		    } 
		    set{
		        this.OnDiagramChanging(value);
                this.SendPropertyChanging();
                this._Diagram = value;
                this.SendPropertyChanged("Diagram");
                this.OnDiagramChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<ProductModelIllustration> ProductModelIllustrations
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.ProductModelIllustrations
                       where items.IllustrationID == _IllustrationID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the SalesReason table in the Northwind Database.
    /// This class is queryable through NorthwindDB.SalesReason 
    /// </summary>

	public partial class SalesReason: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public SalesReason(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnSalesReasonIDChanging(int value);
        partial void OnSalesReasonIDChanged();
		
		private int _SalesReasonID;
		public int SalesReasonID { 
		    get{
		        return _SalesReasonID;
		    } 
		    set{
		        this.OnSalesReasonIDChanging(value);
                this.SendPropertyChanging();
                this._SalesReasonID = value;
                this.SendPropertyChanged("SalesReasonID");
                this.OnSalesReasonIDChanged();
		    }
		}
		
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
		
		private string _Name;
		public string Name { 
		    get{
		        return _Name;
		    } 
		    set{
		        this.OnNameChanging(value);
                this.SendPropertyChanging();
                this._Name = value;
                this.SendPropertyChanged("Name");
                this.OnNameChanged();
		    }
		}
		
        partial void OnReasonTypeChanging(string value);
        partial void OnReasonTypeChanged();
		
		private string _ReasonType;
		public string ReasonType { 
		    get{
		        return _ReasonType;
		    } 
		    set{
		        this.OnReasonTypeChanging(value);
                this.SendPropertyChanging();
                this._ReasonType = value;
                this.SendPropertyChanged("ReasonType");
                this.OnReasonTypeChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SalesOrderHeaderSalesReasons
                       where items.SalesReasonID == _SalesReasonID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the Individual table in the Northwind Database.
    /// This class is queryable through NorthwindDB.Individual 
    /// </summary>

	public partial class Individual: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public Individual(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnCustomerIDChanging(int value);
        partial void OnCustomerIDChanged();
		
		private int _CustomerID;
		public int CustomerID { 
		    get{
		        return _CustomerID;
		    } 
		    set{
		        this.OnCustomerIDChanging(value);
                this.SendPropertyChanging();
                this._CustomerID = value;
                this.SendPropertyChanged("CustomerID");
                this.OnCustomerIDChanged();
		    }
		}
		
        partial void OnContactIDChanging(int value);
        partial void OnContactIDChanged();
		
		private int _ContactID;
		public int ContactID { 
		    get{
		        return _ContactID;
		    } 
		    set{
		        this.OnContactIDChanging(value);
                this.SendPropertyChanging();
                this._ContactID = value;
                this.SendPropertyChanged("ContactID");
                this.OnContactIDChanged();
		    }
		}
		
        partial void OnDemographicsChanging(string value);
        partial void OnDemographicsChanged();
		
		private string _Demographics;
		public string Demographics { 
		    get{
		        return _Demographics;
		    } 
		    set{
		        this.OnDemographicsChanging(value);
                this.SendPropertyChanging();
                this._Demographics = value;
                this.SendPropertyChanged("Demographics");
                this.OnDemographicsChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Contact> Contacts
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Contacts
                       where items.ContactID == _ContactID
                       select items;
            }
        }

        public IQueryable<Customer> Customers
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Customers
                       where items.CustomerID == _CustomerID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the SalesTaxRate table in the Northwind Database.
    /// This class is queryable through NorthwindDB.SalesTaxRate 
    /// </summary>

	public partial class SalesTaxRate: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public SalesTaxRate(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnSalesTaxRateIDChanging(int value);
        partial void OnSalesTaxRateIDChanged();
		
		private int _SalesTaxRateID;
		public int SalesTaxRateID { 
		    get{
		        return _SalesTaxRateID;
		    } 
		    set{
		        this.OnSalesTaxRateIDChanging(value);
                this.SendPropertyChanging();
                this._SalesTaxRateID = value;
                this.SendPropertyChanged("SalesTaxRateID");
                this.OnSalesTaxRateIDChanged();
		    }
		}
		
        partial void OnStateProvinceIDChanging(int value);
        partial void OnStateProvinceIDChanged();
		
		private int _StateProvinceID;
		public int StateProvinceID { 
		    get{
		        return _StateProvinceID;
		    } 
		    set{
		        this.OnStateProvinceIDChanging(value);
                this.SendPropertyChanging();
                this._StateProvinceID = value;
                this.SendPropertyChanged("StateProvinceID");
                this.OnStateProvinceIDChanged();
		    }
		}
		
        partial void OnTaxTypeChanging(byte[] value);
        partial void OnTaxTypeChanged();
		
		private byte[] _TaxType;
		public byte[] TaxType { 
		    get{
		        return _TaxType;
		    } 
		    set{
		        this.OnTaxTypeChanging(value);
                this.SendPropertyChanging();
                this._TaxType = value;
                this.SendPropertyChanged("TaxType");
                this.OnTaxTypeChanged();
		    }
		}
		
        partial void OnTaxRateChanging(decimal value);
        partial void OnTaxRateChanged();
		
		private decimal _TaxRate;
		public decimal TaxRate { 
		    get{
		        return _TaxRate;
		    } 
		    set{
		        this.OnTaxRateChanging(value);
                this.SendPropertyChanging();
                this._TaxRate = value;
                this.SendPropertyChanged("TaxRate");
                this.OnTaxRateChanged();
		    }
		}
		
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
		
		private string _Name;
		public string Name { 
		    get{
		        return _Name;
		    } 
		    set{
		        this.OnNameChanging(value);
                this.SendPropertyChanging();
                this._Name = value;
                this.SendPropertyChanged("Name");
                this.OnNameChanged();
		    }
		}
		
        partial void OnrowguidChanging(Guid value);
        partial void OnrowguidChanged();
		
		private Guid _rowguid;
		public Guid rowguid { 
		    get{
		        return _rowguid;
		    } 
		    set{
		        this.OnrowguidChanging(value);
                this.SendPropertyChanging();
                this._rowguid = value;
                this.SendPropertyChanged("rowguid");
                this.OnrowguidChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<StateProvince> StateProvinces
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.StateProvinces
                       where items.StateProvinceID == _StateProvinceID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the JobCandidate table in the Northwind Database.
    /// This class is queryable through NorthwindDB.JobCandidate 
    /// </summary>

	public partial class JobCandidate: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public JobCandidate(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnJobCandidateIDChanging(int value);
        partial void OnJobCandidateIDChanged();
		
		private int _JobCandidateID;
		public int JobCandidateID { 
		    get{
		        return _JobCandidateID;
		    } 
		    set{
		        this.OnJobCandidateIDChanging(value);
                this.SendPropertyChanging();
                this._JobCandidateID = value;
                this.SendPropertyChanged("JobCandidateID");
                this.OnJobCandidateIDChanged();
		    }
		}
		
        partial void OnEmployeeIDChanging(int? value);
        partial void OnEmployeeIDChanged();
		
		private int? _EmployeeID;
		public int? EmployeeID { 
		    get{
		        return _EmployeeID;
		    } 
		    set{
		        this.OnEmployeeIDChanging(value);
                this.SendPropertyChanging();
                this._EmployeeID = value;
                this.SendPropertyChanged("EmployeeID");
                this.OnEmployeeIDChanged();
		    }
		}
		
        partial void OnResumeChanging(string value);
        partial void OnResumeChanged();
		
		private string _Resume;
		public string Resume { 
		    get{
		        return _Resume;
		    } 
		    set{
		        this.OnResumeChanging(value);
                this.SendPropertyChanging();
                this._Resume = value;
                this.SendPropertyChanged("Resume");
                this.OnResumeChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Employee> Employees
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Employees
                       where items.EmployeeID == _EmployeeID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the Location table in the Northwind Database.
    /// This class is queryable through NorthwindDB.Location 
    /// </summary>

	public partial class Location: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public Location(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnLocationIDChanging(short value);
        partial void OnLocationIDChanged();
		
		private short _LocationID;
		public short LocationID { 
		    get{
		        return _LocationID;
		    } 
		    set{
		        this.OnLocationIDChanging(value);
                this.SendPropertyChanging();
                this._LocationID = value;
                this.SendPropertyChanged("LocationID");
                this.OnLocationIDChanged();
		    }
		}
		
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
		
		private string _Name;
		public string Name { 
		    get{
		        return _Name;
		    } 
		    set{
		        this.OnNameChanging(value);
                this.SendPropertyChanging();
                this._Name = value;
                this.SendPropertyChanged("Name");
                this.OnNameChanged();
		    }
		}
		
        partial void OnCostRateChanging(decimal value);
        partial void OnCostRateChanged();
		
		private decimal _CostRate;
		public decimal CostRate { 
		    get{
		        return _CostRate;
		    } 
		    set{
		        this.OnCostRateChanging(value);
                this.SendPropertyChanging();
                this._CostRate = value;
                this.SendPropertyChanged("CostRate");
                this.OnCostRateChanged();
		    }
		}
		
        partial void OnAvailabilityChanging(decimal value);
        partial void OnAvailabilityChanged();
		
		private decimal _Availability;
		public decimal Availability { 
		    get{
		        return _Availability;
		    } 
		    set{
		        this.OnAvailabilityChanging(value);
                this.SendPropertyChanging();
                this._Availability = value;
                this.SendPropertyChanged("Availability");
                this.OnAvailabilityChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<ProductInventory> ProductInventories
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.ProductInventories
                       where items.LocationID == _LocationID
                       select items;
            }
        }

        public IQueryable<WorkOrderRouting> WorkOrderRoutings
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.WorkOrderRoutings
                       where items.LocationID == _LocationID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the SalesTerritory table in the Northwind Database.
    /// This class is queryable through NorthwindDB.SalesTerritory 
    /// </summary>

	public partial class SalesTerritory: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public SalesTerritory(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnTerritoryIDChanging(int value);
        partial void OnTerritoryIDChanged();
		
		private int _TerritoryID;
		public int TerritoryID { 
		    get{
		        return _TerritoryID;
		    } 
		    set{
		        this.OnTerritoryIDChanging(value);
                this.SendPropertyChanging();
                this._TerritoryID = value;
                this.SendPropertyChanged("TerritoryID");
                this.OnTerritoryIDChanged();
		    }
		}
		
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
		
		private string _Name;
		public string Name { 
		    get{
		        return _Name;
		    } 
		    set{
		        this.OnNameChanging(value);
                this.SendPropertyChanging();
                this._Name = value;
                this.SendPropertyChanged("Name");
                this.OnNameChanged();
		    }
		}
		
        partial void OnCountryRegionCodeChanging(string value);
        partial void OnCountryRegionCodeChanged();
		
		private string _CountryRegionCode;
		public string CountryRegionCode { 
		    get{
		        return _CountryRegionCode;
		    } 
		    set{
		        this.OnCountryRegionCodeChanging(value);
                this.SendPropertyChanging();
                this._CountryRegionCode = value;
                this.SendPropertyChanged("CountryRegionCode");
                this.OnCountryRegionCodeChanged();
		    }
		}
		
        partial void OnGroupChanging(string value);
        partial void OnGroupChanged();
		
		private string _Group;
		public string Group { 
		    get{
		        return _Group;
		    } 
		    set{
		        this.OnGroupChanging(value);
                this.SendPropertyChanging();
                this._Group = value;
                this.SendPropertyChanged("Group");
                this.OnGroupChanged();
		    }
		}
		
        partial void OnSalesYTDChanging(decimal value);
        partial void OnSalesYTDChanged();
		
		private decimal _SalesYTD;
		public decimal SalesYTD { 
		    get{
		        return _SalesYTD;
		    } 
		    set{
		        this.OnSalesYTDChanging(value);
                this.SendPropertyChanging();
                this._SalesYTD = value;
                this.SendPropertyChanged("SalesYTD");
                this.OnSalesYTDChanged();
		    }
		}
		
        partial void OnSalesLastYearChanging(decimal value);
        partial void OnSalesLastYearChanged();
		
		private decimal _SalesLastYear;
		public decimal SalesLastYear { 
		    get{
		        return _SalesLastYear;
		    } 
		    set{
		        this.OnSalesLastYearChanging(value);
                this.SendPropertyChanging();
                this._SalesLastYear = value;
                this.SendPropertyChanged("SalesLastYear");
                this.OnSalesLastYearChanged();
		    }
		}
		
        partial void OnCostYTDChanging(decimal value);
        partial void OnCostYTDChanged();
		
		private decimal _CostYTD;
		public decimal CostYTD { 
		    get{
		        return _CostYTD;
		    } 
		    set{
		        this.OnCostYTDChanging(value);
                this.SendPropertyChanging();
                this._CostYTD = value;
                this.SendPropertyChanged("CostYTD");
                this.OnCostYTDChanged();
		    }
		}
		
        partial void OnCostLastYearChanging(decimal value);
        partial void OnCostLastYearChanged();
		
		private decimal _CostLastYear;
		public decimal CostLastYear { 
		    get{
		        return _CostLastYear;
		    } 
		    set{
		        this.OnCostLastYearChanging(value);
                this.SendPropertyChanging();
                this._CostLastYear = value;
                this.SendPropertyChanged("CostLastYear");
                this.OnCostLastYearChanged();
		    }
		}
		
        partial void OnrowguidChanging(Guid value);
        partial void OnrowguidChanged();
		
		private Guid _rowguid;
		public Guid rowguid { 
		    get{
		        return _rowguid;
		    } 
		    set{
		        this.OnrowguidChanging(value);
                this.SendPropertyChanging();
                this._rowguid = value;
                this.SendPropertyChanged("rowguid");
                this.OnrowguidChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<SalesOrderHeader> SalesOrderHeaders
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SalesOrderHeaders
                       where items.TerritoryID == _TerritoryID
                       select items;
            }
        }

        public IQueryable<SalesPerson> SalesPeople
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SalesPeople
                       where items.TerritoryID == _TerritoryID
                       select items;
            }
        }

        public IQueryable<SalesTerritoryHistory> SalesTerritoryHistories
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SalesTerritoryHistories
                       where items.TerritoryID == _TerritoryID
                       select items;
            }
        }

        public IQueryable<StateProvince> StateProvinces
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.StateProvinces
                       where items.TerritoryID == _TerritoryID
                       select items;
            }
        }

        public IQueryable<Customer> Customers
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Customers
                       where items.TerritoryID == _TerritoryID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the Product table in the Northwind Database.
    /// This class is queryable through NorthwindDB.Product 
    /// </summary>

	public partial class Product: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public Product(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnProductIDChanging(int value);
        partial void OnProductIDChanged();
		
		private int _ProductID;
		public int ProductID { 
		    get{
		        return _ProductID;
		    } 
		    set{
		        this.OnProductIDChanging(value);
                this.SendPropertyChanging();
                this._ProductID = value;
                this.SendPropertyChanged("ProductID");
                this.OnProductIDChanged();
		    }
		}
		
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
		
		private string _Name;
		public string Name { 
		    get{
		        return _Name;
		    } 
		    set{
		        this.OnNameChanging(value);
                this.SendPropertyChanging();
                this._Name = value;
                this.SendPropertyChanged("Name");
                this.OnNameChanged();
		    }
		}
		
        partial void OnProductNumberChanging(string value);
        partial void OnProductNumberChanged();
		
		private string _ProductNumber;
		public string ProductNumber { 
		    get{
		        return _ProductNumber;
		    } 
		    set{
		        this.OnProductNumberChanging(value);
                this.SendPropertyChanging();
                this._ProductNumber = value;
                this.SendPropertyChanged("ProductNumber");
                this.OnProductNumberChanged();
		    }
		}
		
        partial void OnMakeFlagChanging(bool value);
        partial void OnMakeFlagChanged();
		
		private bool _MakeFlag;
		public bool MakeFlag { 
		    get{
		        return _MakeFlag;
		    } 
		    set{
		        this.OnMakeFlagChanging(value);
                this.SendPropertyChanging();
                this._MakeFlag = value;
                this.SendPropertyChanged("MakeFlag");
                this.OnMakeFlagChanged();
		    }
		}
		
        partial void OnFinishedGoodsFlagChanging(bool value);
        partial void OnFinishedGoodsFlagChanged();
		
		private bool _FinishedGoodsFlag;
		public bool FinishedGoodsFlag { 
		    get{
		        return _FinishedGoodsFlag;
		    } 
		    set{
		        this.OnFinishedGoodsFlagChanging(value);
                this.SendPropertyChanging();
                this._FinishedGoodsFlag = value;
                this.SendPropertyChanged("FinishedGoodsFlag");
                this.OnFinishedGoodsFlagChanged();
		    }
		}
		
        partial void OnColorChanging(string value);
        partial void OnColorChanged();
		
		private string _Color;
		public string Color { 
		    get{
		        return _Color;
		    } 
		    set{
		        this.OnColorChanging(value);
                this.SendPropertyChanging();
                this._Color = value;
                this.SendPropertyChanged("Color");
                this.OnColorChanged();
		    }
		}
		
        partial void OnSafetyStockLevelChanging(short value);
        partial void OnSafetyStockLevelChanged();
		
		private short _SafetyStockLevel;
		public short SafetyStockLevel { 
		    get{
		        return _SafetyStockLevel;
		    } 
		    set{
		        this.OnSafetyStockLevelChanging(value);
                this.SendPropertyChanging();
                this._SafetyStockLevel = value;
                this.SendPropertyChanged("SafetyStockLevel");
                this.OnSafetyStockLevelChanged();
		    }
		}
		
        partial void OnReorderPointChanging(short value);
        partial void OnReorderPointChanged();
		
		private short _ReorderPoint;
		public short ReorderPoint { 
		    get{
		        return _ReorderPoint;
		    } 
		    set{
		        this.OnReorderPointChanging(value);
                this.SendPropertyChanging();
                this._ReorderPoint = value;
                this.SendPropertyChanged("ReorderPoint");
                this.OnReorderPointChanged();
		    }
		}
		
        partial void OnStandardCostChanging(decimal value);
        partial void OnStandardCostChanged();
		
		private decimal _StandardCost;
		public decimal StandardCost { 
		    get{
		        return _StandardCost;
		    } 
		    set{
		        this.OnStandardCostChanging(value);
                this.SendPropertyChanging();
                this._StandardCost = value;
                this.SendPropertyChanged("StandardCost");
                this.OnStandardCostChanged();
		    }
		}
		
        partial void OnListPriceChanging(decimal value);
        partial void OnListPriceChanged();
		
		private decimal _ListPrice;
		public decimal ListPrice { 
		    get{
		        return _ListPrice;
		    } 
		    set{
		        this.OnListPriceChanging(value);
                this.SendPropertyChanging();
                this._ListPrice = value;
                this.SendPropertyChanged("ListPrice");
                this.OnListPriceChanged();
		    }
		}
		
        partial void OnSizeChanging(string value);
        partial void OnSizeChanged();
		
		private string _Size;
		public string Size { 
		    get{
		        return _Size;
		    } 
		    set{
		        this.OnSizeChanging(value);
                this.SendPropertyChanging();
                this._Size = value;
                this.SendPropertyChanged("Size");
                this.OnSizeChanged();
		    }
		}
		
        partial void OnSizeUnitMeasureCodeChanging(string value);
        partial void OnSizeUnitMeasureCodeChanged();
		
		private string _SizeUnitMeasureCode;
		public string SizeUnitMeasureCode { 
		    get{
		        return _SizeUnitMeasureCode;
		    } 
		    set{
		        this.OnSizeUnitMeasureCodeChanging(value);
                this.SendPropertyChanging();
                this._SizeUnitMeasureCode = value;
                this.SendPropertyChanged("SizeUnitMeasureCode");
                this.OnSizeUnitMeasureCodeChanged();
		    }
		}
		
        partial void OnWeightUnitMeasureCodeChanging(string value);
        partial void OnWeightUnitMeasureCodeChanged();
		
		private string _WeightUnitMeasureCode;
		public string WeightUnitMeasureCode { 
		    get{
		        return _WeightUnitMeasureCode;
		    } 
		    set{
		        this.OnWeightUnitMeasureCodeChanging(value);
                this.SendPropertyChanging();
                this._WeightUnitMeasureCode = value;
                this.SendPropertyChanged("WeightUnitMeasureCode");
                this.OnWeightUnitMeasureCodeChanged();
		    }
		}
		
        partial void OnWeightChanging(decimal? value);
        partial void OnWeightChanged();
		
		private decimal? _Weight;
		public decimal? Weight { 
		    get{
		        return _Weight;
		    } 
		    set{
		        this.OnWeightChanging(value);
                this.SendPropertyChanging();
                this._Weight = value;
                this.SendPropertyChanged("Weight");
                this.OnWeightChanged();
		    }
		}
		
        partial void OnDaysToManufactureChanging(int value);
        partial void OnDaysToManufactureChanged();
		
		private int _DaysToManufacture;
		public int DaysToManufacture { 
		    get{
		        return _DaysToManufacture;
		    } 
		    set{
		        this.OnDaysToManufactureChanging(value);
                this.SendPropertyChanging();
                this._DaysToManufacture = value;
                this.SendPropertyChanged("DaysToManufacture");
                this.OnDaysToManufactureChanged();
		    }
		}
		
        partial void OnProductLineChanging(string value);
        partial void OnProductLineChanged();
		
		private string _ProductLine;
		public string ProductLine { 
		    get{
		        return _ProductLine;
		    } 
		    set{
		        this.OnProductLineChanging(value);
                this.SendPropertyChanging();
                this._ProductLine = value;
                this.SendPropertyChanged("ProductLine");
                this.OnProductLineChanged();
		    }
		}
		
        partial void OnClassChanging(string value);
        partial void OnClassChanged();
		
		private string _Class;
		public string Class { 
		    get{
		        return _Class;
		    } 
		    set{
		        this.OnClassChanging(value);
                this.SendPropertyChanging();
                this._Class = value;
                this.SendPropertyChanged("Class");
                this.OnClassChanged();
		    }
		}
		
        partial void OnStyleChanging(string value);
        partial void OnStyleChanged();
		
		private string _Style;
		public string Style { 
		    get{
		        return _Style;
		    } 
		    set{
		        this.OnStyleChanging(value);
                this.SendPropertyChanging();
                this._Style = value;
                this.SendPropertyChanged("Style");
                this.OnStyleChanged();
		    }
		}
		
        partial void OnProductSubcategoryIDChanging(int? value);
        partial void OnProductSubcategoryIDChanged();
		
		private int? _ProductSubcategoryID;
		public int? ProductSubcategoryID { 
		    get{
		        return _ProductSubcategoryID;
		    } 
		    set{
		        this.OnProductSubcategoryIDChanging(value);
                this.SendPropertyChanging();
                this._ProductSubcategoryID = value;
                this.SendPropertyChanged("ProductSubcategoryID");
                this.OnProductSubcategoryIDChanged();
		    }
		}
		
        partial void OnProductModelIDChanging(int? value);
        partial void OnProductModelIDChanged();
		
		private int? _ProductModelID;
		public int? ProductModelID { 
		    get{
		        return _ProductModelID;
		    } 
		    set{
		        this.OnProductModelIDChanging(value);
                this.SendPropertyChanging();
                this._ProductModelID = value;
                this.SendPropertyChanged("ProductModelID");
                this.OnProductModelIDChanged();
		    }
		}
		
        partial void OnSellStartDateChanging(DateTime value);
        partial void OnSellStartDateChanged();
		
		private DateTime _SellStartDate;
		public DateTime SellStartDate { 
		    get{
		        return _SellStartDate;
		    } 
		    set{
		        this.OnSellStartDateChanging(value);
                this.SendPropertyChanging();
                this._SellStartDate = value;
                this.SendPropertyChanged("SellStartDate");
                this.OnSellStartDateChanged();
		    }
		}
		
        partial void OnSellEndDateChanging(DateTime? value);
        partial void OnSellEndDateChanged();
		
		private DateTime? _SellEndDate;
		public DateTime? SellEndDate { 
		    get{
		        return _SellEndDate;
		    } 
		    set{
		        this.OnSellEndDateChanging(value);
                this.SendPropertyChanging();
                this._SellEndDate = value;
                this.SendPropertyChanged("SellEndDate");
                this.OnSellEndDateChanged();
		    }
		}
		
        partial void OnDiscontinuedDateChanging(DateTime? value);
        partial void OnDiscontinuedDateChanged();
		
		private DateTime? _DiscontinuedDate;
		public DateTime? DiscontinuedDate { 
		    get{
		        return _DiscontinuedDate;
		    } 
		    set{
		        this.OnDiscontinuedDateChanging(value);
                this.SendPropertyChanging();
                this._DiscontinuedDate = value;
                this.SendPropertyChanged("DiscontinuedDate");
                this.OnDiscontinuedDateChanged();
		    }
		}
		
        partial void OnrowguidChanging(Guid value);
        partial void OnrowguidChanged();
		
		private Guid _rowguid;
		public Guid rowguid { 
		    get{
		        return _rowguid;
		    } 
		    set{
		        this.OnrowguidChanging(value);
                this.SendPropertyChanging();
                this._rowguid = value;
                this.SendPropertyChanged("rowguid");
                this.OnrowguidChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<UnitMeasure> UnitMeasures
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.UnitMeasures
                       where items.UnitMeasureCode == _SizeUnitMeasureCode
                       select items;
            }
        }

        public IQueryable<UnitMeasure> UnitMeasures1
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.UnitMeasures
                       where items.UnitMeasureCode == _WeightUnitMeasureCode
                       select items;
            }
        }

        public IQueryable<ProductModel> ProductModels
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.ProductModels
                       where items.ProductModelID == _ProductModelID
                       select items;
            }
        }

        public IQueryable<ProductSubcategory> ProductSubcategories
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.ProductSubcategories
                       where items.ProductSubcategoryID == _ProductSubcategoryID
                       select items;
            }
        }

        public IQueryable<ProductCostHistory> ProductCostHistories
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.ProductCostHistories
                       where items.ProductID == _ProductID
                       select items;
            }
        }

        public IQueryable<ProductDocument> ProductDocuments
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.ProductDocuments
                       where items.ProductID == _ProductID
                       select items;
            }
        }

        public IQueryable<ProductInventory> ProductInventories
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.ProductInventories
                       where items.ProductID == _ProductID
                       select items;
            }
        }

        public IQueryable<ProductListPriceHistory> ProductListPriceHistories
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.ProductListPriceHistories
                       where items.ProductID == _ProductID
                       select items;
            }
        }

        public IQueryable<ProductProductPhoto> ProductProductPhotos
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.ProductProductPhotos
                       where items.ProductID == _ProductID
                       select items;
            }
        }

        public IQueryable<ProductReview> ProductReviews
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.ProductReviews
                       where items.ProductID == _ProductID
                       select items;
            }
        }

        public IQueryable<ProductVendor> ProductVendors
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.ProductVendors
                       where items.ProductID == _ProductID
                       select items;
            }
        }

        public IQueryable<PurchaseOrderDetail> PurchaseOrderDetails
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.PurchaseOrderDetails
                       where items.ProductID == _ProductID
                       select items;
            }
        }

        public IQueryable<ShoppingCartItem> ShoppingCartItems
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.ShoppingCartItems
                       where items.ProductID == _ProductID
                       select items;
            }
        }

        public IQueryable<SpecialOfferProduct> SpecialOfferProducts
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SpecialOfferProducts
                       where items.ProductID == _ProductID
                       select items;
            }
        }

        public IQueryable<TransactionHistory> TransactionHistories
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.TransactionHistories
                       where items.ProductID == _ProductID
                       select items;
            }
        }

        public IQueryable<WorkOrder> WorkOrders
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.WorkOrders
                       where items.ProductID == _ProductID
                       select items;
            }
        }

        public IQueryable<BillOfMaterial> BillOfMaterials
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.BillOfMaterials
                       where items.ProductAssemblyID == _ProductID
                       select items;
            }
        }

        public IQueryable<BillOfMaterial> BillOfMaterials17
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.BillOfMaterials
                       where items.ComponentID == _ProductID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the SalesTerritoryHistory table in the Northwind Database.
    /// This class is queryable through NorthwindDB.SalesTerritoryHistory 
    /// </summary>

	public partial class SalesTerritoryHistory: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public SalesTerritoryHistory(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnSalesPersonIDChanging(int value);
        partial void OnSalesPersonIDChanged();
		
		private int _SalesPersonID;
		public int SalesPersonID { 
		    get{
		        return _SalesPersonID;
		    } 
		    set{
		        this.OnSalesPersonIDChanging(value);
                this.SendPropertyChanging();
                this._SalesPersonID = value;
                this.SendPropertyChanged("SalesPersonID");
                this.OnSalesPersonIDChanged();
		    }
		}
		
        partial void OnTerritoryIDChanging(int value);
        partial void OnTerritoryIDChanged();
		
		private int _TerritoryID;
		public int TerritoryID { 
		    get{
		        return _TerritoryID;
		    } 
		    set{
		        this.OnTerritoryIDChanging(value);
                this.SendPropertyChanging();
                this._TerritoryID = value;
                this.SendPropertyChanged("TerritoryID");
                this.OnTerritoryIDChanged();
		    }
		}
		
        partial void OnStartDateChanging(DateTime value);
        partial void OnStartDateChanged();
		
		private DateTime _StartDate;
		public DateTime StartDate { 
		    get{
		        return _StartDate;
		    } 
		    set{
		        this.OnStartDateChanging(value);
                this.SendPropertyChanging();
                this._StartDate = value;
                this.SendPropertyChanged("StartDate");
                this.OnStartDateChanged();
		    }
		}
		
        partial void OnEndDateChanging(DateTime? value);
        partial void OnEndDateChanged();
		
		private DateTime? _EndDate;
		public DateTime? EndDate { 
		    get{
		        return _EndDate;
		    } 
		    set{
		        this.OnEndDateChanging(value);
                this.SendPropertyChanging();
                this._EndDate = value;
                this.SendPropertyChanged("EndDate");
                this.OnEndDateChanged();
		    }
		}
		
        partial void OnrowguidChanging(Guid value);
        partial void OnrowguidChanged();
		
		private Guid _rowguid;
		public Guid rowguid { 
		    get{
		        return _rowguid;
		    } 
		    set{
		        this.OnrowguidChanging(value);
                this.SendPropertyChanging();
                this._rowguid = value;
                this.SendPropertyChanged("rowguid");
                this.OnrowguidChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<SalesPerson> SalesPeople
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SalesPeople
                       where items.SalesPersonID == _SalesPersonID
                       select items;
            }
        }

        public IQueryable<SalesTerritory> SalesTerritories
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SalesTerritories
                       where items.TerritoryID == _TerritoryID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the ScrapReason table in the Northwind Database.
    /// This class is queryable through NorthwindDB.ScrapReason 
    /// </summary>

	public partial class ScrapReason: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public ScrapReason(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnScrapReasonIDChanging(short value);
        partial void OnScrapReasonIDChanged();
		
		private short _ScrapReasonID;
		public short ScrapReasonID { 
		    get{
		        return _ScrapReasonID;
		    } 
		    set{
		        this.OnScrapReasonIDChanging(value);
                this.SendPropertyChanging();
                this._ScrapReasonID = value;
                this.SendPropertyChanged("ScrapReasonID");
                this.OnScrapReasonIDChanged();
		    }
		}
		
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
		
		private string _Name;
		public string Name { 
		    get{
		        return _Name;
		    } 
		    set{
		        this.OnNameChanging(value);
                this.SendPropertyChanging();
                this._Name = value;
                this.SendPropertyChanged("Name");
                this.OnNameChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<WorkOrder> WorkOrders
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.WorkOrders
                       where items.ScrapReasonID == _ScrapReasonID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the Shift table in the Northwind Database.
    /// This class is queryable through NorthwindDB.Shift 
    /// </summary>

	public partial class Shift: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public Shift(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnShiftIDChanging(byte[] value);
        partial void OnShiftIDChanged();
		
		private byte[] _ShiftID;
		public byte[] ShiftID { 
		    get{
		        return _ShiftID;
		    } 
		    set{
		        this.OnShiftIDChanging(value);
                this.SendPropertyChanging();
                this._ShiftID = value;
                this.SendPropertyChanged("ShiftID");
                this.OnShiftIDChanged();
		    }
		}
		
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
		
		private string _Name;
		public string Name { 
		    get{
		        return _Name;
		    } 
		    set{
		        this.OnNameChanging(value);
                this.SendPropertyChanging();
                this._Name = value;
                this.SendPropertyChanged("Name");
                this.OnNameChanged();
		    }
		}
		
        partial void OnStartTimeChanging(DateTime value);
        partial void OnStartTimeChanged();
		
		private DateTime _StartTime;
		public DateTime StartTime { 
		    get{
		        return _StartTime;
		    } 
		    set{
		        this.OnStartTimeChanging(value);
                this.SendPropertyChanging();
                this._StartTime = value;
                this.SendPropertyChanged("StartTime");
                this.OnStartTimeChanged();
		    }
		}
		
        partial void OnEndTimeChanging(DateTime value);
        partial void OnEndTimeChanged();
		
		private DateTime _EndTime;
		public DateTime EndTime { 
		    get{
		        return _EndTime;
		    } 
		    set{
		        this.OnEndTimeChanging(value);
                this.SendPropertyChanging();
                this._EndTime = value;
                this.SendPropertyChanged("EndTime");
                this.OnEndTimeChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<EmployeeDepartmentHistory> EmployeeDepartmentHistories
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.EmployeeDepartmentHistories
                       where items.ShiftID == _ShiftID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the ProductCategory table in the Northwind Database.
    /// This class is queryable through NorthwindDB.ProductCategory 
    /// </summary>

	public partial class ProductCategory: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public ProductCategory(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnProductCategoryIDChanging(int value);
        partial void OnProductCategoryIDChanged();
		
		private int _ProductCategoryID;
		public int ProductCategoryID { 
		    get{
		        return _ProductCategoryID;
		    } 
		    set{
		        this.OnProductCategoryIDChanging(value);
                this.SendPropertyChanging();
                this._ProductCategoryID = value;
                this.SendPropertyChanged("ProductCategoryID");
                this.OnProductCategoryIDChanged();
		    }
		}
		
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
		
		private string _Name;
		public string Name { 
		    get{
		        return _Name;
		    } 
		    set{
		        this.OnNameChanging(value);
                this.SendPropertyChanging();
                this._Name = value;
                this.SendPropertyChanged("Name");
                this.OnNameChanged();
		    }
		}
		
        partial void OnrowguidChanging(Guid value);
        partial void OnrowguidChanged();
		
		private Guid _rowguid;
		public Guid rowguid { 
		    get{
		        return _rowguid;
		    } 
		    set{
		        this.OnrowguidChanging(value);
                this.SendPropertyChanging();
                this._rowguid = value;
                this.SendPropertyChanged("rowguid");
                this.OnrowguidChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<ProductSubcategory> ProductSubcategories
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.ProductSubcategories
                       where items.ProductCategoryID == _ProductCategoryID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the ShipMethod table in the Northwind Database.
    /// This class is queryable through NorthwindDB.ShipMethod 
    /// </summary>

	public partial class ShipMethod: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public ShipMethod(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnShipMethodIDChanging(int value);
        partial void OnShipMethodIDChanged();
		
		private int _ShipMethodID;
		public int ShipMethodID { 
		    get{
		        return _ShipMethodID;
		    } 
		    set{
		        this.OnShipMethodIDChanging(value);
                this.SendPropertyChanging();
                this._ShipMethodID = value;
                this.SendPropertyChanged("ShipMethodID");
                this.OnShipMethodIDChanged();
		    }
		}
		
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
		
		private string _Name;
		public string Name { 
		    get{
		        return _Name;
		    } 
		    set{
		        this.OnNameChanging(value);
                this.SendPropertyChanging();
                this._Name = value;
                this.SendPropertyChanged("Name");
                this.OnNameChanged();
		    }
		}
		
        partial void OnShipBaseChanging(decimal value);
        partial void OnShipBaseChanged();
		
		private decimal _ShipBase;
		public decimal ShipBase { 
		    get{
		        return _ShipBase;
		    } 
		    set{
		        this.OnShipBaseChanging(value);
                this.SendPropertyChanging();
                this._ShipBase = value;
                this.SendPropertyChanged("ShipBase");
                this.OnShipBaseChanged();
		    }
		}
		
        partial void OnShipRateChanging(decimal value);
        partial void OnShipRateChanged();
		
		private decimal _ShipRate;
		public decimal ShipRate { 
		    get{
		        return _ShipRate;
		    } 
		    set{
		        this.OnShipRateChanging(value);
                this.SendPropertyChanging();
                this._ShipRate = value;
                this.SendPropertyChanged("ShipRate");
                this.OnShipRateChanged();
		    }
		}
		
        partial void OnrowguidChanging(Guid value);
        partial void OnrowguidChanged();
		
		private Guid _rowguid;
		public Guid rowguid { 
		    get{
		        return _rowguid;
		    } 
		    set{
		        this.OnrowguidChanging(value);
                this.SendPropertyChanging();
                this._rowguid = value;
                this.SendPropertyChanged("rowguid");
                this.OnrowguidChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<PurchaseOrderHeader> PurchaseOrderHeaders
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.PurchaseOrderHeaders
                       where items.ShipMethodID == _ShipMethodID
                       select items;
            }
        }

        public IQueryable<SalesOrderHeader> SalesOrderHeaders
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SalesOrderHeaders
                       where items.ShipMethodID == _ShipMethodID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the ProductCostHistory table in the Northwind Database.
    /// This class is queryable through NorthwindDB.ProductCostHistory 
    /// </summary>

	public partial class ProductCostHistory: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public ProductCostHistory(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnProductIDChanging(int value);
        partial void OnProductIDChanged();
		
		private int _ProductID;
		public int ProductID { 
		    get{
		        return _ProductID;
		    } 
		    set{
		        this.OnProductIDChanging(value);
                this.SendPropertyChanging();
                this._ProductID = value;
                this.SendPropertyChanged("ProductID");
                this.OnProductIDChanged();
		    }
		}
		
        partial void OnStartDateChanging(DateTime value);
        partial void OnStartDateChanged();
		
		private DateTime _StartDate;
		public DateTime StartDate { 
		    get{
		        return _StartDate;
		    } 
		    set{
		        this.OnStartDateChanging(value);
                this.SendPropertyChanging();
                this._StartDate = value;
                this.SendPropertyChanged("StartDate");
                this.OnStartDateChanged();
		    }
		}
		
        partial void OnEndDateChanging(DateTime? value);
        partial void OnEndDateChanged();
		
		private DateTime? _EndDate;
		public DateTime? EndDate { 
		    get{
		        return _EndDate;
		    } 
		    set{
		        this.OnEndDateChanging(value);
                this.SendPropertyChanging();
                this._EndDate = value;
                this.SendPropertyChanged("EndDate");
                this.OnEndDateChanged();
		    }
		}
		
        partial void OnStandardCostChanging(decimal value);
        partial void OnStandardCostChanged();
		
		private decimal _StandardCost;
		public decimal StandardCost { 
		    get{
		        return _StandardCost;
		    } 
		    set{
		        this.OnStandardCostChanging(value);
                this.SendPropertyChanging();
                this._StandardCost = value;
                this.SendPropertyChanged("StandardCost");
                this.OnStandardCostChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Product> Products
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Products
                       where items.ProductID == _ProductID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the ProductDescription table in the Northwind Database.
    /// This class is queryable through NorthwindDB.ProductDescription 
    /// </summary>

	public partial class ProductDescription: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public ProductDescription(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnProductDescriptionIDChanging(int value);
        partial void OnProductDescriptionIDChanged();
		
		private int _ProductDescriptionID;
		public int ProductDescriptionID { 
		    get{
		        return _ProductDescriptionID;
		    } 
		    set{
		        this.OnProductDescriptionIDChanging(value);
                this.SendPropertyChanging();
                this._ProductDescriptionID = value;
                this.SendPropertyChanged("ProductDescriptionID");
                this.OnProductDescriptionIDChanged();
		    }
		}
		
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
		
		private string _Description;
		public string Description { 
		    get{
		        return _Description;
		    } 
		    set{
		        this.OnDescriptionChanging(value);
                this.SendPropertyChanging();
                this._Description = value;
                this.SendPropertyChanged("Description");
                this.OnDescriptionChanged();
		    }
		}
		
        partial void OnrowguidChanging(Guid value);
        partial void OnrowguidChanged();
		
		private Guid _rowguid;
		public Guid rowguid { 
		    get{
		        return _rowguid;
		    } 
		    set{
		        this.OnrowguidChanging(value);
                this.SendPropertyChanging();
                this._rowguid = value;
                this.SendPropertyChanged("rowguid");
                this.OnrowguidChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.ProductModelProductDescriptionCultures
                       where items.ProductDescriptionID == _ProductDescriptionID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the ShoppingCartItem table in the Northwind Database.
    /// This class is queryable through NorthwindDB.ShoppingCartItem 
    /// </summary>

	public partial class ShoppingCartItem: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public ShoppingCartItem(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnShoppingCartItemIDChanging(int value);
        partial void OnShoppingCartItemIDChanged();
		
		private int _ShoppingCartItemID;
		public int ShoppingCartItemID { 
		    get{
		        return _ShoppingCartItemID;
		    } 
		    set{
		        this.OnShoppingCartItemIDChanging(value);
                this.SendPropertyChanging();
                this._ShoppingCartItemID = value;
                this.SendPropertyChanged("ShoppingCartItemID");
                this.OnShoppingCartItemIDChanged();
		    }
		}
		
        partial void OnShoppingCartIDChanging(string value);
        partial void OnShoppingCartIDChanged();
		
		private string _ShoppingCartID;
		public string ShoppingCartID { 
		    get{
		        return _ShoppingCartID;
		    } 
		    set{
		        this.OnShoppingCartIDChanging(value);
                this.SendPropertyChanging();
                this._ShoppingCartID = value;
                this.SendPropertyChanged("ShoppingCartID");
                this.OnShoppingCartIDChanged();
		    }
		}
		
        partial void OnQuantityChanging(int value);
        partial void OnQuantityChanged();
		
		private int _Quantity;
		public int Quantity { 
		    get{
		        return _Quantity;
		    } 
		    set{
		        this.OnQuantityChanging(value);
                this.SendPropertyChanging();
                this._Quantity = value;
                this.SendPropertyChanged("Quantity");
                this.OnQuantityChanged();
		    }
		}
		
        partial void OnProductIDChanging(int value);
        partial void OnProductIDChanged();
		
		private int _ProductID;
		public int ProductID { 
		    get{
		        return _ProductID;
		    } 
		    set{
		        this.OnProductIDChanging(value);
                this.SendPropertyChanging();
                this._ProductID = value;
                this.SendPropertyChanged("ProductID");
                this.OnProductIDChanged();
		    }
		}
		
        partial void OnDateCreatedChanging(DateTime value);
        partial void OnDateCreatedChanged();
		
		private DateTime _DateCreated;
		public DateTime DateCreated { 
		    get{
		        return _DateCreated;
		    } 
		    set{
		        this.OnDateCreatedChanging(value);
                this.SendPropertyChanging();
                this._DateCreated = value;
                this.SendPropertyChanged("DateCreated");
                this.OnDateCreatedChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Product> Products
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Products
                       where items.ProductID == _ProductID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the ProductDocument table in the Northwind Database.
    /// This class is queryable through NorthwindDB.ProductDocument 
    /// </summary>

	public partial class ProductDocument: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public ProductDocument(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnProductIDChanging(int value);
        partial void OnProductIDChanged();
		
		private int _ProductID;
		public int ProductID { 
		    get{
		        return _ProductID;
		    } 
		    set{
		        this.OnProductIDChanging(value);
                this.SendPropertyChanging();
                this._ProductID = value;
                this.SendPropertyChanged("ProductID");
                this.OnProductIDChanged();
		    }
		}
		
        partial void OnDocumentIDChanging(int value);
        partial void OnDocumentIDChanged();
		
		private int _DocumentID;
		public int DocumentID { 
		    get{
		        return _DocumentID;
		    } 
		    set{
		        this.OnDocumentIDChanging(value);
                this.SendPropertyChanging();
                this._DocumentID = value;
                this.SendPropertyChanged("DocumentID");
                this.OnDocumentIDChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Product> Products
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Products
                       where items.ProductID == _ProductID
                       select items;
            }
        }

        public IQueryable<Document> Documents
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Documents
                       where items.DocumentID == _DocumentID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the ProductInventory table in the Northwind Database.
    /// This class is queryable through NorthwindDB.ProductInventory 
    /// </summary>

	public partial class ProductInventory: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public ProductInventory(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnProductIDChanging(int value);
        partial void OnProductIDChanged();
		
		private int _ProductID;
		public int ProductID { 
		    get{
		        return _ProductID;
		    } 
		    set{
		        this.OnProductIDChanging(value);
                this.SendPropertyChanging();
                this._ProductID = value;
                this.SendPropertyChanged("ProductID");
                this.OnProductIDChanged();
		    }
		}
		
        partial void OnLocationIDChanging(short value);
        partial void OnLocationIDChanged();
		
		private short _LocationID;
		public short LocationID { 
		    get{
		        return _LocationID;
		    } 
		    set{
		        this.OnLocationIDChanging(value);
                this.SendPropertyChanging();
                this._LocationID = value;
                this.SendPropertyChanged("LocationID");
                this.OnLocationIDChanged();
		    }
		}
		
        partial void OnShelfChanging(string value);
        partial void OnShelfChanged();
		
		private string _Shelf;
		public string Shelf { 
		    get{
		        return _Shelf;
		    } 
		    set{
		        this.OnShelfChanging(value);
                this.SendPropertyChanging();
                this._Shelf = value;
                this.SendPropertyChanged("Shelf");
                this.OnShelfChanged();
		    }
		}
		
        partial void OnBinChanging(byte[] value);
        partial void OnBinChanged();
		
		private byte[] _Bin;
		public byte[] Bin { 
		    get{
		        return _Bin;
		    } 
		    set{
		        this.OnBinChanging(value);
                this.SendPropertyChanging();
                this._Bin = value;
                this.SendPropertyChanged("Bin");
                this.OnBinChanged();
		    }
		}
		
        partial void OnQuantityChanging(short value);
        partial void OnQuantityChanged();
		
		private short _Quantity;
		public short Quantity { 
		    get{
		        return _Quantity;
		    } 
		    set{
		        this.OnQuantityChanging(value);
                this.SendPropertyChanging();
                this._Quantity = value;
                this.SendPropertyChanged("Quantity");
                this.OnQuantityChanged();
		    }
		}
		
        partial void OnrowguidChanging(Guid value);
        partial void OnrowguidChanged();
		
		private Guid _rowguid;
		public Guid rowguid { 
		    get{
		        return _rowguid;
		    } 
		    set{
		        this.OnrowguidChanging(value);
                this.SendPropertyChanging();
                this._rowguid = value;
                this.SendPropertyChanged("rowguid");
                this.OnrowguidChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Location> Locations
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Locations
                       where items.LocationID == _LocationID
                       select items;
            }
        }

        public IQueryable<Product> Products
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Products
                       where items.ProductID == _ProductID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the SpecialOffer table in the Northwind Database.
    /// This class is queryable through NorthwindDB.SpecialOffer 
    /// </summary>

	public partial class SpecialOffer: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public SpecialOffer(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnSpecialOfferIDChanging(int value);
        partial void OnSpecialOfferIDChanged();
		
		private int _SpecialOfferID;
		public int SpecialOfferID { 
		    get{
		        return _SpecialOfferID;
		    } 
		    set{
		        this.OnSpecialOfferIDChanging(value);
                this.SendPropertyChanging();
                this._SpecialOfferID = value;
                this.SendPropertyChanged("SpecialOfferID");
                this.OnSpecialOfferIDChanged();
		    }
		}
		
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
		
		private string _Description;
		public string Description { 
		    get{
		        return _Description;
		    } 
		    set{
		        this.OnDescriptionChanging(value);
                this.SendPropertyChanging();
                this._Description = value;
                this.SendPropertyChanged("Description");
                this.OnDescriptionChanged();
		    }
		}
		
        partial void OnDiscountPctChanging(decimal value);
        partial void OnDiscountPctChanged();
		
		private decimal _DiscountPct;
		public decimal DiscountPct { 
		    get{
		        return _DiscountPct;
		    } 
		    set{
		        this.OnDiscountPctChanging(value);
                this.SendPropertyChanging();
                this._DiscountPct = value;
                this.SendPropertyChanged("DiscountPct");
                this.OnDiscountPctChanged();
		    }
		}
		
        partial void OnTypeChanging(string value);
        partial void OnTypeChanged();
		
		private string _Type;
		public string Type { 
		    get{
		        return _Type;
		    } 
		    set{
		        this.OnTypeChanging(value);
                this.SendPropertyChanging();
                this._Type = value;
                this.SendPropertyChanged("Type");
                this.OnTypeChanged();
		    }
		}
		
        partial void OnCategoryChanging(string value);
        partial void OnCategoryChanged();
		
		private string _Category;
		public string Category { 
		    get{
		        return _Category;
		    } 
		    set{
		        this.OnCategoryChanging(value);
                this.SendPropertyChanging();
                this._Category = value;
                this.SendPropertyChanged("Category");
                this.OnCategoryChanged();
		    }
		}
		
        partial void OnStartDateChanging(DateTime value);
        partial void OnStartDateChanged();
		
		private DateTime _StartDate;
		public DateTime StartDate { 
		    get{
		        return _StartDate;
		    } 
		    set{
		        this.OnStartDateChanging(value);
                this.SendPropertyChanging();
                this._StartDate = value;
                this.SendPropertyChanged("StartDate");
                this.OnStartDateChanged();
		    }
		}
		
        partial void OnEndDateChanging(DateTime value);
        partial void OnEndDateChanged();
		
		private DateTime _EndDate;
		public DateTime EndDate { 
		    get{
		        return _EndDate;
		    } 
		    set{
		        this.OnEndDateChanging(value);
                this.SendPropertyChanging();
                this._EndDate = value;
                this.SendPropertyChanged("EndDate");
                this.OnEndDateChanged();
		    }
		}
		
        partial void OnMinQtyChanging(int value);
        partial void OnMinQtyChanged();
		
		private int _MinQty;
		public int MinQty { 
		    get{
		        return _MinQty;
		    } 
		    set{
		        this.OnMinQtyChanging(value);
                this.SendPropertyChanging();
                this._MinQty = value;
                this.SendPropertyChanged("MinQty");
                this.OnMinQtyChanged();
		    }
		}
		
        partial void OnMaxQtyChanging(int? value);
        partial void OnMaxQtyChanged();
		
		private int? _MaxQty;
		public int? MaxQty { 
		    get{
		        return _MaxQty;
		    } 
		    set{
		        this.OnMaxQtyChanging(value);
                this.SendPropertyChanging();
                this._MaxQty = value;
                this.SendPropertyChanged("MaxQty");
                this.OnMaxQtyChanged();
		    }
		}
		
        partial void OnrowguidChanging(Guid value);
        partial void OnrowguidChanged();
		
		private Guid _rowguid;
		public Guid rowguid { 
		    get{
		        return _rowguid;
		    } 
		    set{
		        this.OnrowguidChanging(value);
                this.SendPropertyChanging();
                this._rowguid = value;
                this.SendPropertyChanged("rowguid");
                this.OnrowguidChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<SpecialOfferProduct> SpecialOfferProducts
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SpecialOfferProducts
                       where items.SpecialOfferID == _SpecialOfferID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the ProductListPriceHistory table in the Northwind Database.
    /// This class is queryable through NorthwindDB.ProductListPriceHistory 
    /// </summary>

	public partial class ProductListPriceHistory: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public ProductListPriceHistory(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnProductIDChanging(int value);
        partial void OnProductIDChanged();
		
		private int _ProductID;
		public int ProductID { 
		    get{
		        return _ProductID;
		    } 
		    set{
		        this.OnProductIDChanging(value);
                this.SendPropertyChanging();
                this._ProductID = value;
                this.SendPropertyChanged("ProductID");
                this.OnProductIDChanged();
		    }
		}
		
        partial void OnStartDateChanging(DateTime value);
        partial void OnStartDateChanged();
		
		private DateTime _StartDate;
		public DateTime StartDate { 
		    get{
		        return _StartDate;
		    } 
		    set{
		        this.OnStartDateChanging(value);
                this.SendPropertyChanging();
                this._StartDate = value;
                this.SendPropertyChanged("StartDate");
                this.OnStartDateChanged();
		    }
		}
		
        partial void OnEndDateChanging(DateTime? value);
        partial void OnEndDateChanged();
		
		private DateTime? _EndDate;
		public DateTime? EndDate { 
		    get{
		        return _EndDate;
		    } 
		    set{
		        this.OnEndDateChanging(value);
                this.SendPropertyChanging();
                this._EndDate = value;
                this.SendPropertyChanged("EndDate");
                this.OnEndDateChanged();
		    }
		}
		
        partial void OnListPriceChanging(decimal value);
        partial void OnListPriceChanged();
		
		private decimal _ListPrice;
		public decimal ListPrice { 
		    get{
		        return _ListPrice;
		    } 
		    set{
		        this.OnListPriceChanging(value);
                this.SendPropertyChanging();
                this._ListPrice = value;
                this.SendPropertyChanged("ListPrice");
                this.OnListPriceChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Product> Products
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Products
                       where items.ProductID == _ProductID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the SpecialOfferProduct table in the Northwind Database.
    /// This class is queryable through NorthwindDB.SpecialOfferProduct 
    /// </summary>

	public partial class SpecialOfferProduct: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public SpecialOfferProduct(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnSpecialOfferIDChanging(int value);
        partial void OnSpecialOfferIDChanged();
		
		private int _SpecialOfferID;
		public int SpecialOfferID { 
		    get{
		        return _SpecialOfferID;
		    } 
		    set{
		        this.OnSpecialOfferIDChanging(value);
                this.SendPropertyChanging();
                this._SpecialOfferID = value;
                this.SendPropertyChanged("SpecialOfferID");
                this.OnSpecialOfferIDChanged();
		    }
		}
		
        partial void OnProductIDChanging(int value);
        partial void OnProductIDChanged();
		
		private int _ProductID;
		public int ProductID { 
		    get{
		        return _ProductID;
		    } 
		    set{
		        this.OnProductIDChanging(value);
                this.SendPropertyChanging();
                this._ProductID = value;
                this.SendPropertyChanged("ProductID");
                this.OnProductIDChanged();
		    }
		}
		
        partial void OnrowguidChanging(Guid value);
        partial void OnrowguidChanged();
		
		private Guid _rowguid;
		public Guid rowguid { 
		    get{
		        return _rowguid;
		    } 
		    set{
		        this.OnrowguidChanging(value);
                this.SendPropertyChanging();
                this._rowguid = value;
                this.SendPropertyChanged("rowguid");
                this.OnrowguidChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<SalesOrderDetail> SalesOrderDetails
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SalesOrderDetails
                       where items.ProductID == _ProductID
                       select items;
            }
        }

        public IQueryable<SalesOrderDetail> SalesOrderDetails1
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SalesOrderDetails
                       where items.ProductID == _SpecialOfferID
                       select items;
            }
        }

        public IQueryable<SalesOrderDetail> SalesOrderDetails2
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SalesOrderDetails
                       where items.SpecialOfferID == _ProductID
                       select items;
            }
        }

        public IQueryable<SalesOrderDetail> SalesOrderDetails3
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SalesOrderDetails
                       where items.SpecialOfferID == _SpecialOfferID
                       select items;
            }
        }

        public IQueryable<Product> Products
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Products
                       where items.ProductID == _ProductID
                       select items;
            }
        }

        public IQueryable<SpecialOffer> SpecialOffers
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SpecialOffers
                       where items.SpecialOfferID == _SpecialOfferID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the ProductModel table in the Northwind Database.
    /// This class is queryable through NorthwindDB.ProductModel 
    /// </summary>

	public partial class ProductModel: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public ProductModel(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnProductModelIDChanging(int value);
        partial void OnProductModelIDChanged();
		
		private int _ProductModelID;
		public int ProductModelID { 
		    get{
		        return _ProductModelID;
		    } 
		    set{
		        this.OnProductModelIDChanging(value);
                this.SendPropertyChanging();
                this._ProductModelID = value;
                this.SendPropertyChanged("ProductModelID");
                this.OnProductModelIDChanged();
		    }
		}
		
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
		
		private string _Name;
		public string Name { 
		    get{
		        return _Name;
		    } 
		    set{
		        this.OnNameChanging(value);
                this.SendPropertyChanging();
                this._Name = value;
                this.SendPropertyChanged("Name");
                this.OnNameChanged();
		    }
		}
		
        partial void OnCatalogDescriptionChanging(string value);
        partial void OnCatalogDescriptionChanged();
		
		private string _CatalogDescription;
		public string CatalogDescription { 
		    get{
		        return _CatalogDescription;
		    } 
		    set{
		        this.OnCatalogDescriptionChanging(value);
                this.SendPropertyChanging();
                this._CatalogDescription = value;
                this.SendPropertyChanged("CatalogDescription");
                this.OnCatalogDescriptionChanged();
		    }
		}
		
        partial void OnInstructionsChanging(string value);
        partial void OnInstructionsChanged();
		
		private string _Instructions;
		public string Instructions { 
		    get{
		        return _Instructions;
		    } 
		    set{
		        this.OnInstructionsChanging(value);
                this.SendPropertyChanging();
                this._Instructions = value;
                this.SendPropertyChanged("Instructions");
                this.OnInstructionsChanged();
		    }
		}
		
        partial void OnrowguidChanging(Guid value);
        partial void OnrowguidChanged();
		
		private Guid _rowguid;
		public Guid rowguid { 
		    get{
		        return _rowguid;
		    } 
		    set{
		        this.OnrowguidChanging(value);
                this.SendPropertyChanging();
                this._rowguid = value;
                this.SendPropertyChanged("rowguid");
                this.OnrowguidChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Product> Products
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Products
                       where items.ProductModelID == _ProductModelID
                       select items;
            }
        }

        public IQueryable<ProductModelIllustration> ProductModelIllustrations
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.ProductModelIllustrations
                       where items.ProductModelID == _ProductModelID
                       select items;
            }
        }

        public IQueryable<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.ProductModelProductDescriptionCultures
                       where items.ProductModelID == _ProductModelID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the StateProvince table in the Northwind Database.
    /// This class is queryable through NorthwindDB.StateProvince 
    /// </summary>

	public partial class StateProvince: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public StateProvince(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnStateProvinceIDChanging(int value);
        partial void OnStateProvinceIDChanged();
		
		private int _StateProvinceID;
		public int StateProvinceID { 
		    get{
		        return _StateProvinceID;
		    } 
		    set{
		        this.OnStateProvinceIDChanging(value);
                this.SendPropertyChanging();
                this._StateProvinceID = value;
                this.SendPropertyChanged("StateProvinceID");
                this.OnStateProvinceIDChanged();
		    }
		}
		
        partial void OnStateProvinceCodeChanging(string value);
        partial void OnStateProvinceCodeChanged();
		
		private string _StateProvinceCode;
		public string StateProvinceCode { 
		    get{
		        return _StateProvinceCode;
		    } 
		    set{
		        this.OnStateProvinceCodeChanging(value);
                this.SendPropertyChanging();
                this._StateProvinceCode = value;
                this.SendPropertyChanged("StateProvinceCode");
                this.OnStateProvinceCodeChanged();
		    }
		}
		
        partial void OnCountryRegionCodeChanging(string value);
        partial void OnCountryRegionCodeChanged();
		
		private string _CountryRegionCode;
		public string CountryRegionCode { 
		    get{
		        return _CountryRegionCode;
		    } 
		    set{
		        this.OnCountryRegionCodeChanging(value);
                this.SendPropertyChanging();
                this._CountryRegionCode = value;
                this.SendPropertyChanged("CountryRegionCode");
                this.OnCountryRegionCodeChanged();
		    }
		}
		
        partial void OnIsOnlyStateProvinceFlagChanging(bool value);
        partial void OnIsOnlyStateProvinceFlagChanged();
		
		private bool _IsOnlyStateProvinceFlag;
		public bool IsOnlyStateProvinceFlag { 
		    get{
		        return _IsOnlyStateProvinceFlag;
		    } 
		    set{
		        this.OnIsOnlyStateProvinceFlagChanging(value);
                this.SendPropertyChanging();
                this._IsOnlyStateProvinceFlag = value;
                this.SendPropertyChanged("IsOnlyStateProvinceFlag");
                this.OnIsOnlyStateProvinceFlagChanged();
		    }
		}
		
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
		
		private string _Name;
		public string Name { 
		    get{
		        return _Name;
		    } 
		    set{
		        this.OnNameChanging(value);
                this.SendPropertyChanging();
                this._Name = value;
                this.SendPropertyChanged("Name");
                this.OnNameChanged();
		    }
		}
		
        partial void OnTerritoryIDChanging(int value);
        partial void OnTerritoryIDChanged();
		
		private int _TerritoryID;
		public int TerritoryID { 
		    get{
		        return _TerritoryID;
		    } 
		    set{
		        this.OnTerritoryIDChanging(value);
                this.SendPropertyChanging();
                this._TerritoryID = value;
                this.SendPropertyChanged("TerritoryID");
                this.OnTerritoryIDChanged();
		    }
		}
		
        partial void OnrowguidChanging(Guid value);
        partial void OnrowguidChanged();
		
		private Guid _rowguid;
		public Guid rowguid { 
		    get{
		        return _rowguid;
		    } 
		    set{
		        this.OnrowguidChanging(value);
                this.SendPropertyChanging();
                this._rowguid = value;
                this.SendPropertyChanged("rowguid");
                this.OnrowguidChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<SalesTaxRate> SalesTaxRates
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SalesTaxRates
                       where items.StateProvinceID == _StateProvinceID
                       select items;
            }
        }

        public IQueryable<CountryRegion> CountryRegions
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.CountryRegions
                       where items.CountryRegionCode == _CountryRegionCode
                       select items;
            }
        }

        public IQueryable<SalesTerritory> SalesTerritories
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SalesTerritories
                       where items.TerritoryID == _TerritoryID
                       select items;
            }
        }

        public IQueryable<Address> Addresses
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Addresses
                       where items.StateProvinceID == _StateProvinceID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the ProductModelIllustration table in the Northwind Database.
    /// This class is queryable through NorthwindDB.ProductModelIllustration 
    /// </summary>

	public partial class ProductModelIllustration: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public ProductModelIllustration(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnProductModelIDChanging(int value);
        partial void OnProductModelIDChanged();
		
		private int _ProductModelID;
		public int ProductModelID { 
		    get{
		        return _ProductModelID;
		    } 
		    set{
		        this.OnProductModelIDChanging(value);
                this.SendPropertyChanging();
                this._ProductModelID = value;
                this.SendPropertyChanged("ProductModelID");
                this.OnProductModelIDChanged();
		    }
		}
		
        partial void OnIllustrationIDChanging(int value);
        partial void OnIllustrationIDChanged();
		
		private int _IllustrationID;
		public int IllustrationID { 
		    get{
		        return _IllustrationID;
		    } 
		    set{
		        this.OnIllustrationIDChanging(value);
                this.SendPropertyChanging();
                this._IllustrationID = value;
                this.SendPropertyChanged("IllustrationID");
                this.OnIllustrationIDChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<ProductModel> ProductModels
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.ProductModels
                       where items.ProductModelID == _ProductModelID
                       select items;
            }
        }

        public IQueryable<Illustration> Illustrations
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Illustrations
                       where items.IllustrationID == _IllustrationID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the DatabaseLog table in the Northwind Database.
    /// This class is queryable through NorthwindDB.DatabaseLog 
    /// </summary>

	public partial class DatabaseLog: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public DatabaseLog(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnDatabaseLogIDChanging(int value);
        partial void OnDatabaseLogIDChanged();
		
		private int _DatabaseLogID;
		public int DatabaseLogID { 
		    get{
		        return _DatabaseLogID;
		    } 
		    set{
		        this.OnDatabaseLogIDChanging(value);
                this.SendPropertyChanging();
                this._DatabaseLogID = value;
                this.SendPropertyChanged("DatabaseLogID");
                this.OnDatabaseLogIDChanged();
		    }
		}
		
        partial void OnPostTimeChanging(DateTime value);
        partial void OnPostTimeChanged();
		
		private DateTime _PostTime;
		public DateTime PostTime { 
		    get{
		        return _PostTime;
		    } 
		    set{
		        this.OnPostTimeChanging(value);
                this.SendPropertyChanging();
                this._PostTime = value;
                this.SendPropertyChanged("PostTime");
                this.OnPostTimeChanged();
		    }
		}
		
        partial void OnDatabaseUserChanging(string value);
        partial void OnDatabaseUserChanged();
		
		private string _DatabaseUser;
		public string DatabaseUser { 
		    get{
		        return _DatabaseUser;
		    } 
		    set{
		        this.OnDatabaseUserChanging(value);
                this.SendPropertyChanging();
                this._DatabaseUser = value;
                this.SendPropertyChanged("DatabaseUser");
                this.OnDatabaseUserChanged();
		    }
		}
		
        partial void OnEventChanging(string value);
        partial void OnEventChanged();
		
		private string _Event;
		public string Event { 
		    get{
		        return _Event;
		    } 
		    set{
		        this.OnEventChanging(value);
                this.SendPropertyChanging();
                this._Event = value;
                this.SendPropertyChanged("Event");
                this.OnEventChanged();
		    }
		}
		
        partial void OnSchemaChanging(string value);
        partial void OnSchemaChanged();
		
		private string _Schema;
		public string Schema { 
		    get{
		        return _Schema;
		    } 
		    set{
		        this.OnSchemaChanging(value);
                this.SendPropertyChanging();
                this._Schema = value;
                this.SendPropertyChanged("Schema");
                this.OnSchemaChanged();
		    }
		}
		
        partial void OnObjectChanging(string value);
        partial void OnObjectChanged();
		
		private string _Object;
		public string Object { 
		    get{
		        return _Object;
		    } 
		    set{
		        this.OnObjectChanging(value);
                this.SendPropertyChanging();
                this._Object = value;
                this.SendPropertyChanged("Object");
                this.OnObjectChanged();
		    }
		}
		
        partial void OnTSQLChanging(string value);
        partial void OnTSQLChanged();
		
		private string _TSQL;
		public string TSQL { 
		    get{
		        return _TSQL;
		    } 
		    set{
		        this.OnTSQLChanging(value);
                this.SendPropertyChanging();
                this._TSQL = value;
                this.SendPropertyChanged("TSQL");
                this.OnTSQLChanged();
		    }
		}
		
        partial void OnXmlEventChanging(string value);
        partial void OnXmlEventChanged();
		
		private string _XmlEvent;
		public string XmlEvent { 
		    get{
		        return _XmlEvent;
		    } 
		    set{
		        this.OnXmlEventChanging(value);
                this.SendPropertyChanging();
                this._XmlEvent = value;
                this.SendPropertyChanged("XmlEvent");
                this.OnXmlEventChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the ProductModelProductDescriptionCulture table in the Northwind Database.
    /// This class is queryable through NorthwindDB.ProductModelProductDescriptionCulture 
    /// </summary>

	public partial class ProductModelProductDescriptionCulture: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public ProductModelProductDescriptionCulture(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnProductModelIDChanging(int value);
        partial void OnProductModelIDChanged();
		
		private int _ProductModelID;
		public int ProductModelID { 
		    get{
		        return _ProductModelID;
		    } 
		    set{
		        this.OnProductModelIDChanging(value);
                this.SendPropertyChanging();
                this._ProductModelID = value;
                this.SendPropertyChanged("ProductModelID");
                this.OnProductModelIDChanged();
		    }
		}
		
        partial void OnProductDescriptionIDChanging(int value);
        partial void OnProductDescriptionIDChanged();
		
		private int _ProductDescriptionID;
		public int ProductDescriptionID { 
		    get{
		        return _ProductDescriptionID;
		    } 
		    set{
		        this.OnProductDescriptionIDChanging(value);
                this.SendPropertyChanging();
                this._ProductDescriptionID = value;
                this.SendPropertyChanged("ProductDescriptionID");
                this.OnProductDescriptionIDChanged();
		    }
		}
		
        partial void OnCultureIDChanging(string value);
        partial void OnCultureIDChanged();
		
		private string _CultureID;
		public string CultureID { 
		    get{
		        return _CultureID;
		    } 
		    set{
		        this.OnCultureIDChanging(value);
                this.SendPropertyChanging();
                this._CultureID = value;
                this.SendPropertyChanged("CultureID");
                this.OnCultureIDChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<ProductDescription> ProductDescriptions
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.ProductDescriptions
                       where items.ProductDescriptionID == _ProductDescriptionID
                       select items;
            }
        }

        public IQueryable<Culture> Cultures
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Cultures
                       where items.CultureID == _CultureID
                       select items;
            }
        }

        public IQueryable<ProductModel> ProductModels
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.ProductModels
                       where items.ProductModelID == _ProductModelID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the ErrorLog table in the Northwind Database.
    /// This class is queryable through NorthwindDB.ErrorLog 
    /// </summary>

	public partial class ErrorLog: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public ErrorLog(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnErrorLogIDChanging(int value);
        partial void OnErrorLogIDChanged();
		
		private int _ErrorLogID;
		public int ErrorLogID { 
		    get{
		        return _ErrorLogID;
		    } 
		    set{
		        this.OnErrorLogIDChanging(value);
                this.SendPropertyChanging();
                this._ErrorLogID = value;
                this.SendPropertyChanged("ErrorLogID");
                this.OnErrorLogIDChanged();
		    }
		}
		
        partial void OnErrorTimeChanging(DateTime value);
        partial void OnErrorTimeChanged();
		
		private DateTime _ErrorTime;
		public DateTime ErrorTime { 
		    get{
		        return _ErrorTime;
		    } 
		    set{
		        this.OnErrorTimeChanging(value);
                this.SendPropertyChanging();
                this._ErrorTime = value;
                this.SendPropertyChanged("ErrorTime");
                this.OnErrorTimeChanged();
		    }
		}
		
        partial void OnUserNameChanging(string value);
        partial void OnUserNameChanged();
		
		private string _UserName;
		public string UserName { 
		    get{
		        return _UserName;
		    } 
		    set{
		        this.OnUserNameChanging(value);
                this.SendPropertyChanging();
                this._UserName = value;
                this.SendPropertyChanged("UserName");
                this.OnUserNameChanged();
		    }
		}
		
        partial void OnErrorNumberChanging(int value);
        partial void OnErrorNumberChanged();
		
		private int _ErrorNumber;
		public int ErrorNumber { 
		    get{
		        return _ErrorNumber;
		    } 
		    set{
		        this.OnErrorNumberChanging(value);
                this.SendPropertyChanging();
                this._ErrorNumber = value;
                this.SendPropertyChanged("ErrorNumber");
                this.OnErrorNumberChanged();
		    }
		}
		
        partial void OnErrorSeverityChanging(int? value);
        partial void OnErrorSeverityChanged();
		
		private int? _ErrorSeverity;
		public int? ErrorSeverity { 
		    get{
		        return _ErrorSeverity;
		    } 
		    set{
		        this.OnErrorSeverityChanging(value);
                this.SendPropertyChanging();
                this._ErrorSeverity = value;
                this.SendPropertyChanged("ErrorSeverity");
                this.OnErrorSeverityChanged();
		    }
		}
		
        partial void OnErrorStateChanging(int? value);
        partial void OnErrorStateChanged();
		
		private int? _ErrorState;
		public int? ErrorState { 
		    get{
		        return _ErrorState;
		    } 
		    set{
		        this.OnErrorStateChanging(value);
                this.SendPropertyChanging();
                this._ErrorState = value;
                this.SendPropertyChanged("ErrorState");
                this.OnErrorStateChanged();
		    }
		}
		
        partial void OnErrorProcedureChanging(string value);
        partial void OnErrorProcedureChanged();
		
		private string _ErrorProcedure;
		public string ErrorProcedure { 
		    get{
		        return _ErrorProcedure;
		    } 
		    set{
		        this.OnErrorProcedureChanging(value);
                this.SendPropertyChanging();
                this._ErrorProcedure = value;
                this.SendPropertyChanged("ErrorProcedure");
                this.OnErrorProcedureChanged();
		    }
		}
		
        partial void OnErrorLineChanging(int? value);
        partial void OnErrorLineChanged();
		
		private int? _ErrorLine;
		public int? ErrorLine { 
		    get{
		        return _ErrorLine;
		    } 
		    set{
		        this.OnErrorLineChanging(value);
                this.SendPropertyChanging();
                this._ErrorLine = value;
                this.SendPropertyChanged("ErrorLine");
                this.OnErrorLineChanged();
		    }
		}
		
        partial void OnErrorMessageChanging(string value);
        partial void OnErrorMessageChanged();
		
		private string _ErrorMessage;
		public string ErrorMessage { 
		    get{
		        return _ErrorMessage;
		    } 
		    set{
		        this.OnErrorMessageChanging(value);
                this.SendPropertyChanging();
                this._ErrorMessage = value;
                this.SendPropertyChanged("ErrorMessage");
                this.OnErrorMessageChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the Store table in the Northwind Database.
    /// This class is queryable through NorthwindDB.Store 
    /// </summary>

	public partial class Store: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public Store(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnCustomerIDChanging(int value);
        partial void OnCustomerIDChanged();
		
		private int _CustomerID;
		public int CustomerID { 
		    get{
		        return _CustomerID;
		    } 
		    set{
		        this.OnCustomerIDChanging(value);
                this.SendPropertyChanging();
                this._CustomerID = value;
                this.SendPropertyChanged("CustomerID");
                this.OnCustomerIDChanged();
		    }
		}
		
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
		
		private string _Name;
		public string Name { 
		    get{
		        return _Name;
		    } 
		    set{
		        this.OnNameChanging(value);
                this.SendPropertyChanging();
                this._Name = value;
                this.SendPropertyChanged("Name");
                this.OnNameChanged();
		    }
		}
		
        partial void OnSalesPersonIDChanging(int? value);
        partial void OnSalesPersonIDChanged();
		
		private int? _SalesPersonID;
		public int? SalesPersonID { 
		    get{
		        return _SalesPersonID;
		    } 
		    set{
		        this.OnSalesPersonIDChanging(value);
                this.SendPropertyChanging();
                this._SalesPersonID = value;
                this.SendPropertyChanged("SalesPersonID");
                this.OnSalesPersonIDChanged();
		    }
		}
		
        partial void OnDemographicsChanging(string value);
        partial void OnDemographicsChanged();
		
		private string _Demographics;
		public string Demographics { 
		    get{
		        return _Demographics;
		    } 
		    set{
		        this.OnDemographicsChanging(value);
                this.SendPropertyChanging();
                this._Demographics = value;
                this.SendPropertyChanged("Demographics");
                this.OnDemographicsChanged();
		    }
		}
		
        partial void OnrowguidChanging(Guid value);
        partial void OnrowguidChanged();
		
		private Guid _rowguid;
		public Guid rowguid { 
		    get{
		        return _rowguid;
		    } 
		    set{
		        this.OnrowguidChanging(value);
                this.SendPropertyChanging();
                this._rowguid = value;
                this.SendPropertyChanged("rowguid");
                this.OnrowguidChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Customer> Customers
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.Customers
                       where items.CustomerID == _CustomerID
                       select items;
            }
        }

        public IQueryable<SalesPerson> SalesPeople
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.SalesPeople
                       where items.SalesPersonID == _SalesPersonID
                       select items;
            }
        }

        public IQueryable<StoreContact> StoreContacts
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.StoreContacts
                       where items.CustomerID == _CustomerID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the ProductPhoto table in the Northwind Database.
    /// This class is queryable through NorthwindDB.ProductPhoto 
    /// </summary>

	public partial class ProductPhoto: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public ProductPhoto(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnProductPhotoIDChanging(int value);
        partial void OnProductPhotoIDChanged();
		
		private int _ProductPhotoID;
		public int ProductPhotoID { 
		    get{
		        return _ProductPhotoID;
		    } 
		    set{
		        this.OnProductPhotoIDChanging(value);
                this.SendPropertyChanging();
                this._ProductPhotoID = value;
                this.SendPropertyChanged("ProductPhotoID");
                this.OnProductPhotoIDChanged();
		    }
		}
		
        partial void OnThumbNailPhotoChanging(byte[] value);
        partial void OnThumbNailPhotoChanged();
		
		private byte[] _ThumbNailPhoto;
		public byte[] ThumbNailPhoto { 
		    get{
		        return _ThumbNailPhoto;
		    } 
		    set{
		        this.OnThumbNailPhotoChanging(value);
                this.SendPropertyChanging();
                this._ThumbNailPhoto = value;
                this.SendPropertyChanged("ThumbNailPhoto");
                this.OnThumbNailPhotoChanged();
		    }
		}
		
        partial void OnThumbnailPhotoFileNameChanging(string value);
        partial void OnThumbnailPhotoFileNameChanged();
		
		private string _ThumbnailPhotoFileName;
		public string ThumbnailPhotoFileName { 
		    get{
		        return _ThumbnailPhotoFileName;
		    } 
		    set{
		        this.OnThumbnailPhotoFileNameChanging(value);
                this.SendPropertyChanging();
                this._ThumbnailPhotoFileName = value;
                this.SendPropertyChanged("ThumbnailPhotoFileName");
                this.OnThumbnailPhotoFileNameChanged();
		    }
		}
		
        partial void OnLargePhotoChanging(byte[] value);
        partial void OnLargePhotoChanged();
		
		private byte[] _LargePhoto;
		public byte[] LargePhoto { 
		    get{
		        return _LargePhoto;
		    } 
		    set{
		        this.OnLargePhotoChanging(value);
                this.SendPropertyChanging();
                this._LargePhoto = value;
                this.SendPropertyChanged("LargePhoto");
                this.OnLargePhotoChanged();
		    }
		}
		
        partial void OnLargePhotoFileNameChanging(string value);
        partial void OnLargePhotoFileNameChanged();
		
		private string _LargePhotoFileName;
		public string LargePhotoFileName { 
		    get{
		        return _LargePhotoFileName;
		    } 
		    set{
		        this.OnLargePhotoFileNameChanging(value);
                this.SendPropertyChanging();
                this._LargePhotoFileName = value;
                this.SendPropertyChanged("LargePhotoFileName");
                this.OnLargePhotoFileNameChanged();
		    }
		}
		
        partial void OnModifiedDateChanging(DateTime value);
        partial void OnModifiedDateChanged();
		
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate { 
		    get{
		        return _ModifiedDate;
		    } 
		    set{
		        this.OnModifiedDateChanging(value);
                this.SendPropertyChanging();
                this._ModifiedDate = value;
                this.SendPropertyChanged("ModifiedDate");
                this.OnModifiedDateChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<ProductProductPhoto> ProductProductPhotos
        {
            get
            {
                  var db=new AdventureWorks.Data.NorthwindDB();
                  return from items in db.ProductProductPhotos
                       where items.ProductPhotoID == _ProductPhotoID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
}
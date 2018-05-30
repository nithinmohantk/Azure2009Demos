


using System;
using SubSonic.Schema;
using System.Collections.Generic;
using SubSonic.DataProviders;
using System.Data;

namespace AdventureWorks.Data {
	
        /// <summary>
        /// Table: ProductProductPhoto
        /// Primary Key: ProductID
        /// </summary>

        public class ProductProductPhotoTable: DatabaseTable {
            
            public ProductProductPhotoTable(IDataProvider provider):base("ProductProductPhoto",provider){
                ClassName = "ProductProductPhoto";
                SchemaName = "Production";
                

                Columns.Add(new DatabaseColumn("ProductID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ProductPhotoID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Primary", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ProductID{
                get{
                    return this.GetColumn("ProductID");
                }
            }
            				
   			public static string ProductIDColumn{
			      get{
        			return "ProductID";
      			}
		    }
           
            public IColumn ProductPhotoID{
                get{
                    return this.GetColumn("ProductPhotoID");
                }
            }
            				
   			public static string ProductPhotoIDColumn{
			      get{
        			return "ProductPhotoID";
      			}
		    }
           
            public IColumn Primary{
                get{
                    return this.GetColumn("Primary");
                }
            }
            				
   			public static string PrimaryColumn{
			      get{
        			return "Primary";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: StoreContact
        /// Primary Key: ContactID
        /// </summary>

        public class StoreContactTable: DatabaseTable {
            
            public StoreContactTable(IDataProvider provider):base("StoreContact",provider){
                ClassName = "StoreContact";
                SchemaName = "Sales";
                

                Columns.Add(new DatabaseColumn("CustomerID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ContactID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ContactTypeID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("rowguid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn CustomerID{
                get{
                    return this.GetColumn("CustomerID");
                }
            }
            				
   			public static string CustomerIDColumn{
			      get{
        			return "CustomerID";
      			}
		    }
           
            public IColumn ContactID{
                get{
                    return this.GetColumn("ContactID");
                }
            }
            				
   			public static string ContactIDColumn{
			      get{
        			return "ContactID";
      			}
		    }
           
            public IColumn ContactTypeID{
                get{
                    return this.GetColumn("ContactTypeID");
                }
            }
            				
   			public static string ContactTypeIDColumn{
			      get{
        			return "ContactTypeID";
      			}
		    }
           
            public IColumn rowguid{
                get{
                    return this.GetColumn("rowguid");
                }
            }
            				
   			public static string rowguidColumn{
			      get{
        			return "rowguid";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: Address
        /// Primary Key: AddressID
        /// </summary>

        public class AddressTable: DatabaseTable {
            
            public AddressTable(IDataProvider provider):base("Address",provider){
                ClassName = "Address";
                SchemaName = "Person";
                

                Columns.Add(new DatabaseColumn("AddressID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AddressLine1", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 60
                });

                Columns.Add(new DatabaseColumn("AddressLine2", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 60
                });

                Columns.Add(new DatabaseColumn("City", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 30
                });

                Columns.Add(new DatabaseColumn("StateProvinceID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PostalCode", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 15
                });

                Columns.Add(new DatabaseColumn("rowguid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn AddressID{
                get{
                    return this.GetColumn("AddressID");
                }
            }
            				
   			public static string AddressIDColumn{
			      get{
        			return "AddressID";
      			}
		    }
           
            public IColumn AddressLine1{
                get{
                    return this.GetColumn("AddressLine1");
                }
            }
            				
   			public static string AddressLine1Column{
			      get{
        			return "AddressLine1";
      			}
		    }
           
            public IColumn AddressLine2{
                get{
                    return this.GetColumn("AddressLine2");
                }
            }
            				
   			public static string AddressLine2Column{
			      get{
        			return "AddressLine2";
      			}
		    }
           
            public IColumn City{
                get{
                    return this.GetColumn("City");
                }
            }
            				
   			public static string CityColumn{
			      get{
        			return "City";
      			}
		    }
           
            public IColumn StateProvinceID{
                get{
                    return this.GetColumn("StateProvinceID");
                }
            }
            				
   			public static string StateProvinceIDColumn{
			      get{
        			return "StateProvinceID";
      			}
		    }
           
            public IColumn PostalCode{
                get{
                    return this.GetColumn("PostalCode");
                }
            }
            				
   			public static string PostalCodeColumn{
			      get{
        			return "PostalCode";
      			}
		    }
           
            public IColumn rowguid{
                get{
                    return this.GetColumn("rowguid");
                }
            }
            				
   			public static string rowguidColumn{
			      get{
        			return "rowguid";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: ProductReview
        /// Primary Key: ProductReviewID
        /// </summary>

        public class ProductReviewTable: DatabaseTable {
            
            public ProductReviewTable(IDataProvider provider):base("ProductReview",provider){
                ClassName = "ProductReview";
                SchemaName = "Production";
                

                Columns.Add(new DatabaseColumn("ProductReviewID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ProductID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ReviewerName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("ReviewDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("EmailAddress", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Rating", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Comments", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 3850
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ProductReviewID{
                get{
                    return this.GetColumn("ProductReviewID");
                }
            }
            				
   			public static string ProductReviewIDColumn{
			      get{
        			return "ProductReviewID";
      			}
		    }
           
            public IColumn ProductID{
                get{
                    return this.GetColumn("ProductID");
                }
            }
            				
   			public static string ProductIDColumn{
			      get{
        			return "ProductID";
      			}
		    }
           
            public IColumn ReviewerName{
                get{
                    return this.GetColumn("ReviewerName");
                }
            }
            				
   			public static string ReviewerNameColumn{
			      get{
        			return "ReviewerName";
      			}
		    }
           
            public IColumn ReviewDate{
                get{
                    return this.GetColumn("ReviewDate");
                }
            }
            				
   			public static string ReviewDateColumn{
			      get{
        			return "ReviewDate";
      			}
		    }
           
            public IColumn EmailAddress{
                get{
                    return this.GetColumn("EmailAddress");
                }
            }
            				
   			public static string EmailAddressColumn{
			      get{
        			return "EmailAddress";
      			}
		    }
           
            public IColumn Rating{
                get{
                    return this.GetColumn("Rating");
                }
            }
            				
   			public static string RatingColumn{
			      get{
        			return "Rating";
      			}
		    }
           
            public IColumn Comments{
                get{
                    return this.GetColumn("Comments");
                }
            }
            				
   			public static string CommentsColumn{
			      get{
        			return "Comments";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TransactionHistory
        /// Primary Key: TransactionID
        /// </summary>

        public class TransactionHistoryTable: DatabaseTable {
            
            public TransactionHistoryTable(IDataProvider provider):base("TransactionHistory",provider){
                ClassName = "TransactionHistory";
                SchemaName = "Production";
                

                Columns.Add(new DatabaseColumn("TransactionID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ProductID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ReferenceOrderID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ReferenceOrderLineID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("TransactionDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("TransactionType", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1
                });

                Columns.Add(new DatabaseColumn("Quantity", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ActualCost", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn TransactionID{
                get{
                    return this.GetColumn("TransactionID");
                }
            }
            				
   			public static string TransactionIDColumn{
			      get{
        			return "TransactionID";
      			}
		    }
           
            public IColumn ProductID{
                get{
                    return this.GetColumn("ProductID");
                }
            }
            				
   			public static string ProductIDColumn{
			      get{
        			return "ProductID";
      			}
		    }
           
            public IColumn ReferenceOrderID{
                get{
                    return this.GetColumn("ReferenceOrderID");
                }
            }
            				
   			public static string ReferenceOrderIDColumn{
			      get{
        			return "ReferenceOrderID";
      			}
		    }
           
            public IColumn ReferenceOrderLineID{
                get{
                    return this.GetColumn("ReferenceOrderLineID");
                }
            }
            				
   			public static string ReferenceOrderLineIDColumn{
			      get{
        			return "ReferenceOrderLineID";
      			}
		    }
           
            public IColumn TransactionDate{
                get{
                    return this.GetColumn("TransactionDate");
                }
            }
            				
   			public static string TransactionDateColumn{
			      get{
        			return "TransactionDate";
      			}
		    }
           
            public IColumn TransactionType{
                get{
                    return this.GetColumn("TransactionType");
                }
            }
            				
   			public static string TransactionTypeColumn{
			      get{
        			return "TransactionType";
      			}
		    }
           
            public IColumn Quantity{
                get{
                    return this.GetColumn("Quantity");
                }
            }
            				
   			public static string QuantityColumn{
			      get{
        			return "Quantity";
      			}
		    }
           
            public IColumn ActualCost{
                get{
                    return this.GetColumn("ActualCost");
                }
            }
            				
   			public static string ActualCostColumn{
			      get{
        			return "ActualCost";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: AddressType
        /// Primary Key: AddressTypeID
        /// </summary>

        public class AddressTypeTable: DatabaseTable {
            
            public AddressTypeTable(IDataProvider provider):base("AddressType",provider){
                ClassName = "AddressType";
                SchemaName = "Person";
                

                Columns.Add(new DatabaseColumn("AddressTypeID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("rowguid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn AddressTypeID{
                get{
                    return this.GetColumn("AddressTypeID");
                }
            }
            				
   			public static string AddressTypeIDColumn{
			      get{
        			return "AddressTypeID";
      			}
		    }
           
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
            				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
           
            public IColumn rowguid{
                get{
                    return this.GetColumn("rowguid");
                }
            }
            				
   			public static string rowguidColumn{
			      get{
        			return "rowguid";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: ProductSubcategory
        /// Primary Key: ProductSubcategoryID
        /// </summary>

        public class ProductSubcategoryTable: DatabaseTable {
            
            public ProductSubcategoryTable(IDataProvider provider):base("ProductSubcategory",provider){
                ClassName = "ProductSubcategory";
                SchemaName = "Production";
                

                Columns.Add(new DatabaseColumn("ProductSubcategoryID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ProductCategoryID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("rowguid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ProductSubcategoryID{
                get{
                    return this.GetColumn("ProductSubcategoryID");
                }
            }
            				
   			public static string ProductSubcategoryIDColumn{
			      get{
        			return "ProductSubcategoryID";
      			}
		    }
           
            public IColumn ProductCategoryID{
                get{
                    return this.GetColumn("ProductCategoryID");
                }
            }
            				
   			public static string ProductCategoryIDColumn{
			      get{
        			return "ProductCategoryID";
      			}
		    }
           
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
            				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
           
            public IColumn rowguid{
                get{
                    return this.GetColumn("rowguid");
                }
            }
            				
   			public static string rowguidColumn{
			      get{
        			return "rowguid";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: AWBuildVersion
        /// Primary Key: SystemInformationID
        /// </summary>

        public class AWBuildVersionTable: DatabaseTable {
            
            public AWBuildVersionTable(IDataProvider provider):base("AWBuildVersion",provider){
                ClassName = "AWBuildVersion";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("SystemInformationID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Byte,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Database Version", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 25
                });

                Columns.Add(new DatabaseColumn("VersionDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn SystemInformationID{
                get{
                    return this.GetColumn("SystemInformationID");
                }
            }
            				
   			public static string SystemInformationIDColumn{
			      get{
        			return "SystemInformationID";
      			}
		    }
           
            public IColumn DatabaseVersion{
                get{
                    return this.GetColumn("Database Version");
                }
            }
            				
   			public static string DatabaseVersionColumn{
			      get{
        			return "Database Version";
      			}
		    }
           
            public IColumn VersionDate{
                get{
                    return this.GetColumn("VersionDate");
                }
            }
            				
   			public static string VersionDateColumn{
			      get{
        			return "VersionDate";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TransactionHistoryArchive
        /// Primary Key: TransactionID
        /// </summary>

        public class TransactionHistoryArchiveTable: DatabaseTable {
            
            public TransactionHistoryArchiveTable(IDataProvider provider):base("TransactionHistoryArchive",provider){
                ClassName = "TransactionHistoryArchive";
                SchemaName = "Production";
                

                Columns.Add(new DatabaseColumn("TransactionID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ProductID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ReferenceOrderID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ReferenceOrderLineID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("TransactionDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("TransactionType", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1
                });

                Columns.Add(new DatabaseColumn("Quantity", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ActualCost", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn TransactionID{
                get{
                    return this.GetColumn("TransactionID");
                }
            }
            				
   			public static string TransactionIDColumn{
			      get{
        			return "TransactionID";
      			}
		    }
           
            public IColumn ProductID{
                get{
                    return this.GetColumn("ProductID");
                }
            }
            				
   			public static string ProductIDColumn{
			      get{
        			return "ProductID";
      			}
		    }
           
            public IColumn ReferenceOrderID{
                get{
                    return this.GetColumn("ReferenceOrderID");
                }
            }
            				
   			public static string ReferenceOrderIDColumn{
			      get{
        			return "ReferenceOrderID";
      			}
		    }
           
            public IColumn ReferenceOrderLineID{
                get{
                    return this.GetColumn("ReferenceOrderLineID");
                }
            }
            				
   			public static string ReferenceOrderLineIDColumn{
			      get{
        			return "ReferenceOrderLineID";
      			}
		    }
           
            public IColumn TransactionDate{
                get{
                    return this.GetColumn("TransactionDate");
                }
            }
            				
   			public static string TransactionDateColumn{
			      get{
        			return "TransactionDate";
      			}
		    }
           
            public IColumn TransactionType{
                get{
                    return this.GetColumn("TransactionType");
                }
            }
            				
   			public static string TransactionTypeColumn{
			      get{
        			return "TransactionType";
      			}
		    }
           
            public IColumn Quantity{
                get{
                    return this.GetColumn("Quantity");
                }
            }
            				
   			public static string QuantityColumn{
			      get{
        			return "Quantity";
      			}
		    }
           
            public IColumn ActualCost{
                get{
                    return this.GetColumn("ActualCost");
                }
            }
            				
   			public static string ActualCostColumn{
			      get{
        			return "ActualCost";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: ProductVendor
        /// Primary Key: ProductID
        /// </summary>

        public class ProductVendorTable: DatabaseTable {
            
            public ProductVendorTable(IDataProvider provider):base("ProductVendor",provider){
                ClassName = "ProductVendor";
                SchemaName = "Purchasing";
                

                Columns.Add(new DatabaseColumn("ProductID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("VendorID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AverageLeadTime", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StandardPrice", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LastReceiptCost", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LastReceiptDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MinOrderQty", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MaxOrderQty", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("OnOrderQty", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UnitMeasureCode", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 3
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ProductID{
                get{
                    return this.GetColumn("ProductID");
                }
            }
            				
   			public static string ProductIDColumn{
			      get{
        			return "ProductID";
      			}
		    }
           
            public IColumn VendorID{
                get{
                    return this.GetColumn("VendorID");
                }
            }
            				
   			public static string VendorIDColumn{
			      get{
        			return "VendorID";
      			}
		    }
           
            public IColumn AverageLeadTime{
                get{
                    return this.GetColumn("AverageLeadTime");
                }
            }
            				
   			public static string AverageLeadTimeColumn{
			      get{
        			return "AverageLeadTime";
      			}
		    }
           
            public IColumn StandardPrice{
                get{
                    return this.GetColumn("StandardPrice");
                }
            }
            				
   			public static string StandardPriceColumn{
			      get{
        			return "StandardPrice";
      			}
		    }
           
            public IColumn LastReceiptCost{
                get{
                    return this.GetColumn("LastReceiptCost");
                }
            }
            				
   			public static string LastReceiptCostColumn{
			      get{
        			return "LastReceiptCost";
      			}
		    }
           
            public IColumn LastReceiptDate{
                get{
                    return this.GetColumn("LastReceiptDate");
                }
            }
            				
   			public static string LastReceiptDateColumn{
			      get{
        			return "LastReceiptDate";
      			}
		    }
           
            public IColumn MinOrderQty{
                get{
                    return this.GetColumn("MinOrderQty");
                }
            }
            				
   			public static string MinOrderQtyColumn{
			      get{
        			return "MinOrderQty";
      			}
		    }
           
            public IColumn MaxOrderQty{
                get{
                    return this.GetColumn("MaxOrderQty");
                }
            }
            				
   			public static string MaxOrderQtyColumn{
			      get{
        			return "MaxOrderQty";
      			}
		    }
           
            public IColumn OnOrderQty{
                get{
                    return this.GetColumn("OnOrderQty");
                }
            }
            				
   			public static string OnOrderQtyColumn{
			      get{
        			return "OnOrderQty";
      			}
		    }
           
            public IColumn UnitMeasureCode{
                get{
                    return this.GetColumn("UnitMeasureCode");
                }
            }
            				
   			public static string UnitMeasureCodeColumn{
			      get{
        			return "UnitMeasureCode";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: BillOfMaterials
        /// Primary Key: BillOfMaterialsID
        /// </summary>

        public class BillOfMaterialsTable: DatabaseTable {
            
            public BillOfMaterialsTable(IDataProvider provider):base("BillOfMaterials",provider){
                ClassName = "BillOfMaterial";
                SchemaName = "Production";
                

                Columns.Add(new DatabaseColumn("BillOfMaterialsID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ProductAssemblyID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ComponentID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StartDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("EndDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UnitMeasureCode", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 3
                });

                Columns.Add(new DatabaseColumn("BOMLevel", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int16,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PerAssemblyQty", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Decimal,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn BillOfMaterialsID{
                get{
                    return this.GetColumn("BillOfMaterialsID");
                }
            }
            				
   			public static string BillOfMaterialsIDColumn{
			      get{
        			return "BillOfMaterialsID";
      			}
		    }
           
            public IColumn ProductAssemblyID{
                get{
                    return this.GetColumn("ProductAssemblyID");
                }
            }
            				
   			public static string ProductAssemblyIDColumn{
			      get{
        			return "ProductAssemblyID";
      			}
		    }
           
            public IColumn ComponentID{
                get{
                    return this.GetColumn("ComponentID");
                }
            }
            				
   			public static string ComponentIDColumn{
			      get{
        			return "ComponentID";
      			}
		    }
           
            public IColumn StartDate{
                get{
                    return this.GetColumn("StartDate");
                }
            }
            				
   			public static string StartDateColumn{
			      get{
        			return "StartDate";
      			}
		    }
           
            public IColumn EndDate{
                get{
                    return this.GetColumn("EndDate");
                }
            }
            				
   			public static string EndDateColumn{
			      get{
        			return "EndDate";
      			}
		    }
           
            public IColumn UnitMeasureCode{
                get{
                    return this.GetColumn("UnitMeasureCode");
                }
            }
            				
   			public static string UnitMeasureCodeColumn{
			      get{
        			return "UnitMeasureCode";
      			}
		    }
           
            public IColumn BOMLevel{
                get{
                    return this.GetColumn("BOMLevel");
                }
            }
            				
   			public static string BOMLevelColumn{
			      get{
        			return "BOMLevel";
      			}
		    }
           
            public IColumn PerAssemblyQty{
                get{
                    return this.GetColumn("PerAssemblyQty");
                }
            }
            				
   			public static string PerAssemblyQtyColumn{
			      get{
        			return "PerAssemblyQty";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: UnitMeasure
        /// Primary Key: UnitMeasureCode
        /// </summary>

        public class UnitMeasureTable: DatabaseTable {
            
            public UnitMeasureTable(IDataProvider provider):base("UnitMeasure",provider){
                ClassName = "UnitMeasure";
                SchemaName = "Production";
                

                Columns.Add(new DatabaseColumn("UnitMeasureCode", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 3
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn UnitMeasureCode{
                get{
                    return this.GetColumn("UnitMeasureCode");
                }
            }
            				
   			public static string UnitMeasureCodeColumn{
			      get{
        			return "UnitMeasureCode";
      			}
		    }
           
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
            				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: Vendor
        /// Primary Key: VendorID
        /// </summary>

        public class VendorTable: DatabaseTable {
            
            public VendorTable(IDataProvider provider):base("Vendor",provider){
                ClassName = "Vendor";
                SchemaName = "Purchasing";
                

                Columns.Add(new DatabaseColumn("VendorID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AccountNumber", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 15
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("CreditRating", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Byte,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PreferredVendorStatus", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ActiveFlag", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PurchasingWebServiceURL", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1024
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn VendorID{
                get{
                    return this.GetColumn("VendorID");
                }
            }
            				
   			public static string VendorIDColumn{
			      get{
        			return "VendorID";
      			}
		    }
           
            public IColumn AccountNumber{
                get{
                    return this.GetColumn("AccountNumber");
                }
            }
            				
   			public static string AccountNumberColumn{
			      get{
        			return "AccountNumber";
      			}
		    }
           
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
            				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
           
            public IColumn CreditRating{
                get{
                    return this.GetColumn("CreditRating");
                }
            }
            				
   			public static string CreditRatingColumn{
			      get{
        			return "CreditRating";
      			}
		    }
           
            public IColumn PreferredVendorStatus{
                get{
                    return this.GetColumn("PreferredVendorStatus");
                }
            }
            				
   			public static string PreferredVendorStatusColumn{
			      get{
        			return "PreferredVendorStatus";
      			}
		    }
           
            public IColumn ActiveFlag{
                get{
                    return this.GetColumn("ActiveFlag");
                }
            }
            				
   			public static string ActiveFlagColumn{
			      get{
        			return "ActiveFlag";
      			}
		    }
           
            public IColumn PurchasingWebServiceURL{
                get{
                    return this.GetColumn("PurchasingWebServiceURL");
                }
            }
            				
   			public static string PurchasingWebServiceURLColumn{
			      get{
        			return "PurchasingWebServiceURL";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: PurchaseOrderDetail
        /// Primary Key: PurchaseOrderDetailID
        /// </summary>

        public class PurchaseOrderDetailTable: DatabaseTable {
            
            public PurchaseOrderDetailTable(IDataProvider provider):base("PurchaseOrderDetail",provider){
                ClassName = "PurchaseOrderDetail";
                SchemaName = "Purchasing";
                

                Columns.Add(new DatabaseColumn("PurchaseOrderID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PurchaseOrderDetailID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DueDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("OrderQty", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int16,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ProductID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UnitPrice", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LineTotal", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ReceivedQty", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Decimal,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("RejectedQty", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Decimal,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StockedQty", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Decimal,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn PurchaseOrderID{
                get{
                    return this.GetColumn("PurchaseOrderID");
                }
            }
            				
   			public static string PurchaseOrderIDColumn{
			      get{
        			return "PurchaseOrderID";
      			}
		    }
           
            public IColumn PurchaseOrderDetailID{
                get{
                    return this.GetColumn("PurchaseOrderDetailID");
                }
            }
            				
   			public static string PurchaseOrderDetailIDColumn{
			      get{
        			return "PurchaseOrderDetailID";
      			}
		    }
           
            public IColumn DueDate{
                get{
                    return this.GetColumn("DueDate");
                }
            }
            				
   			public static string DueDateColumn{
			      get{
        			return "DueDate";
      			}
		    }
           
            public IColumn OrderQty{
                get{
                    return this.GetColumn("OrderQty");
                }
            }
            				
   			public static string OrderQtyColumn{
			      get{
        			return "OrderQty";
      			}
		    }
           
            public IColumn ProductID{
                get{
                    return this.GetColumn("ProductID");
                }
            }
            				
   			public static string ProductIDColumn{
			      get{
        			return "ProductID";
      			}
		    }
           
            public IColumn UnitPrice{
                get{
                    return this.GetColumn("UnitPrice");
                }
            }
            				
   			public static string UnitPriceColumn{
			      get{
        			return "UnitPrice";
      			}
		    }
           
            public IColumn LineTotal{
                get{
                    return this.GetColumn("LineTotal");
                }
            }
            				
   			public static string LineTotalColumn{
			      get{
        			return "LineTotal";
      			}
		    }
           
            public IColumn ReceivedQty{
                get{
                    return this.GetColumn("ReceivedQty");
                }
            }
            				
   			public static string ReceivedQtyColumn{
			      get{
        			return "ReceivedQty";
      			}
		    }
           
            public IColumn RejectedQty{
                get{
                    return this.GetColumn("RejectedQty");
                }
            }
            				
   			public static string RejectedQtyColumn{
			      get{
        			return "RejectedQty";
      			}
		    }
           
            public IColumn StockedQty{
                get{
                    return this.GetColumn("StockedQty");
                }
            }
            				
   			public static string StockedQtyColumn{
			      get{
        			return "StockedQty";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: Contact
        /// Primary Key: ContactID
        /// </summary>

        public class ContactTable: DatabaseTable {
            
            public ContactTable(IDataProvider provider):base("Contact",provider){
                ClassName = "Contact";
                SchemaName = "Person";
                

                Columns.Add(new DatabaseColumn("ContactID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("NameStyle", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Title", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 8
                });

                Columns.Add(new DatabaseColumn("FirstName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("MiddleName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("LastName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Suffix", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 10
                });

                Columns.Add(new DatabaseColumn("EmailAddress", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("EmailPromotion", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Phone", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 25
                });

                Columns.Add(new DatabaseColumn("PasswordHash", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 40
                });

                Columns.Add(new DatabaseColumn("PasswordSalt", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 10
                });

                Columns.Add(new DatabaseColumn("AdditionalContactInfo", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Xml,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("rowguid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ContactID{
                get{
                    return this.GetColumn("ContactID");
                }
            }
            				
   			public static string ContactIDColumn{
			      get{
        			return "ContactID";
      			}
		    }
           
            public IColumn NameStyle{
                get{
                    return this.GetColumn("NameStyle");
                }
            }
            				
   			public static string NameStyleColumn{
			      get{
        			return "NameStyle";
      			}
		    }
           
            public IColumn Title{
                get{
                    return this.GetColumn("Title");
                }
            }
            				
   			public static string TitleColumn{
			      get{
        			return "Title";
      			}
		    }
           
            public IColumn FirstName{
                get{
                    return this.GetColumn("FirstName");
                }
            }
            				
   			public static string FirstNameColumn{
			      get{
        			return "FirstName";
      			}
		    }
           
            public IColumn MiddleName{
                get{
                    return this.GetColumn("MiddleName");
                }
            }
            				
   			public static string MiddleNameColumn{
			      get{
        			return "MiddleName";
      			}
		    }
           
            public IColumn LastName{
                get{
                    return this.GetColumn("LastName");
                }
            }
            				
   			public static string LastNameColumn{
			      get{
        			return "LastName";
      			}
		    }
           
            public IColumn Suffix{
                get{
                    return this.GetColumn("Suffix");
                }
            }
            				
   			public static string SuffixColumn{
			      get{
        			return "Suffix";
      			}
		    }
           
            public IColumn EmailAddress{
                get{
                    return this.GetColumn("EmailAddress");
                }
            }
            				
   			public static string EmailAddressColumn{
			      get{
        			return "EmailAddress";
      			}
		    }
           
            public IColumn EmailPromotion{
                get{
                    return this.GetColumn("EmailPromotion");
                }
            }
            				
   			public static string EmailPromotionColumn{
			      get{
        			return "EmailPromotion";
      			}
		    }
           
            public IColumn Phone{
                get{
                    return this.GetColumn("Phone");
                }
            }
            				
   			public static string PhoneColumn{
			      get{
        			return "Phone";
      			}
		    }
           
            public IColumn PasswordHash{
                get{
                    return this.GetColumn("PasswordHash");
                }
            }
            				
   			public static string PasswordHashColumn{
			      get{
        			return "PasswordHash";
      			}
		    }
           
            public IColumn PasswordSalt{
                get{
                    return this.GetColumn("PasswordSalt");
                }
            }
            				
   			public static string PasswordSaltColumn{
			      get{
        			return "PasswordSalt";
      			}
		    }
           
            public IColumn AdditionalContactInfo{
                get{
                    return this.GetColumn("AdditionalContactInfo");
                }
            }
            				
   			public static string AdditionalContactInfoColumn{
			      get{
        			return "AdditionalContactInfo";
      			}
		    }
           
            public IColumn rowguid{
                get{
                    return this.GetColumn("rowguid");
                }
            }
            				
   			public static string rowguidColumn{
			      get{
        			return "rowguid";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: VendorAddress
        /// Primary Key: AddressID
        /// </summary>

        public class VendorAddressTable: DatabaseTable {
            
            public VendorAddressTable(IDataProvider provider):base("VendorAddress",provider){
                ClassName = "VendorAddress";
                SchemaName = "Purchasing";
                

                Columns.Add(new DatabaseColumn("VendorID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AddressID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AddressTypeID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn VendorID{
                get{
                    return this.GetColumn("VendorID");
                }
            }
            				
   			public static string VendorIDColumn{
			      get{
        			return "VendorID";
      			}
		    }
           
            public IColumn AddressID{
                get{
                    return this.GetColumn("AddressID");
                }
            }
            				
   			public static string AddressIDColumn{
			      get{
        			return "AddressID";
      			}
		    }
           
            public IColumn AddressTypeID{
                get{
                    return this.GetColumn("AddressTypeID");
                }
            }
            				
   			public static string AddressTypeIDColumn{
			      get{
        			return "AddressTypeID";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: VendorContact
        /// Primary Key: ContactID
        /// </summary>

        public class VendorContactTable: DatabaseTable {
            
            public VendorContactTable(IDataProvider provider):base("VendorContact",provider){
                ClassName = "VendorContact";
                SchemaName = "Purchasing";
                

                Columns.Add(new DatabaseColumn("VendorID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ContactID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ContactTypeID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn VendorID{
                get{
                    return this.GetColumn("VendorID");
                }
            }
            				
   			public static string VendorIDColumn{
			      get{
        			return "VendorID";
      			}
		    }
           
            public IColumn ContactID{
                get{
                    return this.GetColumn("ContactID");
                }
            }
            				
   			public static string ContactIDColumn{
			      get{
        			return "ContactID";
      			}
		    }
           
            public IColumn ContactTypeID{
                get{
                    return this.GetColumn("ContactTypeID");
                }
            }
            				
   			public static string ContactTypeIDColumn{
			      get{
        			return "ContactTypeID";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: PurchaseOrderHeader
        /// Primary Key: PurchaseOrderID
        /// </summary>

        public class PurchaseOrderHeaderTable: DatabaseTable {
            
            public PurchaseOrderHeaderTable(IDataProvider provider):base("PurchaseOrderHeader",provider){
                ClassName = "PurchaseOrderHeader";
                SchemaName = "Purchasing";
                

                Columns.Add(new DatabaseColumn("PurchaseOrderID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("RevisionNumber", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Byte,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Status", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Byte,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("EmployeeID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("VendorID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ShipMethodID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("OrderDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ShipDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SubTotal", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("TaxAmt", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Freight", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("TotalDue", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn PurchaseOrderID{
                get{
                    return this.GetColumn("PurchaseOrderID");
                }
            }
            				
   			public static string PurchaseOrderIDColumn{
			      get{
        			return "PurchaseOrderID";
      			}
		    }
           
            public IColumn RevisionNumber{
                get{
                    return this.GetColumn("RevisionNumber");
                }
            }
            				
   			public static string RevisionNumberColumn{
			      get{
        			return "RevisionNumber";
      			}
		    }
           
            public IColumn Status{
                get{
                    return this.GetColumn("Status");
                }
            }
            				
   			public static string StatusColumn{
			      get{
        			return "Status";
      			}
		    }
           
            public IColumn EmployeeID{
                get{
                    return this.GetColumn("EmployeeID");
                }
            }
            				
   			public static string EmployeeIDColumn{
			      get{
        			return "EmployeeID";
      			}
		    }
           
            public IColumn VendorID{
                get{
                    return this.GetColumn("VendorID");
                }
            }
            				
   			public static string VendorIDColumn{
			      get{
        			return "VendorID";
      			}
		    }
           
            public IColumn ShipMethodID{
                get{
                    return this.GetColumn("ShipMethodID");
                }
            }
            				
   			public static string ShipMethodIDColumn{
			      get{
        			return "ShipMethodID";
      			}
		    }
           
            public IColumn OrderDate{
                get{
                    return this.GetColumn("OrderDate");
                }
            }
            				
   			public static string OrderDateColumn{
			      get{
        			return "OrderDate";
      			}
		    }
           
            public IColumn ShipDate{
                get{
                    return this.GetColumn("ShipDate");
                }
            }
            				
   			public static string ShipDateColumn{
			      get{
        			return "ShipDate";
      			}
		    }
           
            public IColumn SubTotal{
                get{
                    return this.GetColumn("SubTotal");
                }
            }
            				
   			public static string SubTotalColumn{
			      get{
        			return "SubTotal";
      			}
		    }
           
            public IColumn TaxAmt{
                get{
                    return this.GetColumn("TaxAmt");
                }
            }
            				
   			public static string TaxAmtColumn{
			      get{
        			return "TaxAmt";
      			}
		    }
           
            public IColumn Freight{
                get{
                    return this.GetColumn("Freight");
                }
            }
            				
   			public static string FreightColumn{
			      get{
        			return "Freight";
      			}
		    }
           
            public IColumn TotalDue{
                get{
                    return this.GetColumn("TotalDue");
                }
            }
            				
   			public static string TotalDueColumn{
			      get{
        			return "TotalDue";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: ContactCreditCard
        /// Primary Key: ContactID
        /// </summary>

        public class ContactCreditCardTable: DatabaseTable {
            
            public ContactCreditCardTable(IDataProvider provider):base("ContactCreditCard",provider){
                ClassName = "ContactCreditCard";
                SchemaName = "Sales";
                

                Columns.Add(new DatabaseColumn("ContactID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreditCardID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ContactID{
                get{
                    return this.GetColumn("ContactID");
                }
            }
            				
   			public static string ContactIDColumn{
			      get{
        			return "ContactID";
      			}
		    }
           
            public IColumn CreditCardID{
                get{
                    return this.GetColumn("CreditCardID");
                }
            }
            				
   			public static string CreditCardIDColumn{
			      get{
        			return "CreditCardID";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: WorkOrder
        /// Primary Key: WorkOrderID
        /// </summary>

        public class WorkOrderTable: DatabaseTable {
            
            public WorkOrderTable(IDataProvider provider):base("WorkOrder",provider){
                ClassName = "WorkOrder";
                SchemaName = "Production";
                

                Columns.Add(new DatabaseColumn("WorkOrderID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ProductID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("OrderQty", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StockedQty", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ScrappedQty", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int16,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StartDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("EndDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DueDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ScrapReasonID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int16,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn WorkOrderID{
                get{
                    return this.GetColumn("WorkOrderID");
                }
            }
            				
   			public static string WorkOrderIDColumn{
			      get{
        			return "WorkOrderID";
      			}
		    }
           
            public IColumn ProductID{
                get{
                    return this.GetColumn("ProductID");
                }
            }
            				
   			public static string ProductIDColumn{
			      get{
        			return "ProductID";
      			}
		    }
           
            public IColumn OrderQty{
                get{
                    return this.GetColumn("OrderQty");
                }
            }
            				
   			public static string OrderQtyColumn{
			      get{
        			return "OrderQty";
      			}
		    }
           
            public IColumn StockedQty{
                get{
                    return this.GetColumn("StockedQty");
                }
            }
            				
   			public static string StockedQtyColumn{
			      get{
        			return "StockedQty";
      			}
		    }
           
            public IColumn ScrappedQty{
                get{
                    return this.GetColumn("ScrappedQty");
                }
            }
            				
   			public static string ScrappedQtyColumn{
			      get{
        			return "ScrappedQty";
      			}
		    }
           
            public IColumn StartDate{
                get{
                    return this.GetColumn("StartDate");
                }
            }
            				
   			public static string StartDateColumn{
			      get{
        			return "StartDate";
      			}
		    }
           
            public IColumn EndDate{
                get{
                    return this.GetColumn("EndDate");
                }
            }
            				
   			public static string EndDateColumn{
			      get{
        			return "EndDate";
      			}
		    }
           
            public IColumn DueDate{
                get{
                    return this.GetColumn("DueDate");
                }
            }
            				
   			public static string DueDateColumn{
			      get{
        			return "DueDate";
      			}
		    }
           
            public IColumn ScrapReasonID{
                get{
                    return this.GetColumn("ScrapReasonID");
                }
            }
            				
   			public static string ScrapReasonIDColumn{
			      get{
        			return "ScrapReasonID";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: ContactType
        /// Primary Key: ContactTypeID
        /// </summary>

        public class ContactTypeTable: DatabaseTable {
            
            public ContactTypeTable(IDataProvider provider):base("ContactType",provider){
                ClassName = "ContactType";
                SchemaName = "Person";
                

                Columns.Add(new DatabaseColumn("ContactTypeID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ContactTypeID{
                get{
                    return this.GetColumn("ContactTypeID");
                }
            }
            				
   			public static string ContactTypeIDColumn{
			      get{
        			return "ContactTypeID";
      			}
		    }
           
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
            				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: CountryRegionCurrency
        /// Primary Key: CountryRegionCode
        /// </summary>

        public class CountryRegionCurrencyTable: DatabaseTable {
            
            public CountryRegionCurrencyTable(IDataProvider provider):base("CountryRegionCurrency",provider){
                ClassName = "CountryRegionCurrency";
                SchemaName = "Sales";
                

                Columns.Add(new DatabaseColumn("CountryRegionCode", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 3
                });

                Columns.Add(new DatabaseColumn("CurrencyCode", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 3
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn CountryRegionCode{
                get{
                    return this.GetColumn("CountryRegionCode");
                }
            }
            				
   			public static string CountryRegionCodeColumn{
			      get{
        			return "CountryRegionCode";
      			}
		    }
           
            public IColumn CurrencyCode{
                get{
                    return this.GetColumn("CurrencyCode");
                }
            }
            				
   			public static string CurrencyCodeColumn{
			      get{
        			return "CurrencyCode";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: WorkOrderRouting
        /// Primary Key: OperationSequence
        /// </summary>

        public class WorkOrderRoutingTable: DatabaseTable {
            
            public WorkOrderRoutingTable(IDataProvider provider):base("WorkOrderRouting",provider){
                ClassName = "WorkOrderRouting";
                SchemaName = "Production";
                

                Columns.Add(new DatabaseColumn("WorkOrderID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ProductID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("OperationSequence", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int16,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LocationID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int16,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ScheduledStartDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ScheduledEndDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ActualStartDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ActualEndDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ActualResourceHrs", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Decimal,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PlannedCost", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ActualCost", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn WorkOrderID{
                get{
                    return this.GetColumn("WorkOrderID");
                }
            }
            				
   			public static string WorkOrderIDColumn{
			      get{
        			return "WorkOrderID";
      			}
		    }
           
            public IColumn ProductID{
                get{
                    return this.GetColumn("ProductID");
                }
            }
            				
   			public static string ProductIDColumn{
			      get{
        			return "ProductID";
      			}
		    }
           
            public IColumn OperationSequence{
                get{
                    return this.GetColumn("OperationSequence");
                }
            }
            				
   			public static string OperationSequenceColumn{
			      get{
        			return "OperationSequence";
      			}
		    }
           
            public IColumn LocationID{
                get{
                    return this.GetColumn("LocationID");
                }
            }
            				
   			public static string LocationIDColumn{
			      get{
        			return "LocationID";
      			}
		    }
           
            public IColumn ScheduledStartDate{
                get{
                    return this.GetColumn("ScheduledStartDate");
                }
            }
            				
   			public static string ScheduledStartDateColumn{
			      get{
        			return "ScheduledStartDate";
      			}
		    }
           
            public IColumn ScheduledEndDate{
                get{
                    return this.GetColumn("ScheduledEndDate");
                }
            }
            				
   			public static string ScheduledEndDateColumn{
			      get{
        			return "ScheduledEndDate";
      			}
		    }
           
            public IColumn ActualStartDate{
                get{
                    return this.GetColumn("ActualStartDate");
                }
            }
            				
   			public static string ActualStartDateColumn{
			      get{
        			return "ActualStartDate";
      			}
		    }
           
            public IColumn ActualEndDate{
                get{
                    return this.GetColumn("ActualEndDate");
                }
            }
            				
   			public static string ActualEndDateColumn{
			      get{
        			return "ActualEndDate";
      			}
		    }
           
            public IColumn ActualResourceHrs{
                get{
                    return this.GetColumn("ActualResourceHrs");
                }
            }
            				
   			public static string ActualResourceHrsColumn{
			      get{
        			return "ActualResourceHrs";
      			}
		    }
           
            public IColumn PlannedCost{
                get{
                    return this.GetColumn("PlannedCost");
                }
            }
            				
   			public static string PlannedCostColumn{
			      get{
        			return "PlannedCost";
      			}
		    }
           
            public IColumn ActualCost{
                get{
                    return this.GetColumn("ActualCost");
                }
            }
            				
   			public static string ActualCostColumn{
			      get{
        			return "ActualCost";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: CountryRegion
        /// Primary Key: CountryRegionCode
        /// </summary>

        public class CountryRegionTable: DatabaseTable {
            
            public CountryRegionTable(IDataProvider provider):base("CountryRegion",provider){
                ClassName = "CountryRegion";
                SchemaName = "Person";
                

                Columns.Add(new DatabaseColumn("CountryRegionCode", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 3
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn CountryRegionCode{
                get{
                    return this.GetColumn("CountryRegionCode");
                }
            }
            				
   			public static string CountryRegionCodeColumn{
			      get{
        			return "CountryRegionCode";
      			}
		    }
           
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
            				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: CreditCard
        /// Primary Key: CreditCardID
        /// </summary>

        public class CreditCardTable: DatabaseTable {
            
            public CreditCardTable(IDataProvider provider):base("CreditCard",provider){
                ClassName = "CreditCard";
                SchemaName = "Sales";
                

                Columns.Add(new DatabaseColumn("CreditCardID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CardType", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("CardNumber", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 25
                });

                Columns.Add(new DatabaseColumn("ExpMonth", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Byte,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ExpYear", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int16,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn CreditCardID{
                get{
                    return this.GetColumn("CreditCardID");
                }
            }
            				
   			public static string CreditCardIDColumn{
			      get{
        			return "CreditCardID";
      			}
		    }
           
            public IColumn CardType{
                get{
                    return this.GetColumn("CardType");
                }
            }
            				
   			public static string CardTypeColumn{
			      get{
        			return "CardType";
      			}
		    }
           
            public IColumn CardNumber{
                get{
                    return this.GetColumn("CardNumber");
                }
            }
            				
   			public static string CardNumberColumn{
			      get{
        			return "CardNumber";
      			}
		    }
           
            public IColumn ExpMonth{
                get{
                    return this.GetColumn("ExpMonth");
                }
            }
            				
   			public static string ExpMonthColumn{
			      get{
        			return "ExpMonth";
      			}
		    }
           
            public IColumn ExpYear{
                get{
                    return this.GetColumn("ExpYear");
                }
            }
            				
   			public static string ExpYearColumn{
			      get{
        			return "ExpYear";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: Culture
        /// Primary Key: CultureID
        /// </summary>

        public class CultureTable: DatabaseTable {
            
            public CultureTable(IDataProvider provider):base("Culture",provider){
                ClassName = "Culture";
                SchemaName = "Production";
                

                Columns.Add(new DatabaseColumn("CultureID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 6
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn CultureID{
                get{
                    return this.GetColumn("CultureID");
                }
            }
            				
   			public static string CultureIDColumn{
			      get{
        			return "CultureID";
      			}
		    }
           
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
            				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: Currency
        /// Primary Key: CurrencyCode
        /// </summary>

        public class CurrencyTable: DatabaseTable {
            
            public CurrencyTable(IDataProvider provider):base("Currency",provider){
                ClassName = "Currency";
                SchemaName = "Sales";
                

                Columns.Add(new DatabaseColumn("CurrencyCode", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 3
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn CurrencyCode{
                get{
                    return this.GetColumn("CurrencyCode");
                }
            }
            				
   			public static string CurrencyCodeColumn{
			      get{
        			return "CurrencyCode";
      			}
		    }
           
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
            				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: SalesOrderDetail
        /// Primary Key: SalesOrderDetailID
        /// </summary>

        public class SalesOrderDetailTable: DatabaseTable {
            
            public SalesOrderDetailTable(IDataProvider provider):base("SalesOrderDetail",provider){
                ClassName = "SalesOrderDetail";
                SchemaName = "Sales";
                

                Columns.Add(new DatabaseColumn("SalesOrderID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SalesOrderDetailID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CarrierTrackingNumber", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 25
                });

                Columns.Add(new DatabaseColumn("OrderQty", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int16,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ProductID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SpecialOfferID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UnitPrice", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UnitPriceDiscount", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LineTotal", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Decimal,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("rowguid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn SalesOrderID{
                get{
                    return this.GetColumn("SalesOrderID");
                }
            }
            				
   			public static string SalesOrderIDColumn{
			      get{
        			return "SalesOrderID";
      			}
		    }
           
            public IColumn SalesOrderDetailID{
                get{
                    return this.GetColumn("SalesOrderDetailID");
                }
            }
            				
   			public static string SalesOrderDetailIDColumn{
			      get{
        			return "SalesOrderDetailID";
      			}
		    }
           
            public IColumn CarrierTrackingNumber{
                get{
                    return this.GetColumn("CarrierTrackingNumber");
                }
            }
            				
   			public static string CarrierTrackingNumberColumn{
			      get{
        			return "CarrierTrackingNumber";
      			}
		    }
           
            public IColumn OrderQty{
                get{
                    return this.GetColumn("OrderQty");
                }
            }
            				
   			public static string OrderQtyColumn{
			      get{
        			return "OrderQty";
      			}
		    }
           
            public IColumn ProductID{
                get{
                    return this.GetColumn("ProductID");
                }
            }
            				
   			public static string ProductIDColumn{
			      get{
        			return "ProductID";
      			}
		    }
           
            public IColumn SpecialOfferID{
                get{
                    return this.GetColumn("SpecialOfferID");
                }
            }
            				
   			public static string SpecialOfferIDColumn{
			      get{
        			return "SpecialOfferID";
      			}
		    }
           
            public IColumn UnitPrice{
                get{
                    return this.GetColumn("UnitPrice");
                }
            }
            				
   			public static string UnitPriceColumn{
			      get{
        			return "UnitPrice";
      			}
		    }
           
            public IColumn UnitPriceDiscount{
                get{
                    return this.GetColumn("UnitPriceDiscount");
                }
            }
            				
   			public static string UnitPriceDiscountColumn{
			      get{
        			return "UnitPriceDiscount";
      			}
		    }
           
            public IColumn LineTotal{
                get{
                    return this.GetColumn("LineTotal");
                }
            }
            				
   			public static string LineTotalColumn{
			      get{
        			return "LineTotal";
      			}
		    }
           
            public IColumn rowguid{
                get{
                    return this.GetColumn("rowguid");
                }
            }
            				
   			public static string rowguidColumn{
			      get{
        			return "rowguid";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: CurrencyRate
        /// Primary Key: CurrencyRateID
        /// </summary>

        public class CurrencyRateTable: DatabaseTable {
            
            public CurrencyRateTable(IDataProvider provider):base("CurrencyRate",provider){
                ClassName = "CurrencyRate";
                SchemaName = "Sales";
                

                Columns.Add(new DatabaseColumn("CurrencyRateID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CurrencyRateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("FromCurrencyCode", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 3
                });

                Columns.Add(new DatabaseColumn("ToCurrencyCode", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 3
                });

                Columns.Add(new DatabaseColumn("AverageRate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("EndOfDayRate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn CurrencyRateID{
                get{
                    return this.GetColumn("CurrencyRateID");
                }
            }
            				
   			public static string CurrencyRateIDColumn{
			      get{
        			return "CurrencyRateID";
      			}
		    }
           
            public IColumn CurrencyRateDate{
                get{
                    return this.GetColumn("CurrencyRateDate");
                }
            }
            				
   			public static string CurrencyRateDateColumn{
			      get{
        			return "CurrencyRateDate";
      			}
		    }
           
            public IColumn FromCurrencyCode{
                get{
                    return this.GetColumn("FromCurrencyCode");
                }
            }
            				
   			public static string FromCurrencyCodeColumn{
			      get{
        			return "FromCurrencyCode";
      			}
		    }
           
            public IColumn ToCurrencyCode{
                get{
                    return this.GetColumn("ToCurrencyCode");
                }
            }
            				
   			public static string ToCurrencyCodeColumn{
			      get{
        			return "ToCurrencyCode";
      			}
		    }
           
            public IColumn AverageRate{
                get{
                    return this.GetColumn("AverageRate");
                }
            }
            				
   			public static string AverageRateColumn{
			      get{
        			return "AverageRate";
      			}
		    }
           
            public IColumn EndOfDayRate{
                get{
                    return this.GetColumn("EndOfDayRate");
                }
            }
            				
   			public static string EndOfDayRateColumn{
			      get{
        			return "EndOfDayRate";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: Customer
        /// Primary Key: CustomerID
        /// </summary>

        public class CustomerTable: DatabaseTable {
            
            public CustomerTable(IDataProvider provider):base("Customer",provider){
                ClassName = "Customer";
                SchemaName = "Sales";
                

                Columns.Add(new DatabaseColumn("CustomerID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("TerritoryID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AccountNumber", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 10
                });

                Columns.Add(new DatabaseColumn("CustomerType", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1
                });

                Columns.Add(new DatabaseColumn("rowguid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn CustomerID{
                get{
                    return this.GetColumn("CustomerID");
                }
            }
            				
   			public static string CustomerIDColumn{
			      get{
        			return "CustomerID";
      			}
		    }
           
            public IColumn TerritoryID{
                get{
                    return this.GetColumn("TerritoryID");
                }
            }
            				
   			public static string TerritoryIDColumn{
			      get{
        			return "TerritoryID";
      			}
		    }
           
            public IColumn AccountNumber{
                get{
                    return this.GetColumn("AccountNumber");
                }
            }
            				
   			public static string AccountNumberColumn{
			      get{
        			return "AccountNumber";
      			}
		    }
           
            public IColumn CustomerType{
                get{
                    return this.GetColumn("CustomerType");
                }
            }
            				
   			public static string CustomerTypeColumn{
			      get{
        			return "CustomerType";
      			}
		    }
           
            public IColumn rowguid{
                get{
                    return this.GetColumn("rowguid");
                }
            }
            				
   			public static string rowguidColumn{
			      get{
        			return "rowguid";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: SalesOrderHeader
        /// Primary Key: SalesOrderID
        /// </summary>

        public class SalesOrderHeaderTable: DatabaseTable {
            
            public SalesOrderHeaderTable(IDataProvider provider):base("SalesOrderHeader",provider){
                ClassName = "SalesOrderHeader";
                SchemaName = "Sales";
                

                Columns.Add(new DatabaseColumn("SalesOrderID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("RevisionNumber", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Byte,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("OrderDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DueDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ShipDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Status", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Byte,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("OnlineOrderFlag", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SalesOrderNumber", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 25
                });

                Columns.Add(new DatabaseColumn("PurchaseOrderNumber", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 25
                });

                Columns.Add(new DatabaseColumn("AccountNumber", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 15
                });

                Columns.Add(new DatabaseColumn("CustomerID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ContactID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SalesPersonID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("TerritoryID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("BillToAddressID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ShipToAddressID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ShipMethodID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreditCardID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreditCardApprovalCode", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 15
                });

                Columns.Add(new DatabaseColumn("CurrencyRateID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SubTotal", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("TaxAmt", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Freight", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("TotalDue", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Comment", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 128
                });

                Columns.Add(new DatabaseColumn("rowguid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn SalesOrderID{
                get{
                    return this.GetColumn("SalesOrderID");
                }
            }
            				
   			public static string SalesOrderIDColumn{
			      get{
        			return "SalesOrderID";
      			}
		    }
           
            public IColumn RevisionNumber{
                get{
                    return this.GetColumn("RevisionNumber");
                }
            }
            				
   			public static string RevisionNumberColumn{
			      get{
        			return "RevisionNumber";
      			}
		    }
           
            public IColumn OrderDate{
                get{
                    return this.GetColumn("OrderDate");
                }
            }
            				
   			public static string OrderDateColumn{
			      get{
        			return "OrderDate";
      			}
		    }
           
            public IColumn DueDate{
                get{
                    return this.GetColumn("DueDate");
                }
            }
            				
   			public static string DueDateColumn{
			      get{
        			return "DueDate";
      			}
		    }
           
            public IColumn ShipDate{
                get{
                    return this.GetColumn("ShipDate");
                }
            }
            				
   			public static string ShipDateColumn{
			      get{
        			return "ShipDate";
      			}
		    }
           
            public IColumn Status{
                get{
                    return this.GetColumn("Status");
                }
            }
            				
   			public static string StatusColumn{
			      get{
        			return "Status";
      			}
		    }
           
            public IColumn OnlineOrderFlag{
                get{
                    return this.GetColumn("OnlineOrderFlag");
                }
            }
            				
   			public static string OnlineOrderFlagColumn{
			      get{
        			return "OnlineOrderFlag";
      			}
		    }
           
            public IColumn SalesOrderNumber{
                get{
                    return this.GetColumn("SalesOrderNumber");
                }
            }
            				
   			public static string SalesOrderNumberColumn{
			      get{
        			return "SalesOrderNumber";
      			}
		    }
           
            public IColumn PurchaseOrderNumber{
                get{
                    return this.GetColumn("PurchaseOrderNumber");
                }
            }
            				
   			public static string PurchaseOrderNumberColumn{
			      get{
        			return "PurchaseOrderNumber";
      			}
		    }
           
            public IColumn AccountNumber{
                get{
                    return this.GetColumn("AccountNumber");
                }
            }
            				
   			public static string AccountNumberColumn{
			      get{
        			return "AccountNumber";
      			}
		    }
           
            public IColumn CustomerID{
                get{
                    return this.GetColumn("CustomerID");
                }
            }
            				
   			public static string CustomerIDColumn{
			      get{
        			return "CustomerID";
      			}
		    }
           
            public IColumn ContactID{
                get{
                    return this.GetColumn("ContactID");
                }
            }
            				
   			public static string ContactIDColumn{
			      get{
        			return "ContactID";
      			}
		    }
           
            public IColumn SalesPersonID{
                get{
                    return this.GetColumn("SalesPersonID");
                }
            }
            				
   			public static string SalesPersonIDColumn{
			      get{
        			return "SalesPersonID";
      			}
		    }
           
            public IColumn TerritoryID{
                get{
                    return this.GetColumn("TerritoryID");
                }
            }
            				
   			public static string TerritoryIDColumn{
			      get{
        			return "TerritoryID";
      			}
		    }
           
            public IColumn BillToAddressID{
                get{
                    return this.GetColumn("BillToAddressID");
                }
            }
            				
   			public static string BillToAddressIDColumn{
			      get{
        			return "BillToAddressID";
      			}
		    }
           
            public IColumn ShipToAddressID{
                get{
                    return this.GetColumn("ShipToAddressID");
                }
            }
            				
   			public static string ShipToAddressIDColumn{
			      get{
        			return "ShipToAddressID";
      			}
		    }
           
            public IColumn ShipMethodID{
                get{
                    return this.GetColumn("ShipMethodID");
                }
            }
            				
   			public static string ShipMethodIDColumn{
			      get{
        			return "ShipMethodID";
      			}
		    }
           
            public IColumn CreditCardID{
                get{
                    return this.GetColumn("CreditCardID");
                }
            }
            				
   			public static string CreditCardIDColumn{
			      get{
        			return "CreditCardID";
      			}
		    }
           
            public IColumn CreditCardApprovalCode{
                get{
                    return this.GetColumn("CreditCardApprovalCode");
                }
            }
            				
   			public static string CreditCardApprovalCodeColumn{
			      get{
        			return "CreditCardApprovalCode";
      			}
		    }
           
            public IColumn CurrencyRateID{
                get{
                    return this.GetColumn("CurrencyRateID");
                }
            }
            				
   			public static string CurrencyRateIDColumn{
			      get{
        			return "CurrencyRateID";
      			}
		    }
           
            public IColumn SubTotal{
                get{
                    return this.GetColumn("SubTotal");
                }
            }
            				
   			public static string SubTotalColumn{
			      get{
        			return "SubTotal";
      			}
		    }
           
            public IColumn TaxAmt{
                get{
                    return this.GetColumn("TaxAmt");
                }
            }
            				
   			public static string TaxAmtColumn{
			      get{
        			return "TaxAmt";
      			}
		    }
           
            public IColumn Freight{
                get{
                    return this.GetColumn("Freight");
                }
            }
            				
   			public static string FreightColumn{
			      get{
        			return "Freight";
      			}
		    }
           
            public IColumn TotalDue{
                get{
                    return this.GetColumn("TotalDue");
                }
            }
            				
   			public static string TotalDueColumn{
			      get{
        			return "TotalDue";
      			}
		    }
           
            public IColumn Comment{
                get{
                    return this.GetColumn("Comment");
                }
            }
            				
   			public static string CommentColumn{
			      get{
        			return "Comment";
      			}
		    }
           
            public IColumn rowguid{
                get{
                    return this.GetColumn("rowguid");
                }
            }
            				
   			public static string rowguidColumn{
			      get{
        			return "rowguid";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: CustomerAddress
        /// Primary Key: AddressID
        /// </summary>

        public class CustomerAddressTable: DatabaseTable {
            
            public CustomerAddressTable(IDataProvider provider):base("CustomerAddress",provider){
                ClassName = "CustomerAddress";
                SchemaName = "Sales";
                

                Columns.Add(new DatabaseColumn("CustomerID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AddressID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AddressTypeID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("rowguid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn CustomerID{
                get{
                    return this.GetColumn("CustomerID");
                }
            }
            				
   			public static string CustomerIDColumn{
			      get{
        			return "CustomerID";
      			}
		    }
           
            public IColumn AddressID{
                get{
                    return this.GetColumn("AddressID");
                }
            }
            				
   			public static string AddressIDColumn{
			      get{
        			return "AddressID";
      			}
		    }
           
            public IColumn AddressTypeID{
                get{
                    return this.GetColumn("AddressTypeID");
                }
            }
            				
   			public static string AddressTypeIDColumn{
			      get{
        			return "AddressTypeID";
      			}
		    }
           
            public IColumn rowguid{
                get{
                    return this.GetColumn("rowguid");
                }
            }
            				
   			public static string rowguidColumn{
			      get{
        			return "rowguid";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: Department
        /// Primary Key: DepartmentID
        /// </summary>

        public class DepartmentTable: DatabaseTable {
            
            public DepartmentTable(IDataProvider provider):base("Department",provider){
                ClassName = "Department";
                SchemaName = "HumanResources";
                

                Columns.Add(new DatabaseColumn("DepartmentID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int16,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("GroupName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn DepartmentID{
                get{
                    return this.GetColumn("DepartmentID");
                }
            }
            				
   			public static string DepartmentIDColumn{
			      get{
        			return "DepartmentID";
      			}
		    }
           
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
            				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
           
            public IColumn GroupName{
                get{
                    return this.GetColumn("GroupName");
                }
            }
            				
   			public static string GroupNameColumn{
			      get{
        			return "GroupName";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: Document
        /// Primary Key: DocumentID
        /// </summary>

        public class DocumentTable: DatabaseTable {
            
            public DocumentTable(IDataProvider provider):base("Document",provider){
                ClassName = "Document";
                SchemaName = "Production";
                

                Columns.Add(new DatabaseColumn("DocumentID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Title", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("FileName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 400
                });

                Columns.Add(new DatabaseColumn("FileExtension", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 8
                });

                Columns.Add(new DatabaseColumn("Revision", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 5
                });

                Columns.Add(new DatabaseColumn("ChangeNumber", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Status", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Byte,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DocumentSummary", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Document", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Binary,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn DocumentID{
                get{
                    return this.GetColumn("DocumentID");
                }
            }
            				
   			public static string DocumentIDColumn{
			      get{
        			return "DocumentID";
      			}
		    }
           
            public IColumn Title{
                get{
                    return this.GetColumn("Title");
                }
            }
            				
   			public static string TitleColumn{
			      get{
        			return "Title";
      			}
		    }
           
            public IColumn FileName{
                get{
                    return this.GetColumn("FileName");
                }
            }
            				
   			public static string FileNameColumn{
			      get{
        			return "FileName";
      			}
		    }
           
            public IColumn FileExtension{
                get{
                    return this.GetColumn("FileExtension");
                }
            }
            				
   			public static string FileExtensionColumn{
			      get{
        			return "FileExtension";
      			}
		    }
           
            public IColumn Revision{
                get{
                    return this.GetColumn("Revision");
                }
            }
            				
   			public static string RevisionColumn{
			      get{
        			return "Revision";
      			}
		    }
           
            public IColumn ChangeNumber{
                get{
                    return this.GetColumn("ChangeNumber");
                }
            }
            				
   			public static string ChangeNumberColumn{
			      get{
        			return "ChangeNumber";
      			}
		    }
           
            public IColumn Status{
                get{
                    return this.GetColumn("Status");
                }
            }
            				
   			public static string StatusColumn{
			      get{
        			return "Status";
      			}
		    }
           
            public IColumn DocumentSummary{
                get{
                    return this.GetColumn("DocumentSummary");
                }
            }
            				
   			public static string DocumentSummaryColumn{
			      get{
        			return "DocumentSummary";
      			}
		    }
           
            public IColumn Document{
                get{
                    return this.GetColumn("Document");
                }
            }
            				
   			public static string DocumentColumn{
			      get{
        			return "Document";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: Employee
        /// Primary Key: EmployeeID
        /// </summary>

        public class EmployeeTable: DatabaseTable {
            
            public EmployeeTable(IDataProvider provider):base("Employee",provider){
                ClassName = "Employee";
                SchemaName = "HumanResources";
                

                Columns.Add(new DatabaseColumn("EmployeeID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("NationalIDNumber", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 15
                });

                Columns.Add(new DatabaseColumn("ContactID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LoginID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 256
                });

                Columns.Add(new DatabaseColumn("ManagerID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Title", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("BirthDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MaritalStatus", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1
                });

                Columns.Add(new DatabaseColumn("Gender", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1
                });

                Columns.Add(new DatabaseColumn("HireDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SalariedFlag", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("VacationHours", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int16,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SickLeaveHours", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int16,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CurrentFlag", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("rowguid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn EmployeeID{
                get{
                    return this.GetColumn("EmployeeID");
                }
            }
            				
   			public static string EmployeeIDColumn{
			      get{
        			return "EmployeeID";
      			}
		    }
           
            public IColumn NationalIDNumber{
                get{
                    return this.GetColumn("NationalIDNumber");
                }
            }
            				
   			public static string NationalIDNumberColumn{
			      get{
        			return "NationalIDNumber";
      			}
		    }
           
            public IColumn ContactID{
                get{
                    return this.GetColumn("ContactID");
                }
            }
            				
   			public static string ContactIDColumn{
			      get{
        			return "ContactID";
      			}
		    }
           
            public IColumn LoginID{
                get{
                    return this.GetColumn("LoginID");
                }
            }
            				
   			public static string LoginIDColumn{
			      get{
        			return "LoginID";
      			}
		    }
           
            public IColumn ManagerID{
                get{
                    return this.GetColumn("ManagerID");
                }
            }
            				
   			public static string ManagerIDColumn{
			      get{
        			return "ManagerID";
      			}
		    }
           
            public IColumn Title{
                get{
                    return this.GetColumn("Title");
                }
            }
            				
   			public static string TitleColumn{
			      get{
        			return "Title";
      			}
		    }
           
            public IColumn BirthDate{
                get{
                    return this.GetColumn("BirthDate");
                }
            }
            				
   			public static string BirthDateColumn{
			      get{
        			return "BirthDate";
      			}
		    }
           
            public IColumn MaritalStatus{
                get{
                    return this.GetColumn("MaritalStatus");
                }
            }
            				
   			public static string MaritalStatusColumn{
			      get{
        			return "MaritalStatus";
      			}
		    }
           
            public IColumn Gender{
                get{
                    return this.GetColumn("Gender");
                }
            }
            				
   			public static string GenderColumn{
			      get{
        			return "Gender";
      			}
		    }
           
            public IColumn HireDate{
                get{
                    return this.GetColumn("HireDate");
                }
            }
            				
   			public static string HireDateColumn{
			      get{
        			return "HireDate";
      			}
		    }
           
            public IColumn SalariedFlag{
                get{
                    return this.GetColumn("SalariedFlag");
                }
            }
            				
   			public static string SalariedFlagColumn{
			      get{
        			return "SalariedFlag";
      			}
		    }
           
            public IColumn VacationHours{
                get{
                    return this.GetColumn("VacationHours");
                }
            }
            				
   			public static string VacationHoursColumn{
			      get{
        			return "VacationHours";
      			}
		    }
           
            public IColumn SickLeaveHours{
                get{
                    return this.GetColumn("SickLeaveHours");
                }
            }
            				
   			public static string SickLeaveHoursColumn{
			      get{
        			return "SickLeaveHours";
      			}
		    }
           
            public IColumn CurrentFlag{
                get{
                    return this.GetColumn("CurrentFlag");
                }
            }
            				
   			public static string CurrentFlagColumn{
			      get{
        			return "CurrentFlag";
      			}
		    }
           
            public IColumn rowguid{
                get{
                    return this.GetColumn("rowguid");
                }
            }
            				
   			public static string rowguidColumn{
			      get{
        			return "rowguid";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: SalesOrderHeaderSalesReason
        /// Primary Key: SalesOrderID
        /// </summary>

        public class SalesOrderHeaderSalesReasonTable: DatabaseTable {
            
            public SalesOrderHeaderSalesReasonTable(IDataProvider provider):base("SalesOrderHeaderSalesReason",provider){
                ClassName = "SalesOrderHeaderSalesReason";
                SchemaName = "Sales";
                

                Columns.Add(new DatabaseColumn("SalesOrderID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SalesReasonID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn SalesOrderID{
                get{
                    return this.GetColumn("SalesOrderID");
                }
            }
            				
   			public static string SalesOrderIDColumn{
			      get{
        			return "SalesOrderID";
      			}
		    }
           
            public IColumn SalesReasonID{
                get{
                    return this.GetColumn("SalesReasonID");
                }
            }
            				
   			public static string SalesReasonIDColumn{
			      get{
        			return "SalesReasonID";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: SalesPerson
        /// Primary Key: SalesPersonID
        /// </summary>

        public class SalesPersonTable: DatabaseTable {
            
            public SalesPersonTable(IDataProvider provider):base("SalesPerson",provider){
                ClassName = "SalesPerson";
                SchemaName = "Sales";
                

                Columns.Add(new DatabaseColumn("SalesPersonID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("TerritoryID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SalesQuota", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Bonus", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CommissionPct", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SalesYTD", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SalesLastYear", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("rowguid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn SalesPersonID{
                get{
                    return this.GetColumn("SalesPersonID");
                }
            }
            				
   			public static string SalesPersonIDColumn{
			      get{
        			return "SalesPersonID";
      			}
		    }
           
            public IColumn TerritoryID{
                get{
                    return this.GetColumn("TerritoryID");
                }
            }
            				
   			public static string TerritoryIDColumn{
			      get{
        			return "TerritoryID";
      			}
		    }
           
            public IColumn SalesQuota{
                get{
                    return this.GetColumn("SalesQuota");
                }
            }
            				
   			public static string SalesQuotaColumn{
			      get{
        			return "SalesQuota";
      			}
		    }
           
            public IColumn Bonus{
                get{
                    return this.GetColumn("Bonus");
                }
            }
            				
   			public static string BonusColumn{
			      get{
        			return "Bonus";
      			}
		    }
           
            public IColumn CommissionPct{
                get{
                    return this.GetColumn("CommissionPct");
                }
            }
            				
   			public static string CommissionPctColumn{
			      get{
        			return "CommissionPct";
      			}
		    }
           
            public IColumn SalesYTD{
                get{
                    return this.GetColumn("SalesYTD");
                }
            }
            				
   			public static string SalesYTDColumn{
			      get{
        			return "SalesYTD";
      			}
		    }
           
            public IColumn SalesLastYear{
                get{
                    return this.GetColumn("SalesLastYear");
                }
            }
            				
   			public static string SalesLastYearColumn{
			      get{
        			return "SalesLastYear";
      			}
		    }
           
            public IColumn rowguid{
                get{
                    return this.GetColumn("rowguid");
                }
            }
            				
   			public static string rowguidColumn{
			      get{
        			return "rowguid";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: EmployeeAddress
        /// Primary Key: AddressID
        /// </summary>

        public class EmployeeAddressTable: DatabaseTable {
            
            public EmployeeAddressTable(IDataProvider provider):base("EmployeeAddress",provider){
                ClassName = "EmployeeAddress";
                SchemaName = "HumanResources";
                

                Columns.Add(new DatabaseColumn("EmployeeID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AddressID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("rowguid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn EmployeeID{
                get{
                    return this.GetColumn("EmployeeID");
                }
            }
            				
   			public static string EmployeeIDColumn{
			      get{
        			return "EmployeeID";
      			}
		    }
           
            public IColumn AddressID{
                get{
                    return this.GetColumn("AddressID");
                }
            }
            				
   			public static string AddressIDColumn{
			      get{
        			return "AddressID";
      			}
		    }
           
            public IColumn rowguid{
                get{
                    return this.GetColumn("rowguid");
                }
            }
            				
   			public static string rowguidColumn{
			      get{
        			return "rowguid";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: EmployeeDepartmentHistory
        /// Primary Key: DepartmentID
        /// </summary>

        public class EmployeeDepartmentHistoryTable: DatabaseTable {
            
            public EmployeeDepartmentHistoryTable(IDataProvider provider):base("EmployeeDepartmentHistory",provider){
                ClassName = "EmployeeDepartmentHistory";
                SchemaName = "HumanResources";
                

                Columns.Add(new DatabaseColumn("EmployeeID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DepartmentID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int16,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ShiftID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Byte,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StartDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("EndDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn EmployeeID{
                get{
                    return this.GetColumn("EmployeeID");
                }
            }
            				
   			public static string EmployeeIDColumn{
			      get{
        			return "EmployeeID";
      			}
		    }
           
            public IColumn DepartmentID{
                get{
                    return this.GetColumn("DepartmentID");
                }
            }
            				
   			public static string DepartmentIDColumn{
			      get{
        			return "DepartmentID";
      			}
		    }
           
            public IColumn ShiftID{
                get{
                    return this.GetColumn("ShiftID");
                }
            }
            				
   			public static string ShiftIDColumn{
			      get{
        			return "ShiftID";
      			}
		    }
           
            public IColumn StartDate{
                get{
                    return this.GetColumn("StartDate");
                }
            }
            				
   			public static string StartDateColumn{
			      get{
        			return "StartDate";
      			}
		    }
           
            public IColumn EndDate{
                get{
                    return this.GetColumn("EndDate");
                }
            }
            				
   			public static string EndDateColumn{
			      get{
        			return "EndDate";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: EmployeePayHistory
        /// Primary Key: EmployeeID
        /// </summary>

        public class EmployeePayHistoryTable: DatabaseTable {
            
            public EmployeePayHistoryTable(IDataProvider provider):base("EmployeePayHistory",provider){
                ClassName = "EmployeePayHistory";
                SchemaName = "HumanResources";
                

                Columns.Add(new DatabaseColumn("EmployeeID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("RateChangeDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Rate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PayFrequency", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Byte,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn EmployeeID{
                get{
                    return this.GetColumn("EmployeeID");
                }
            }
            				
   			public static string EmployeeIDColumn{
			      get{
        			return "EmployeeID";
      			}
		    }
           
            public IColumn RateChangeDate{
                get{
                    return this.GetColumn("RateChangeDate");
                }
            }
            				
   			public static string RateChangeDateColumn{
			      get{
        			return "RateChangeDate";
      			}
		    }
           
            public IColumn Rate{
                get{
                    return this.GetColumn("Rate");
                }
            }
            				
   			public static string RateColumn{
			      get{
        			return "Rate";
      			}
		    }
           
            public IColumn PayFrequency{
                get{
                    return this.GetColumn("PayFrequency");
                }
            }
            				
   			public static string PayFrequencyColumn{
			      get{
        			return "PayFrequency";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: SalesPersonQuotaHistory
        /// Primary Key: QuotaDate
        /// </summary>

        public class SalesPersonQuotaHistoryTable: DatabaseTable {
            
            public SalesPersonQuotaHistoryTable(IDataProvider provider):base("SalesPersonQuotaHistory",provider){
                ClassName = "SalesPersonQuotaHistory";
                SchemaName = "Sales";
                

                Columns.Add(new DatabaseColumn("SalesPersonID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("QuotaDate", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SalesQuota", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("rowguid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn SalesPersonID{
                get{
                    return this.GetColumn("SalesPersonID");
                }
            }
            				
   			public static string SalesPersonIDColumn{
			      get{
        			return "SalesPersonID";
      			}
		    }
           
            public IColumn QuotaDate{
                get{
                    return this.GetColumn("QuotaDate");
                }
            }
            				
   			public static string QuotaDateColumn{
			      get{
        			return "QuotaDate";
      			}
		    }
           
            public IColumn SalesQuota{
                get{
                    return this.GetColumn("SalesQuota");
                }
            }
            				
   			public static string SalesQuotaColumn{
			      get{
        			return "SalesQuota";
      			}
		    }
           
            public IColumn rowguid{
                get{
                    return this.GetColumn("rowguid");
                }
            }
            				
   			public static string rowguidColumn{
			      get{
        			return "rowguid";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: Illustration
        /// Primary Key: IllustrationID
        /// </summary>

        public class IllustrationTable: DatabaseTable {
            
            public IllustrationTable(IDataProvider provider):base("Illustration",provider){
                ClassName = "Illustration";
                SchemaName = "Production";
                

                Columns.Add(new DatabaseColumn("IllustrationID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Diagram", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Xml,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn IllustrationID{
                get{
                    return this.GetColumn("IllustrationID");
                }
            }
            				
   			public static string IllustrationIDColumn{
			      get{
        			return "IllustrationID";
      			}
		    }
           
            public IColumn Diagram{
                get{
                    return this.GetColumn("Diagram");
                }
            }
            				
   			public static string DiagramColumn{
			      get{
        			return "Diagram";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: SalesReason
        /// Primary Key: SalesReasonID
        /// </summary>

        public class SalesReasonTable: DatabaseTable {
            
            public SalesReasonTable(IDataProvider provider):base("SalesReason",provider){
                ClassName = "SalesReason";
                SchemaName = "Sales";
                

                Columns.Add(new DatabaseColumn("SalesReasonID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("ReasonType", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn SalesReasonID{
                get{
                    return this.GetColumn("SalesReasonID");
                }
            }
            				
   			public static string SalesReasonIDColumn{
			      get{
        			return "SalesReasonID";
      			}
		    }
           
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
            				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
           
            public IColumn ReasonType{
                get{
                    return this.GetColumn("ReasonType");
                }
            }
            				
   			public static string ReasonTypeColumn{
			      get{
        			return "ReasonType";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: Individual
        /// Primary Key: CustomerID
        /// </summary>

        public class IndividualTable: DatabaseTable {
            
            public IndividualTable(IDataProvider provider):base("Individual",provider){
                ClassName = "Individual";
                SchemaName = "Sales";
                

                Columns.Add(new DatabaseColumn("CustomerID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ContactID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Demographics", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Xml,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn CustomerID{
                get{
                    return this.GetColumn("CustomerID");
                }
            }
            				
   			public static string CustomerIDColumn{
			      get{
        			return "CustomerID";
      			}
		    }
           
            public IColumn ContactID{
                get{
                    return this.GetColumn("ContactID");
                }
            }
            				
   			public static string ContactIDColumn{
			      get{
        			return "ContactID";
      			}
		    }
           
            public IColumn Demographics{
                get{
                    return this.GetColumn("Demographics");
                }
            }
            				
   			public static string DemographicsColumn{
			      get{
        			return "Demographics";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: SalesTaxRate
        /// Primary Key: SalesTaxRateID
        /// </summary>

        public class SalesTaxRateTable: DatabaseTable {
            
            public SalesTaxRateTable(IDataProvider provider):base("SalesTaxRate",provider){
                ClassName = "SalesTaxRate";
                SchemaName = "Sales";
                

                Columns.Add(new DatabaseColumn("SalesTaxRateID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StateProvinceID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("TaxType", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Byte,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("TaxRate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("rowguid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn SalesTaxRateID{
                get{
                    return this.GetColumn("SalesTaxRateID");
                }
            }
            				
   			public static string SalesTaxRateIDColumn{
			      get{
        			return "SalesTaxRateID";
      			}
		    }
           
            public IColumn StateProvinceID{
                get{
                    return this.GetColumn("StateProvinceID");
                }
            }
            				
   			public static string StateProvinceIDColumn{
			      get{
        			return "StateProvinceID";
      			}
		    }
           
            public IColumn TaxType{
                get{
                    return this.GetColumn("TaxType");
                }
            }
            				
   			public static string TaxTypeColumn{
			      get{
        			return "TaxType";
      			}
		    }
           
            public IColumn TaxRate{
                get{
                    return this.GetColumn("TaxRate");
                }
            }
            				
   			public static string TaxRateColumn{
			      get{
        			return "TaxRate";
      			}
		    }
           
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
            				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
           
            public IColumn rowguid{
                get{
                    return this.GetColumn("rowguid");
                }
            }
            				
   			public static string rowguidColumn{
			      get{
        			return "rowguid";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: JobCandidate
        /// Primary Key: JobCandidateID
        /// </summary>

        public class JobCandidateTable: DatabaseTable {
            
            public JobCandidateTable(IDataProvider provider):base("JobCandidate",provider){
                ClassName = "JobCandidate";
                SchemaName = "HumanResources";
                

                Columns.Add(new DatabaseColumn("JobCandidateID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("EmployeeID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Resume", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Xml,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn JobCandidateID{
                get{
                    return this.GetColumn("JobCandidateID");
                }
            }
            				
   			public static string JobCandidateIDColumn{
			      get{
        			return "JobCandidateID";
      			}
		    }
           
            public IColumn EmployeeID{
                get{
                    return this.GetColumn("EmployeeID");
                }
            }
            				
   			public static string EmployeeIDColumn{
			      get{
        			return "EmployeeID";
      			}
		    }
           
            public IColumn Resume{
                get{
                    return this.GetColumn("Resume");
                }
            }
            				
   			public static string ResumeColumn{
			      get{
        			return "Resume";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: Location
        /// Primary Key: LocationID
        /// </summary>

        public class LocationTable: DatabaseTable {
            
            public LocationTable(IDataProvider provider):base("Location",provider){
                ClassName = "Location";
                SchemaName = "Production";
                

                Columns.Add(new DatabaseColumn("LocationID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int16,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("CostRate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Availability", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Decimal,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn LocationID{
                get{
                    return this.GetColumn("LocationID");
                }
            }
            				
   			public static string LocationIDColumn{
			      get{
        			return "LocationID";
      			}
		    }
           
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
            				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
           
            public IColumn CostRate{
                get{
                    return this.GetColumn("CostRate");
                }
            }
            				
   			public static string CostRateColumn{
			      get{
        			return "CostRate";
      			}
		    }
           
            public IColumn Availability{
                get{
                    return this.GetColumn("Availability");
                }
            }
            				
   			public static string AvailabilityColumn{
			      get{
        			return "Availability";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: SalesTerritory
        /// Primary Key: TerritoryID
        /// </summary>

        public class SalesTerritoryTable: DatabaseTable {
            
            public SalesTerritoryTable(IDataProvider provider):base("SalesTerritory",provider){
                ClassName = "SalesTerritory";
                SchemaName = "Sales";
                

                Columns.Add(new DatabaseColumn("TerritoryID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("CountryRegionCode", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 3
                });

                Columns.Add(new DatabaseColumn("Group", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("SalesYTD", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SalesLastYear", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CostYTD", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CostLastYear", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("rowguid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn TerritoryID{
                get{
                    return this.GetColumn("TerritoryID");
                }
            }
            				
   			public static string TerritoryIDColumn{
			      get{
        			return "TerritoryID";
      			}
		    }
           
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
            				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
           
            public IColumn CountryRegionCode{
                get{
                    return this.GetColumn("CountryRegionCode");
                }
            }
            				
   			public static string CountryRegionCodeColumn{
			      get{
        			return "CountryRegionCode";
      			}
		    }
           
            public IColumn Group{
                get{
                    return this.GetColumn("Group");
                }
            }
            				
   			public static string GroupColumn{
			      get{
        			return "Group";
      			}
		    }
           
            public IColumn SalesYTD{
                get{
                    return this.GetColumn("SalesYTD");
                }
            }
            				
   			public static string SalesYTDColumn{
			      get{
        			return "SalesYTD";
      			}
		    }
           
            public IColumn SalesLastYear{
                get{
                    return this.GetColumn("SalesLastYear");
                }
            }
            				
   			public static string SalesLastYearColumn{
			      get{
        			return "SalesLastYear";
      			}
		    }
           
            public IColumn CostYTD{
                get{
                    return this.GetColumn("CostYTD");
                }
            }
            				
   			public static string CostYTDColumn{
			      get{
        			return "CostYTD";
      			}
		    }
           
            public IColumn CostLastYear{
                get{
                    return this.GetColumn("CostLastYear");
                }
            }
            				
   			public static string CostLastYearColumn{
			      get{
        			return "CostLastYear";
      			}
		    }
           
            public IColumn rowguid{
                get{
                    return this.GetColumn("rowguid");
                }
            }
            				
   			public static string rowguidColumn{
			      get{
        			return "rowguid";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: Product
        /// Primary Key: ProductID
        /// </summary>

        public class ProductTable: DatabaseTable {
            
            public ProductTable(IDataProvider provider):base("Product",provider){
                ClassName = "Product";
                SchemaName = "Production";
                

                Columns.Add(new DatabaseColumn("ProductID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("ProductNumber", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 25
                });

                Columns.Add(new DatabaseColumn("MakeFlag", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("FinishedGoodsFlag", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Color", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 15
                });

                Columns.Add(new DatabaseColumn("SafetyStockLevel", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int16,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ReorderPoint", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int16,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StandardCost", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ListPrice", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Size", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 5
                });

                Columns.Add(new DatabaseColumn("SizeUnitMeasureCode", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 3
                });

                Columns.Add(new DatabaseColumn("WeightUnitMeasureCode", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 3
                });

                Columns.Add(new DatabaseColumn("Weight", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Decimal,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DaysToManufacture", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ProductLine", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2
                });

                Columns.Add(new DatabaseColumn("Class", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2
                });

                Columns.Add(new DatabaseColumn("Style", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2
                });

                Columns.Add(new DatabaseColumn("ProductSubcategoryID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ProductModelID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SellStartDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SellEndDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DiscontinuedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("rowguid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ProductID{
                get{
                    return this.GetColumn("ProductID");
                }
            }
            				
   			public static string ProductIDColumn{
			      get{
        			return "ProductID";
      			}
		    }
           
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
            				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
           
            public IColumn ProductNumber{
                get{
                    return this.GetColumn("ProductNumber");
                }
            }
            				
   			public static string ProductNumberColumn{
			      get{
        			return "ProductNumber";
      			}
		    }
           
            public IColumn MakeFlag{
                get{
                    return this.GetColumn("MakeFlag");
                }
            }
            				
   			public static string MakeFlagColumn{
			      get{
        			return "MakeFlag";
      			}
		    }
           
            public IColumn FinishedGoodsFlag{
                get{
                    return this.GetColumn("FinishedGoodsFlag");
                }
            }
            				
   			public static string FinishedGoodsFlagColumn{
			      get{
        			return "FinishedGoodsFlag";
      			}
		    }
           
            public IColumn Color{
                get{
                    return this.GetColumn("Color");
                }
            }
            				
   			public static string ColorColumn{
			      get{
        			return "Color";
      			}
		    }
           
            public IColumn SafetyStockLevel{
                get{
                    return this.GetColumn("SafetyStockLevel");
                }
            }
            				
   			public static string SafetyStockLevelColumn{
			      get{
        			return "SafetyStockLevel";
      			}
		    }
           
            public IColumn ReorderPoint{
                get{
                    return this.GetColumn("ReorderPoint");
                }
            }
            				
   			public static string ReorderPointColumn{
			      get{
        			return "ReorderPoint";
      			}
		    }
           
            public IColumn StandardCost{
                get{
                    return this.GetColumn("StandardCost");
                }
            }
            				
   			public static string StandardCostColumn{
			      get{
        			return "StandardCost";
      			}
		    }
           
            public IColumn ListPrice{
                get{
                    return this.GetColumn("ListPrice");
                }
            }
            				
   			public static string ListPriceColumn{
			      get{
        			return "ListPrice";
      			}
		    }
           
            public IColumn Size{
                get{
                    return this.GetColumn("Size");
                }
            }
            				
   			public static string SizeColumn{
			      get{
        			return "Size";
      			}
		    }
           
            public IColumn SizeUnitMeasureCode{
                get{
                    return this.GetColumn("SizeUnitMeasureCode");
                }
            }
            				
   			public static string SizeUnitMeasureCodeColumn{
			      get{
        			return "SizeUnitMeasureCode";
      			}
		    }
           
            public IColumn WeightUnitMeasureCode{
                get{
                    return this.GetColumn("WeightUnitMeasureCode");
                }
            }
            				
   			public static string WeightUnitMeasureCodeColumn{
			      get{
        			return "WeightUnitMeasureCode";
      			}
		    }
           
            public IColumn Weight{
                get{
                    return this.GetColumn("Weight");
                }
            }
            				
   			public static string WeightColumn{
			      get{
        			return "Weight";
      			}
		    }
           
            public IColumn DaysToManufacture{
                get{
                    return this.GetColumn("DaysToManufacture");
                }
            }
            				
   			public static string DaysToManufactureColumn{
			      get{
        			return "DaysToManufacture";
      			}
		    }
           
            public IColumn ProductLine{
                get{
                    return this.GetColumn("ProductLine");
                }
            }
            				
   			public static string ProductLineColumn{
			      get{
        			return "ProductLine";
      			}
		    }
           
            public IColumn Class{
                get{
                    return this.GetColumn("Class");
                }
            }
            				
   			public static string ClassColumn{
			      get{
        			return "Class";
      			}
		    }
           
            public IColumn Style{
                get{
                    return this.GetColumn("Style");
                }
            }
            				
   			public static string StyleColumn{
			      get{
        			return "Style";
      			}
		    }
           
            public IColumn ProductSubcategoryID{
                get{
                    return this.GetColumn("ProductSubcategoryID");
                }
            }
            				
   			public static string ProductSubcategoryIDColumn{
			      get{
        			return "ProductSubcategoryID";
      			}
		    }
           
            public IColumn ProductModelID{
                get{
                    return this.GetColumn("ProductModelID");
                }
            }
            				
   			public static string ProductModelIDColumn{
			      get{
        			return "ProductModelID";
      			}
		    }
           
            public IColumn SellStartDate{
                get{
                    return this.GetColumn("SellStartDate");
                }
            }
            				
   			public static string SellStartDateColumn{
			      get{
        			return "SellStartDate";
      			}
		    }
           
            public IColumn SellEndDate{
                get{
                    return this.GetColumn("SellEndDate");
                }
            }
            				
   			public static string SellEndDateColumn{
			      get{
        			return "SellEndDate";
      			}
		    }
           
            public IColumn DiscontinuedDate{
                get{
                    return this.GetColumn("DiscontinuedDate");
                }
            }
            				
   			public static string DiscontinuedDateColumn{
			      get{
        			return "DiscontinuedDate";
      			}
		    }
           
            public IColumn rowguid{
                get{
                    return this.GetColumn("rowguid");
                }
            }
            				
   			public static string rowguidColumn{
			      get{
        			return "rowguid";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: SalesTerritoryHistory
        /// Primary Key: SalesPersonID
        /// </summary>

        public class SalesTerritoryHistoryTable: DatabaseTable {
            
            public SalesTerritoryHistoryTable(IDataProvider provider):base("SalesTerritoryHistory",provider){
                ClassName = "SalesTerritoryHistory";
                SchemaName = "Sales";
                

                Columns.Add(new DatabaseColumn("SalesPersonID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("TerritoryID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StartDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("EndDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("rowguid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn SalesPersonID{
                get{
                    return this.GetColumn("SalesPersonID");
                }
            }
            				
   			public static string SalesPersonIDColumn{
			      get{
        			return "SalesPersonID";
      			}
		    }
           
            public IColumn TerritoryID{
                get{
                    return this.GetColumn("TerritoryID");
                }
            }
            				
   			public static string TerritoryIDColumn{
			      get{
        			return "TerritoryID";
      			}
		    }
           
            public IColumn StartDate{
                get{
                    return this.GetColumn("StartDate");
                }
            }
            				
   			public static string StartDateColumn{
			      get{
        			return "StartDate";
      			}
		    }
           
            public IColumn EndDate{
                get{
                    return this.GetColumn("EndDate");
                }
            }
            				
   			public static string EndDateColumn{
			      get{
        			return "EndDate";
      			}
		    }
           
            public IColumn rowguid{
                get{
                    return this.GetColumn("rowguid");
                }
            }
            				
   			public static string rowguidColumn{
			      get{
        			return "rowguid";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: ScrapReason
        /// Primary Key: ScrapReasonID
        /// </summary>

        public class ScrapReasonTable: DatabaseTable {
            
            public ScrapReasonTable(IDataProvider provider):base("ScrapReason",provider){
                ClassName = "ScrapReason";
                SchemaName = "Production";
                

                Columns.Add(new DatabaseColumn("ScrapReasonID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int16,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ScrapReasonID{
                get{
                    return this.GetColumn("ScrapReasonID");
                }
            }
            				
   			public static string ScrapReasonIDColumn{
			      get{
        			return "ScrapReasonID";
      			}
		    }
           
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
            				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: Shift
        /// Primary Key: ShiftID
        /// </summary>

        public class ShiftTable: DatabaseTable {
            
            public ShiftTable(IDataProvider provider):base("Shift",provider){
                ClassName = "Shift";
                SchemaName = "HumanResources";
                

                Columns.Add(new DatabaseColumn("ShiftID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Byte,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("StartTime", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("EndTime", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ShiftID{
                get{
                    return this.GetColumn("ShiftID");
                }
            }
            				
   			public static string ShiftIDColumn{
			      get{
        			return "ShiftID";
      			}
		    }
           
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
            				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
           
            public IColumn StartTime{
                get{
                    return this.GetColumn("StartTime");
                }
            }
            				
   			public static string StartTimeColumn{
			      get{
        			return "StartTime";
      			}
		    }
           
            public IColumn EndTime{
                get{
                    return this.GetColumn("EndTime");
                }
            }
            				
   			public static string EndTimeColumn{
			      get{
        			return "EndTime";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: ProductCategory
        /// Primary Key: ProductCategoryID
        /// </summary>

        public class ProductCategoryTable: DatabaseTable {
            
            public ProductCategoryTable(IDataProvider provider):base("ProductCategory",provider){
                ClassName = "ProductCategory";
                SchemaName = "Production";
                

                Columns.Add(new DatabaseColumn("ProductCategoryID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("rowguid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ProductCategoryID{
                get{
                    return this.GetColumn("ProductCategoryID");
                }
            }
            				
   			public static string ProductCategoryIDColumn{
			      get{
        			return "ProductCategoryID";
      			}
		    }
           
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
            				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
           
            public IColumn rowguid{
                get{
                    return this.GetColumn("rowguid");
                }
            }
            				
   			public static string rowguidColumn{
			      get{
        			return "rowguid";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: ShipMethod
        /// Primary Key: ShipMethodID
        /// </summary>

        public class ShipMethodTable: DatabaseTable {
            
            public ShipMethodTable(IDataProvider provider):base("ShipMethod",provider){
                ClassName = "ShipMethod";
                SchemaName = "Purchasing";
                

                Columns.Add(new DatabaseColumn("ShipMethodID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("ShipBase", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ShipRate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("rowguid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ShipMethodID{
                get{
                    return this.GetColumn("ShipMethodID");
                }
            }
            				
   			public static string ShipMethodIDColumn{
			      get{
        			return "ShipMethodID";
      			}
		    }
           
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
            				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
           
            public IColumn ShipBase{
                get{
                    return this.GetColumn("ShipBase");
                }
            }
            				
   			public static string ShipBaseColumn{
			      get{
        			return "ShipBase";
      			}
		    }
           
            public IColumn ShipRate{
                get{
                    return this.GetColumn("ShipRate");
                }
            }
            				
   			public static string ShipRateColumn{
			      get{
        			return "ShipRate";
      			}
		    }
           
            public IColumn rowguid{
                get{
                    return this.GetColumn("rowguid");
                }
            }
            				
   			public static string rowguidColumn{
			      get{
        			return "rowguid";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: ProductCostHistory
        /// Primary Key: ProductID
        /// </summary>

        public class ProductCostHistoryTable: DatabaseTable {
            
            public ProductCostHistoryTable(IDataProvider provider):base("ProductCostHistory",provider){
                ClassName = "ProductCostHistory";
                SchemaName = "Production";
                

                Columns.Add(new DatabaseColumn("ProductID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StartDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("EndDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StandardCost", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ProductID{
                get{
                    return this.GetColumn("ProductID");
                }
            }
            				
   			public static string ProductIDColumn{
			      get{
        			return "ProductID";
      			}
		    }
           
            public IColumn StartDate{
                get{
                    return this.GetColumn("StartDate");
                }
            }
            				
   			public static string StartDateColumn{
			      get{
        			return "StartDate";
      			}
		    }
           
            public IColumn EndDate{
                get{
                    return this.GetColumn("EndDate");
                }
            }
            				
   			public static string EndDateColumn{
			      get{
        			return "EndDate";
      			}
		    }
           
            public IColumn StandardCost{
                get{
                    return this.GetColumn("StandardCost");
                }
            }
            				
   			public static string StandardCostColumn{
			      get{
        			return "StandardCost";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: ProductDescription
        /// Primary Key: ProductDescriptionID
        /// </summary>

        public class ProductDescriptionTable: DatabaseTable {
            
            public ProductDescriptionTable(IDataProvider provider):base("ProductDescription",provider){
                ClassName = "ProductDescription";
                SchemaName = "Production";
                

                Columns.Add(new DatabaseColumn("ProductDescriptionID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 400
                });

                Columns.Add(new DatabaseColumn("rowguid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ProductDescriptionID{
                get{
                    return this.GetColumn("ProductDescriptionID");
                }
            }
            				
   			public static string ProductDescriptionIDColumn{
			      get{
        			return "ProductDescriptionID";
      			}
		    }
           
            public IColumn Description{
                get{
                    return this.GetColumn("Description");
                }
            }
            				
   			public static string DescriptionColumn{
			      get{
        			return "Description";
      			}
		    }
           
            public IColumn rowguid{
                get{
                    return this.GetColumn("rowguid");
                }
            }
            				
   			public static string rowguidColumn{
			      get{
        			return "rowguid";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: ShoppingCartItem
        /// Primary Key: ShoppingCartItemID
        /// </summary>

        public class ShoppingCartItemTable: DatabaseTable {
            
            public ShoppingCartItemTable(IDataProvider provider):base("ShoppingCartItem",provider){
                ClassName = "ShoppingCartItem";
                SchemaName = "Sales";
                

                Columns.Add(new DatabaseColumn("ShoppingCartItemID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ShoppingCartID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Quantity", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ProductID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DateCreated", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ShoppingCartItemID{
                get{
                    return this.GetColumn("ShoppingCartItemID");
                }
            }
            				
   			public static string ShoppingCartItemIDColumn{
			      get{
        			return "ShoppingCartItemID";
      			}
		    }
           
            public IColumn ShoppingCartID{
                get{
                    return this.GetColumn("ShoppingCartID");
                }
            }
            				
   			public static string ShoppingCartIDColumn{
			      get{
        			return "ShoppingCartID";
      			}
		    }
           
            public IColumn Quantity{
                get{
                    return this.GetColumn("Quantity");
                }
            }
            				
   			public static string QuantityColumn{
			      get{
        			return "Quantity";
      			}
		    }
           
            public IColumn ProductID{
                get{
                    return this.GetColumn("ProductID");
                }
            }
            				
   			public static string ProductIDColumn{
			      get{
        			return "ProductID";
      			}
		    }
           
            public IColumn DateCreated{
                get{
                    return this.GetColumn("DateCreated");
                }
            }
            				
   			public static string DateCreatedColumn{
			      get{
        			return "DateCreated";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: ProductDocument
        /// Primary Key: DocumentID
        /// </summary>

        public class ProductDocumentTable: DatabaseTable {
            
            public ProductDocumentTable(IDataProvider provider):base("ProductDocument",provider){
                ClassName = "ProductDocument";
                SchemaName = "Production";
                

                Columns.Add(new DatabaseColumn("ProductID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DocumentID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ProductID{
                get{
                    return this.GetColumn("ProductID");
                }
            }
            				
   			public static string ProductIDColumn{
			      get{
        			return "ProductID";
      			}
		    }
           
            public IColumn DocumentID{
                get{
                    return this.GetColumn("DocumentID");
                }
            }
            				
   			public static string DocumentIDColumn{
			      get{
        			return "DocumentID";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: ProductInventory
        /// Primary Key: LocationID
        /// </summary>

        public class ProductInventoryTable: DatabaseTable {
            
            public ProductInventoryTable(IDataProvider provider):base("ProductInventory",provider){
                ClassName = "ProductInventory";
                SchemaName = "Production";
                

                Columns.Add(new DatabaseColumn("ProductID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LocationID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int16,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Shelf", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 10
                });

                Columns.Add(new DatabaseColumn("Bin", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Byte,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Quantity", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int16,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("rowguid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ProductID{
                get{
                    return this.GetColumn("ProductID");
                }
            }
            				
   			public static string ProductIDColumn{
			      get{
        			return "ProductID";
      			}
		    }
           
            public IColumn LocationID{
                get{
                    return this.GetColumn("LocationID");
                }
            }
            				
   			public static string LocationIDColumn{
			      get{
        			return "LocationID";
      			}
		    }
           
            public IColumn Shelf{
                get{
                    return this.GetColumn("Shelf");
                }
            }
            				
   			public static string ShelfColumn{
			      get{
        			return "Shelf";
      			}
		    }
           
            public IColumn Bin{
                get{
                    return this.GetColumn("Bin");
                }
            }
            				
   			public static string BinColumn{
			      get{
        			return "Bin";
      			}
		    }
           
            public IColumn Quantity{
                get{
                    return this.GetColumn("Quantity");
                }
            }
            				
   			public static string QuantityColumn{
			      get{
        			return "Quantity";
      			}
		    }
           
            public IColumn rowguid{
                get{
                    return this.GetColumn("rowguid");
                }
            }
            				
   			public static string rowguidColumn{
			      get{
        			return "rowguid";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: SpecialOffer
        /// Primary Key: SpecialOfferID
        /// </summary>

        public class SpecialOfferTable: DatabaseTable {
            
            public SpecialOfferTable(IDataProvider provider):base("SpecialOffer",provider){
                ClassName = "SpecialOffer";
                SchemaName = "Sales";
                

                Columns.Add(new DatabaseColumn("SpecialOfferID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("DiscountPct", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Type", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Category", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("StartDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("EndDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MinQty", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MaxQty", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("rowguid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn SpecialOfferID{
                get{
                    return this.GetColumn("SpecialOfferID");
                }
            }
            				
   			public static string SpecialOfferIDColumn{
			      get{
        			return "SpecialOfferID";
      			}
		    }
           
            public IColumn Description{
                get{
                    return this.GetColumn("Description");
                }
            }
            				
   			public static string DescriptionColumn{
			      get{
        			return "Description";
      			}
		    }
           
            public IColumn DiscountPct{
                get{
                    return this.GetColumn("DiscountPct");
                }
            }
            				
   			public static string DiscountPctColumn{
			      get{
        			return "DiscountPct";
      			}
		    }
           
            public IColumn Type{
                get{
                    return this.GetColumn("Type");
                }
            }
            				
   			public static string TypeColumn{
			      get{
        			return "Type";
      			}
		    }
           
            public IColumn Category{
                get{
                    return this.GetColumn("Category");
                }
            }
            				
   			public static string CategoryColumn{
			      get{
        			return "Category";
      			}
		    }
           
            public IColumn StartDate{
                get{
                    return this.GetColumn("StartDate");
                }
            }
            				
   			public static string StartDateColumn{
			      get{
        			return "StartDate";
      			}
		    }
           
            public IColumn EndDate{
                get{
                    return this.GetColumn("EndDate");
                }
            }
            				
   			public static string EndDateColumn{
			      get{
        			return "EndDate";
      			}
		    }
           
            public IColumn MinQty{
                get{
                    return this.GetColumn("MinQty");
                }
            }
            				
   			public static string MinQtyColumn{
			      get{
        			return "MinQty";
      			}
		    }
           
            public IColumn MaxQty{
                get{
                    return this.GetColumn("MaxQty");
                }
            }
            				
   			public static string MaxQtyColumn{
			      get{
        			return "MaxQty";
      			}
		    }
           
            public IColumn rowguid{
                get{
                    return this.GetColumn("rowguid");
                }
            }
            				
   			public static string rowguidColumn{
			      get{
        			return "rowguid";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: ProductListPriceHistory
        /// Primary Key: ProductID
        /// </summary>

        public class ProductListPriceHistoryTable: DatabaseTable {
            
            public ProductListPriceHistoryTable(IDataProvider provider):base("ProductListPriceHistory",provider){
                ClassName = "ProductListPriceHistory";
                SchemaName = "Production";
                

                Columns.Add(new DatabaseColumn("ProductID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StartDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("EndDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ListPrice", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ProductID{
                get{
                    return this.GetColumn("ProductID");
                }
            }
            				
   			public static string ProductIDColumn{
			      get{
        			return "ProductID";
      			}
		    }
           
            public IColumn StartDate{
                get{
                    return this.GetColumn("StartDate");
                }
            }
            				
   			public static string StartDateColumn{
			      get{
        			return "StartDate";
      			}
		    }
           
            public IColumn EndDate{
                get{
                    return this.GetColumn("EndDate");
                }
            }
            				
   			public static string EndDateColumn{
			      get{
        			return "EndDate";
      			}
		    }
           
            public IColumn ListPrice{
                get{
                    return this.GetColumn("ListPrice");
                }
            }
            				
   			public static string ListPriceColumn{
			      get{
        			return "ListPrice";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: SpecialOfferProduct
        /// Primary Key: ProductID
        /// </summary>

        public class SpecialOfferProductTable: DatabaseTable {
            
            public SpecialOfferProductTable(IDataProvider provider):base("SpecialOfferProduct",provider){
                ClassName = "SpecialOfferProduct";
                SchemaName = "Sales";
                

                Columns.Add(new DatabaseColumn("SpecialOfferID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ProductID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("rowguid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn SpecialOfferID{
                get{
                    return this.GetColumn("SpecialOfferID");
                }
            }
            				
   			public static string SpecialOfferIDColumn{
			      get{
        			return "SpecialOfferID";
      			}
		    }
           
            public IColumn ProductID{
                get{
                    return this.GetColumn("ProductID");
                }
            }
            				
   			public static string ProductIDColumn{
			      get{
        			return "ProductID";
      			}
		    }
           
            public IColumn rowguid{
                get{
                    return this.GetColumn("rowguid");
                }
            }
            				
   			public static string rowguidColumn{
			      get{
        			return "rowguid";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: ProductModel
        /// Primary Key: ProductModelID
        /// </summary>

        public class ProductModelTable: DatabaseTable {
            
            public ProductModelTable(IDataProvider provider):base("ProductModel",provider){
                ClassName = "ProductModel";
                SchemaName = "Production";
                

                Columns.Add(new DatabaseColumn("ProductModelID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("CatalogDescription", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Xml,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Instructions", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Xml,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("rowguid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ProductModelID{
                get{
                    return this.GetColumn("ProductModelID");
                }
            }
            				
   			public static string ProductModelIDColumn{
			      get{
        			return "ProductModelID";
      			}
		    }
           
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
            				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
           
            public IColumn CatalogDescription{
                get{
                    return this.GetColumn("CatalogDescription");
                }
            }
            				
   			public static string CatalogDescriptionColumn{
			      get{
        			return "CatalogDescription";
      			}
		    }
           
            public IColumn Instructions{
                get{
                    return this.GetColumn("Instructions");
                }
            }
            				
   			public static string InstructionsColumn{
			      get{
        			return "Instructions";
      			}
		    }
           
            public IColumn rowguid{
                get{
                    return this.GetColumn("rowguid");
                }
            }
            				
   			public static string rowguidColumn{
			      get{
        			return "rowguid";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: StateProvince
        /// Primary Key: StateProvinceID
        /// </summary>

        public class StateProvinceTable: DatabaseTable {
            
            public StateProvinceTable(IDataProvider provider):base("StateProvince",provider){
                ClassName = "StateProvince";
                SchemaName = "Person";
                

                Columns.Add(new DatabaseColumn("StateProvinceID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StateProvinceCode", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 3
                });

                Columns.Add(new DatabaseColumn("CountryRegionCode", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 3
                });

                Columns.Add(new DatabaseColumn("IsOnlyStateProvinceFlag", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("TerritoryID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("rowguid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn StateProvinceID{
                get{
                    return this.GetColumn("StateProvinceID");
                }
            }
            				
   			public static string StateProvinceIDColumn{
			      get{
        			return "StateProvinceID";
      			}
		    }
           
            public IColumn StateProvinceCode{
                get{
                    return this.GetColumn("StateProvinceCode");
                }
            }
            				
   			public static string StateProvinceCodeColumn{
			      get{
        			return "StateProvinceCode";
      			}
		    }
           
            public IColumn CountryRegionCode{
                get{
                    return this.GetColumn("CountryRegionCode");
                }
            }
            				
   			public static string CountryRegionCodeColumn{
			      get{
        			return "CountryRegionCode";
      			}
		    }
           
            public IColumn IsOnlyStateProvinceFlag{
                get{
                    return this.GetColumn("IsOnlyStateProvinceFlag");
                }
            }
            				
   			public static string IsOnlyStateProvinceFlagColumn{
			      get{
        			return "IsOnlyStateProvinceFlag";
      			}
		    }
           
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
            				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
           
            public IColumn TerritoryID{
                get{
                    return this.GetColumn("TerritoryID");
                }
            }
            				
   			public static string TerritoryIDColumn{
			      get{
        			return "TerritoryID";
      			}
		    }
           
            public IColumn rowguid{
                get{
                    return this.GetColumn("rowguid");
                }
            }
            				
   			public static string rowguidColumn{
			      get{
        			return "rowguid";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: ProductModelIllustration
        /// Primary Key: IllustrationID
        /// </summary>

        public class ProductModelIllustrationTable: DatabaseTable {
            
            public ProductModelIllustrationTable(IDataProvider provider):base("ProductModelIllustration",provider){
                ClassName = "ProductModelIllustration";
                SchemaName = "Production";
                

                Columns.Add(new DatabaseColumn("ProductModelID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IllustrationID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ProductModelID{
                get{
                    return this.GetColumn("ProductModelID");
                }
            }
            				
   			public static string ProductModelIDColumn{
			      get{
        			return "ProductModelID";
      			}
		    }
           
            public IColumn IllustrationID{
                get{
                    return this.GetColumn("IllustrationID");
                }
            }
            				
   			public static string IllustrationIDColumn{
			      get{
        			return "IllustrationID";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: DatabaseLog
        /// Primary Key: DatabaseLogID
        /// </summary>

        public class DatabaseLogTable: DatabaseTable {
            
            public DatabaseLogTable(IDataProvider provider):base("DatabaseLog",provider){
                ClassName = "DatabaseLog";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("DatabaseLogID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PostTime", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DatabaseUser", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 128
                });

                Columns.Add(new DatabaseColumn("Event", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 128
                });

                Columns.Add(new DatabaseColumn("Schema", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 128
                });

                Columns.Add(new DatabaseColumn("Object", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 128
                });

                Columns.Add(new DatabaseColumn("TSQL", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("XmlEvent", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Xml,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn DatabaseLogID{
                get{
                    return this.GetColumn("DatabaseLogID");
                }
            }
            				
   			public static string DatabaseLogIDColumn{
			      get{
        			return "DatabaseLogID";
      			}
		    }
           
            public IColumn PostTime{
                get{
                    return this.GetColumn("PostTime");
                }
            }
            				
   			public static string PostTimeColumn{
			      get{
        			return "PostTime";
      			}
		    }
           
            public IColumn DatabaseUser{
                get{
                    return this.GetColumn("DatabaseUser");
                }
            }
            				
   			public static string DatabaseUserColumn{
			      get{
        			return "DatabaseUser";
      			}
		    }
           
            public IColumn Event{
                get{
                    return this.GetColumn("Event");
                }
            }
            				
   			public static string EventColumn{
			      get{
        			return "Event";
      			}
		    }
           
            public IColumn Schema{
                get{
                    return this.GetColumn("Schema");
                }
            }
            				
   			public static string SchemaColumn{
			      get{
        			return "Schema";
      			}
		    }
           
            public IColumn Object{
                get{
                    return this.GetColumn("Object");
                }
            }
            				
   			public static string ObjectColumn{
			      get{
        			return "Object";
      			}
		    }
           
            public IColumn TSQL{
                get{
                    return this.GetColumn("TSQL");
                }
            }
            				
   			public static string TSQLColumn{
			      get{
        			return "TSQL";
      			}
		    }
           
            public IColumn XmlEvent{
                get{
                    return this.GetColumn("XmlEvent");
                }
            }
            				
   			public static string XmlEventColumn{
			      get{
        			return "XmlEvent";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: ProductModelProductDescriptionCulture
        /// Primary Key: CultureID
        /// </summary>

        public class ProductModelProductDescriptionCultureTable: DatabaseTable {
            
            public ProductModelProductDescriptionCultureTable(IDataProvider provider):base("ProductModelProductDescriptionCulture",provider){
                ClassName = "ProductModelProductDescriptionCulture";
                SchemaName = "Production";
                

                Columns.Add(new DatabaseColumn("ProductModelID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ProductDescriptionID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CultureID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 6
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ProductModelID{
                get{
                    return this.GetColumn("ProductModelID");
                }
            }
            				
   			public static string ProductModelIDColumn{
			      get{
        			return "ProductModelID";
      			}
		    }
           
            public IColumn ProductDescriptionID{
                get{
                    return this.GetColumn("ProductDescriptionID");
                }
            }
            				
   			public static string ProductDescriptionIDColumn{
			      get{
        			return "ProductDescriptionID";
      			}
		    }
           
            public IColumn CultureID{
                get{
                    return this.GetColumn("CultureID");
                }
            }
            				
   			public static string CultureIDColumn{
			      get{
        			return "CultureID";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: ErrorLog
        /// Primary Key: ErrorLogID
        /// </summary>

        public class ErrorLogTable: DatabaseTable {
            
            public ErrorLogTable(IDataProvider provider):base("ErrorLog",provider){
                ClassName = "ErrorLog";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ErrorLogID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ErrorTime", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UserName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 128
                });

                Columns.Add(new DatabaseColumn("ErrorNumber", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ErrorSeverity", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ErrorState", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ErrorProcedure", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 126
                });

                Columns.Add(new DatabaseColumn("ErrorLine", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ErrorMessage", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 4000
                });
                    
                
                
            }
            
            public IColumn ErrorLogID{
                get{
                    return this.GetColumn("ErrorLogID");
                }
            }
            				
   			public static string ErrorLogIDColumn{
			      get{
        			return "ErrorLogID";
      			}
		    }
           
            public IColumn ErrorTime{
                get{
                    return this.GetColumn("ErrorTime");
                }
            }
            				
   			public static string ErrorTimeColumn{
			      get{
        			return "ErrorTime";
      			}
		    }
           
            public IColumn UserName{
                get{
                    return this.GetColumn("UserName");
                }
            }
            				
   			public static string UserNameColumn{
			      get{
        			return "UserName";
      			}
		    }
           
            public IColumn ErrorNumber{
                get{
                    return this.GetColumn("ErrorNumber");
                }
            }
            				
   			public static string ErrorNumberColumn{
			      get{
        			return "ErrorNumber";
      			}
		    }
           
            public IColumn ErrorSeverity{
                get{
                    return this.GetColumn("ErrorSeverity");
                }
            }
            				
   			public static string ErrorSeverityColumn{
			      get{
        			return "ErrorSeverity";
      			}
		    }
           
            public IColumn ErrorState{
                get{
                    return this.GetColumn("ErrorState");
                }
            }
            				
   			public static string ErrorStateColumn{
			      get{
        			return "ErrorState";
      			}
		    }
           
            public IColumn ErrorProcedure{
                get{
                    return this.GetColumn("ErrorProcedure");
                }
            }
            				
   			public static string ErrorProcedureColumn{
			      get{
        			return "ErrorProcedure";
      			}
		    }
           
            public IColumn ErrorLine{
                get{
                    return this.GetColumn("ErrorLine");
                }
            }
            				
   			public static string ErrorLineColumn{
			      get{
        			return "ErrorLine";
      			}
		    }
           
            public IColumn ErrorMessage{
                get{
                    return this.GetColumn("ErrorMessage");
                }
            }
            				
   			public static string ErrorMessageColumn{
			      get{
        			return "ErrorMessage";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: Store
        /// Primary Key: CustomerID
        /// </summary>

        public class StoreTable: DatabaseTable {
            
            public StoreTable(IDataProvider provider):base("Store",provider){
                ClassName = "Store";
                SchemaName = "Sales";
                

                Columns.Add(new DatabaseColumn("CustomerID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("SalesPersonID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Demographics", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Xml,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("rowguid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Guid,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn CustomerID{
                get{
                    return this.GetColumn("CustomerID");
                }
            }
            				
   			public static string CustomerIDColumn{
			      get{
        			return "CustomerID";
      			}
		    }
           
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
            				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
           
            public IColumn SalesPersonID{
                get{
                    return this.GetColumn("SalesPersonID");
                }
            }
            				
   			public static string SalesPersonIDColumn{
			      get{
        			return "SalesPersonID";
      			}
		    }
           
            public IColumn Demographics{
                get{
                    return this.GetColumn("Demographics");
                }
            }
            				
   			public static string DemographicsColumn{
			      get{
        			return "Demographics";
      			}
		    }
           
            public IColumn rowguid{
                get{
                    return this.GetColumn("rowguid");
                }
            }
            				
   			public static string rowguidColumn{
			      get{
        			return "rowguid";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: ProductPhoto
        /// Primary Key: ProductPhotoID
        /// </summary>

        public class ProductPhotoTable: DatabaseTable {
            
            public ProductPhotoTable(IDataProvider provider):base("ProductPhoto",provider){
                ClassName = "ProductPhoto";
                SchemaName = "Production";
                

                Columns.Add(new DatabaseColumn("ProductPhotoID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ThumbNailPhoto", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Binary,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("ThumbnailPhotoFileName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("LargePhoto", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Binary,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("LargePhotoFileName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("ModifiedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ProductPhotoID{
                get{
                    return this.GetColumn("ProductPhotoID");
                }
            }
            				
   			public static string ProductPhotoIDColumn{
			      get{
        			return "ProductPhotoID";
      			}
		    }
           
            public IColumn ThumbNailPhoto{
                get{
                    return this.GetColumn("ThumbNailPhoto");
                }
            }
            				
   			public static string ThumbNailPhotoColumn{
			      get{
        			return "ThumbNailPhoto";
      			}
		    }
           
            public IColumn ThumbnailPhotoFileName{
                get{
                    return this.GetColumn("ThumbnailPhotoFileName");
                }
            }
            				
   			public static string ThumbnailPhotoFileNameColumn{
			      get{
        			return "ThumbnailPhotoFileName";
      			}
		    }
           
            public IColumn LargePhoto{
                get{
                    return this.GetColumn("LargePhoto");
                }
            }
            				
   			public static string LargePhotoColumn{
			      get{
        			return "LargePhoto";
      			}
		    }
           
            public IColumn LargePhotoFileName{
                get{
                    return this.GetColumn("LargePhotoFileName");
                }
            }
            				
   			public static string LargePhotoFileNameColumn{
			      get{
        			return "LargePhotoFileName";
      			}
		    }
           
            public IColumn ModifiedDate{
                get{
                    return this.GetColumn("ModifiedDate");
                }
            }
            				
   			public static string ModifiedDateColumn{
			      get{
        			return "ModifiedDate";
      			}
		    }
           
                    
        }
        
}



  
using System;
using SubSonic;
using SubSonic.Schema;
using SubSonic.DataProviders;
using System.Data;

namespace AdventureWorks.Data{
	public partial class NorthwindDB{

        public StoredProcedure uspGetBillOfMaterials(){
            StoredProcedure sp=new StoredProcedure("uspGetBillOfMaterials",this.Provider);
            return sp;
        }
        public StoredProcedure uspGetEmployeeManagers(){
            StoredProcedure sp=new StoredProcedure("uspGetEmployeeManagers",this.Provider);
            return sp;
        }
        public StoredProcedure uspGetEmployeesByHireDate(){
            StoredProcedure sp=new StoredProcedure("uspGetEmployeesByHireDate",this.Provider);
            return sp;
        }
        public StoredProcedure uspGetManagerEmployees(){
            StoredProcedure sp=new StoredProcedure("uspGetManagerEmployees",this.Provider);
            return sp;
        }
        public StoredProcedure uspGetWhereUsedProductID(){
            StoredProcedure sp=new StoredProcedure("uspGetWhereUsedProductID",this.Provider);
            return sp;
        }
        public StoredProcedure uspLogError(){
            StoredProcedure sp=new StoredProcedure("uspLogError",this.Provider);
            return sp;
        }
        public StoredProcedure uspPrintError(){
            StoredProcedure sp=new StoredProcedure("uspPrintError",this.Provider);
            return sp;
        }
        public StoredProcedure uspUpdateEmployeeHireInfo(){
            StoredProcedure sp=new StoredProcedure("uspUpdateEmployeeHireInfo",this.Provider);
            return sp;
        }
        public StoredProcedure uspUpdateEmployeeLogin(){
            StoredProcedure sp=new StoredProcedure("uspUpdateEmployeeLogin",this.Provider);
            return sp;
        }
        public StoredProcedure uspUpdateEmployeePersonalInfo(){
            StoredProcedure sp=new StoredProcedure("uspUpdateEmployeePersonalInfo",this.Provider);
            return sp;
        }
	
	}
	
}
 
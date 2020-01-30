using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetTest.DataSets;
using NetTest.DataSets.sitedbTableAdapters;

namespace NetTest.Models
{
    class mAccount
    {
        public Guid? accountLoggedIn()
        {
            Guid? ret = null;
            spGetAccountLoggedInTableAdapter ta = new spGetAccountLoggedInTableAdapter();
            sitedb.spGetAccountLoggedInDataTable dt = ta.GetData();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    sitedb.spGetAccountLoggedInRow dr = dt[0];
                    if (!dr.IsacaAccountNull())
                    {
                        ret = dr.acaAccount;
                    }
                }
            }
            return ret;
        }
    }

    class cAccount
    {
        public cAccount()
        {

        }


        public cAccount(sitedb.spAccountReadByIdDataTable dt)
        {
            accId = dt[0].accId;
            accFirstName = dt[0].accFirstName;
            accLastName = dt[0].accLastName;
            accUserName = dt[0].accUserName;
            accAccountTypeList = new List<cAccountType>();

            foreach (sitedb.spAccountReadByIdRow dr in dt)
            {
                accAccountTypeList.Add(new cAccountType(dr));
            }
        }


        public cAccount readById(Guid accId)
        {
            cAccount ret = null;

            spAccountReadByIdTableAdapter ta = new spAccountReadByIdTableAdapter();
            sitedb.spAccountReadByIdDataTable dt = ta.GetData(accId);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ret = new cAccount(dt);
                }
            }


            return ret;
        }

        public Guid accId;
        public string accFirstName;
        public string accLastName;
        public string accUserName;
        public List<cAccountType> accAccountTypeList;
    }

    class cAccountType
    {
        public cAccountType(sitedb.spAccountReadByIdRow dr)
        {
            actkey = dr.actKey.Trim();
            actName = dr.actName;
        }
        public string actName;
        public string actkey;
    }
}

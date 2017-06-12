using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using EntityDAL;
using adoDAL;
using iDAL;

namespace ObjectFactory
{
    public class Factory
    {
        enum EnumDalType { ADO, EF };
        EnumDalType DalType = EnumDalType.EF;
        iDAL.iDAL _iDAL;
        Dictionary<EnumDalType, iDAL.iDAL> _dictionaryDAL = new Dictionary<EnumDalType, iDAL.iDAL>();

        public iDAL.iDAL GetDAL()
        {
            if(_dictionaryDAL.Count == 0)
            {
                _dictionaryDAL.Add(EnumDalType.ADO, new AdoDal());
                _dictionaryDAL.Add(EnumDalType.EF, new EntityDAL.EntityDAL());
            }

            _dictionaryDAL.TryGetValue(DalType, out _iDAL);
            return _iDAL;
        }
    }
}

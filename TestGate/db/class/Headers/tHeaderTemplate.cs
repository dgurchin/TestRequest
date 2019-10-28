namespace TestRequest.db
{
    partial class tHeaderTemplate
    {
        public static tHeaderTemplate byID(int ID_Header_Template)
        {
            foreach (var VARIABLE in FindAllByProperty("ID_Header_Template", ID_Header_Template))
            {
                if (VARIABLE.ID_Header_Template == ID_Header_Template)
                {
                    return VARIABLE;
                }
            }

            return null;
        }


        public static tHeaderTemplate byINDEX(int INDEX_Header_Template)
        {


            return FindAll()[INDEX_Header_Template];
        }


    }
}

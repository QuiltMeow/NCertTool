namespace NCertListParser
{
    public static class Constant
    {
        public const string ID_LIST_FILE = "IDList.txt";

        public const string DETAIL_DATA_LIST_FILE = "DetailDataList.txt";

        public const string HOME_PAGE = "https://www.ncert.nat.gov.tw/";

        public const string ID_CRAWL_CODE = @"
            (() => {
                let ret = """";
                $(""#anaList > tbody > tr"").each(function () {
                    ret += $(this).find(""td"").eq(1).text() + ""\r\n"";
                });
                return ret;
            })();
        ";

        public const string DETAIL_DATA_CRAWL_CODE = @"
            (() => {
                let ret = new Map();
                $("".datalist"").each(function () {
                    $(this).find(""li"").each(function () {
                        let title = $(this).find(""span"").text();
                        let content = $(this).find(""div"").text();
                        ret.set(title, content);
                    });
                });
                return JSON.stringify(Object.fromEntries(ret));
            })();
        ";
    }
}
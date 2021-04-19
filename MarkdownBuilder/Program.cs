using System;

namespace Builder
{
    
    class MarkdownBuilder
    {
        private string markdown;

        public MarkdownBuilder()
        {
            markdown = "";
        }

        public MarkdownBuilder addCustomizedTag( string tag )
        {
            markdown += tag;
            return this;
        }
        public MarkdownBuilder addString(  string content, int size = 0)
        {
            markdown += "\n";
            for( int i = 0; i < size; ++i)
                markdown += "#";

            markdown += " " + content + "  \n";

            return this;
        }
        
        public MarkdownBuilder addNewLine()
        {
             markdown += "\n";
            return this;
        }
        public MarkdownBuilder addBoldedString( string content)
        {
            markdown += "**" + content + "**  ";
            return this;
        }
        public MarkdownBuilder addItalicString( string content)
        {
             markdown += "*" + content + "*";
            return this;
        }
        public MarkdownBuilder addBlockqoute( string content)
        {
            
            markdown += "\n > " + content + "  \n";
            return this;
        }
        public MarkdownBuilder addOLitem( string [] items )
        {
            
            for( int i = 0; i < items.Length; ++i )
            {
                markdown += (i+1) + ". " + items[i] + "  \n";   
            }
            markdown += "\n";
            return this;
        }
        public MarkdownBuilder addULitem( string [] items)
        { 
            
            for( int i = 0; i < items.Length; ++i)
            {
                markdown += "- " + items[i] + "  \n";   
            }
            markdown += "\n";
            return this;
        }
        public MarkdownBuilder addCode( string content)
        {
            markdown += "`" + content + "`";
             return this;
        }
        public MarkdownBuilder addHorizontalLine()
        { 
            markdown += "\n ---- \n";
            return this;
        }
        public MarkdownBuilder addLink( string title, string url)
        { 
            markdown += "\n[" + title + "]" + "(" + url + ")  \n";
            return this;
        }
        public MarkdownBuilder addImage( string altText, string source)
        {
            markdown += "\n![" + altText + "]" + "(" + source + ")  \n";
            return this;
        }

        public string get()
        {
            return markdown;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MarkdownBuilder md = new MarkdownBuilder();

            string result = md.addCustomizedTag("<div dir =\"rtl\"> ")
            .addNewLine()
            .addString("وصف المشروع :", 2)
            .addHorizontalLine()
            .addString("المشروع ينقسم الى قسمين:" , 3)
            .addNewLine()
            .addULitem(new string[]{"Find matches:"})
            .addString("هذا القسم يقوم بتحليل مدخل من نوع string لايجاد المتشابه من الرموز. هنا الرموز هي عبارة عن ارقام ")
            .addNewLine()
            .addULitem(new string[]{"String builder:"})
            .addString("في هذا القسم حاولت تطبيق فكرة method chaining و بها بنيت builder للـ Markdown.")
            .addNewLine()
            .addString(" ملاحظة: تم بناء هذه الصفحة بواسطة إستخدام الـ markdown builder.")
            .addNewLine()
            .addCustomizedTag("</div>").get();

            Console.WriteLine(result);
        }
    }
}

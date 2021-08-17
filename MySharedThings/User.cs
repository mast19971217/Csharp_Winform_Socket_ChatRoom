using System;
using System.Collections.Generic;
using System.Text;

namespace MySharedThings
{   [Serializable]//可序列化，用于转成json字符串进行传输
       public class User
    {
        public string Name;//账户名
        public string PassWord;//密码
        public  User(string name,string password)//会覆盖掉"自带"的默认构造函数
        {
            Name = name;
            PassWord = password;
        }
        public User() { }//定义默认构造函数，JsonMapper解析json时要用
        public override bool Equals(object obj)
            //默认自定义的引用类型的Equals方法比较的是两对象地址是否相同（==）
            //而要用到的List中的Contains方法会调用Equals方法
            //需要覆写Equals方法改成比较两对象值
            //没有用到哈希表，不需要覆写GetHashCode方法
        {
            return ((obj as User).Name == this.Name )&&
                ((obj as User).PassWord == this.PassWord);
        }
    }  
}

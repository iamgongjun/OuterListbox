/************************************************************************
 * 名称空间 :  OuterListbox  
 * 项目描述 :     
 * 类 名 称 :  Question
 * 版 本 号 :  v1.0.0.0 
 * 说    明 :     
 * 作    者 :  龚军
 * 创建时间 :  2020/8/7 15:00:20
 * 更新时间 :  2020/8/7 15:00:20
************************************************************************
 * Copyright @ 山东博科诊断科技有限公司 2020. All rights reserved.
************************************************************************/
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OuterListbox
{
    public class Question
    {
        public string Text { get; set; }
        public ObservableCollection<Person> Qestions { get; set; }
        
    }
}

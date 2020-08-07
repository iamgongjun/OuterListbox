/************************************************************************
 * 名称空间 :  OuterListbox  
 * 项目描述 :     
 * 类 名 称 :  Converter1
 * 版 本 号 :  v1.0.0.0 
 * 说    明 :     
 * 作    者 :  龚军
 * 创建时间 :  2020/8/7 16:40:00
 * 更新时间 :  2020/8/7 16:40:00
************************************************************************
 * Copyright @ 山东博科诊断科技有限公司 2020. All rights reserved.
************************************************************************/
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace OuterListbox
{
    public class Converter1 : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (int)value > -1;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

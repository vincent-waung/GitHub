using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class PropertyExpressionParser<T>
    {
     
        private readonly PropertyInfo _property;

        public PropertyExpressionParser(Expression<Func<T, object>> propertyExpression)
        {
          
            _property = GetProperty(propertyExpression);
        }

        private static PropertyInfo GetProperty(Expression<Func<T, object>> exp)
        {
            PropertyInfo result;
            if (exp.Body.NodeType == ExpressionType.Convert)
                result = ((MemberExpression)((UnaryExpression)exp.Body).Operand).Member as PropertyInfo;
            else result = ((MemberExpression)exp.Body).Member as PropertyInfo;

            if (result != null)
                return typeof(T).GetProperty(result.Name);

            throw new ArgumentException(string.Format("Expression '{0}' does not refer to a property.", exp.ToString()));
        }

      

        public string Name
        {
            get { return _property.Name; }
        }

    }
}

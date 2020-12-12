using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace tfm
{
static internal class ExpressionBuilder<t>
    {

        static public Expression<Func<t, bool>> BuildFromString(string left, string right, type type)
        {
            if (string.IsNullOrWhiteSpace(left))
            {
                throw new ArgumentException($"'{nameof(left)}' cannot be null or whitespace", nameof(left));
            }

            if (string.IsNullOrWhiteSpace(right))
            {
                throw new ArgumentException($"'{nameof(right)}' cannot be null or whitespace", nameof(right));
            }

            var parameter = Expression.Parameter(typeof(t), nameof(t));
            var _left = Expression.Property(parameter, left);
            var _right = Expression.Constant(right);

switch(type)
            {
                case type.Equals:
                    var _expression = Expression.Equal(_left, _right);
                    return Expression.Lambda<Func<t, bool>>(_expression, parameter);
                                                        case type.Contains:
                    var _containsMethod = typeof(string).GetMethod("Contains", new[] { typeof(string) });
 var _containsExpression = Expression.Call(_left, _containsMethod, _right);
                    return Expression.Lambda<Func<t, bool>>(_containsExpression, parameter);
                case type.StartsWith:
                    var _startsWithMethod = typeof(string).GetMethod("StartsWith", new[] { typeof(string) });
                    var _startsWithExpression = Expression.Call(_left, _startsWithMethod, _right);
                    return Expression.Lambda<Func<t, bool>>(_startsWithExpression, parameter);
                case type.EndsWith:
                    var _endsWithMethod = typeof(string).GetMethod("EndsWith", new[] { typeof(string) });
                    var _endsWithExpression = Expression.Call(_left, _endsWithMethod, _right);
                    return Expression.Lambda<Func<t, bool>>(_endsWithExpression, parameter);
                default:
                    return null;
            }
                    } // End BuildFromString.

        static public Expression<Func<t, bool>> BuildFromDouble(type type, string left, double lower, double upper = 0.0)
        {
            if (string.IsNullOrWhiteSpace(left))
            {
                throw new ArgumentException($"'{nameof(left)}' cannot be null or whitespace", nameof(left));
            }
           
            var parameter = Expression.Parameter(typeof(t), nameof(t));
            var _property = Expression.Property(parameter, left);
            var _lower = Expression.Constant(lower);
            var _upper = Expression.Constant(upper);

                        switch (type)
            {
                case type.Equals:
                    var _expression = Expression.Equal(_property, _lower);
                    return Expression.Lambda<Func<t, bool>>(_expression, parameter);
                case type.GreaterThan:
                    var _greaterThanExpression = Expression.GreaterThan(_property, _lower);
                    return Expression.Lambda<Func<t, bool>>(_greaterThanExpression, parameter);
                case type.LessThan:
                    var _lessThanExpression = Expression.LessThan(_property, _lower);
                    return Expression.Lambda<Func<t, bool>>(_lessThanExpression, parameter);
                case type.Between:
        if(upper <= lower)
                    {
                        throw new ArgumentOutOfRangeException($"{nameof(upper)} is too small.");
                    }
                    var _lowerExpression = Expression.GreaterThanOrEqual(_property, _lower);
                    var _upperExpression = Expression.LessThanOrEqual(_property, _upper);
                    var _betweenExpression = Expression.AndAlso(_lowerExpression, _upperExpression);
                    return Expression.Lambda<Func<t, bool>>(_betweenExpression, parameter);
                default:
                    return null;
            }
        } // End BuildFromDouble.

        static public Expression<Func<t, bool>> BuildFromInt(type type, string left, int lower, int upper = 0)
        {
            if (string.IsNullOrWhiteSpace(left))
            {
                throw new ArgumentException($"'{nameof(left)}' cannot be null or whitespace", nameof(left));
            }

            var parameter = Expression.Parameter(typeof(t), typeof(t).ToString());
            var _property = Expression.Property(parameter, left);
            var _lower = Expression.Constant(lower);
            var _upper = Expression.Constant(upper);

            switch (type)
            {
                case type.Equals:
                    var _expression = Expression.Equal(_property, _lower);
                    return Expression.Lambda<Func<t, bool>>(_expression, parameter);
                case type.GreaterThan:
                    var _greaterThanExpression = Expression.GreaterThan(_property, _lower);
                    return Expression.Lambda<Func<t, bool>>(_greaterThanExpression, parameter);
                case type.LessThan:
                    var _lessThanExpression = Expression.LessThan(_property, _lower);
                    return Expression.Lambda<Func<t, bool>>(_lessThanExpression, parameter);
                case type.Between:
                    if (upper <= lower)
                    {
                        throw new ArgumentOutOfRangeException($"{nameof(upper)} is too small.");
                    }
                    var _lowerExpression = Expression.GreaterThanOrEqual(_property, _lower);
                    var _upperExpression = Expression.LessThanOrEqual(_property, _upper);
                    var _betweenExpression = Expression.AndAlso(_lowerExpression, _upperExpression);
                    return Expression.Lambda<Func<t, bool>>(_betweenExpression, parameter);
                default:
                    return null;
            }
        } // End BuildFromInt.
        public enum type
        {
            StartsWith,
            EndsWith,
            Contains,
            Between,
            Equals,
            LessThan,
            GreaterThan,
        }
        

    }
}

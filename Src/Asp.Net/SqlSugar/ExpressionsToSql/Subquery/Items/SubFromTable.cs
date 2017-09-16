﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SqlSugar
{
    public class SubFromTable : ISubOperation
    {
        public string Name
        {
            get
            {
                return "Subqueryable";
            }
        }

        public Expression Expression
        {
            get; set;
        }

        public int Sort
        {
            get
            {
                return 300;
            }
        }
        public string GetValue(ExpressionContext context, Expression expression)
        {
            var exp = expression as MethodCallExpression;
            var resType = exp.Method.ReturnType;
            var name = resType.GetGenericArguments().First().Name;
            return "FROM "+context.GetTranslationTableName(name, true);
        }
    }
}
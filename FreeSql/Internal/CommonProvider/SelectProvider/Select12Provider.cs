﻿using FreeSql.Internal.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FreeSql.Internal.CommonProvider
{

    public abstract class Select12Provider<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : Select0Provider<ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, T1>, ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class
            where T7 : class
            where T8 : class
            where T9 : class
            where T10 : class
            where T11 : class
            where T12 : class
    {

        public Select12Provider(IFreeSql orm, CommonUtils commonUtils, CommonExpression commonExpression, object dywhere) : base(orm, commonUtils, commonExpression, dywhere)
        {
            if (_orm.CodeFirst.IsAutoSyncStructure) _orm.CodeFirst.SyncStructure(typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12));
            _tables.Add(new SelectTableInfo { Table = _commonUtils.GetTableByEntity(typeof(T2)), Alias = $"SP10b", On = null, Type = SelectTableInfoType.From });
            _tables.Add(new SelectTableInfo { Table = _commonUtils.GetTableByEntity(typeof(T3)), Alias = $"SP10c", On = null, Type = SelectTableInfoType.From });
            _tables.Add(new SelectTableInfo { Table = _commonUtils.GetTableByEntity(typeof(T4)), Alias = $"SP10d", On = null, Type = SelectTableInfoType.From });
            _tables.Add(new SelectTableInfo { Table = _commonUtils.GetTableByEntity(typeof(T5)), Alias = $"SP10e", On = null, Type = SelectTableInfoType.From });
            _tables.Add(new SelectTableInfo { Table = _commonUtils.GetTableByEntity(typeof(T6)), Alias = $"SP10f", On = null, Type = SelectTableInfoType.From });
            _tables.Add(new SelectTableInfo { Table = _commonUtils.GetTableByEntity(typeof(T7)), Alias = $"SP10g", On = null, Type = SelectTableInfoType.From });
            _tables.Add(new SelectTableInfo { Table = _commonUtils.GetTableByEntity(typeof(T8)), Alias = $"SP10h", On = null, Type = SelectTableInfoType.From });
            _tables.Add(new SelectTableInfo { Table = _commonUtils.GetTableByEntity(typeof(T9)), Alias = $"SP10i", On = null, Type = SelectTableInfoType.From });
            _tables.Add(new SelectTableInfo { Table = _commonUtils.GetTableByEntity(typeof(T10)), Alias = $"SP10j", On = null, Type = SelectTableInfoType.From });
            _tables.Add(new SelectTableInfo { Table = _commonUtils.GetTableByEntity(typeof(T11)), Alias = $"SP10k", On = null, Type = SelectTableInfoType.From });
            _tables.Add(new SelectTableInfo { Table = _commonUtils.GetTableByEntity(typeof(T12)), Alias = $"SP10l", On = null, Type = SelectTableInfoType.From });
        }

        ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.WithSql(string sqlT1, string sqlT2, string sqlT3, string sqlT4, string sqlT5, string sqlT6, string sqlT7, string sqlT8, string sqlT9, string sqlT10, string sqlT11, string sqlT12, object parms)
        {
            this.AsTable((type, old) =>
            {
                if (type == _tables[0].Table?.Type) return $"( {sqlT1} )";
                if (type == _tables[1].Table?.Type) return $"( {sqlT2} )";
                if (type == _tables[2].Table?.Type) return $"( {sqlT3} )";
                if (type == _tables[3].Table?.Type) return $"( {sqlT4} )";
                if (type == _tables[4].Table?.Type) return $"( {sqlT5} )";
                if (type == _tables[5].Table?.Type) return $"( {sqlT6} )";
                if (type == _tables[6].Table?.Type) return $"( {sqlT7} )";
                if (type == _tables[7].Table?.Type) return $"( {sqlT8} )";
                if (type == _tables[8].Table?.Type) return $"( {sqlT9} )";
                if (type == _tables[9].Table?.Type) return $"( {sqlT10} )";
                if (type == _tables[10].Table?.Type) return $"( {sqlT11} )";
                if (type == _tables[11].Table?.Type) return $"( {sqlT12} )";
                return old;
            });
            if (parms != null) _params.AddRange(_commonUtils.GetDbParamtersByObject($"{sqlT1};\r\n{sqlT2};\r\n{sqlT3};\r\n{sqlT4};\r\n{sqlT5};\r\n{sqlT6};\r\n{sqlT7};\r\n{sqlT8};\r\n{sqlT9};\r\n{sqlT10};\r\n{sqlT11};\r\n{sqlT12}", parms));
            return this;
        }

        double ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Avg<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TMember>> column)
        {
            if (column == null) return 0;
            for (var a = 0; a < column.Parameters.Count; a++) _tables[a].Parameter = column.Parameters[a];
            return this.InternalAvg(column?.Body);
        }

        ISelectGrouping<TKey, NativeTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.GroupBy<TKey>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TKey>> exp)
        {
            if (exp == null) return this.InternalGroupBy<TKey, NativeTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>(exp?.Body);
            for (var a = 0; a < exp.Parameters.Count; a++) _tables[a].Parameter = exp.Parameters[a];
            return this.InternalGroupBy<TKey, NativeTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>(exp?.Body);
        }

        TMember ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Max<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TMember>> column)
        {
            if (column == null) return default(TMember);
            for (var a = 0; a < column.Parameters.Count; a++) _tables[a].Parameter = column.Parameters[a];
            return this.InternalMax<TMember>(column?.Body);
        }

        TMember ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Min<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TMember>> column)
        {
            if (column == null) return default(TMember);
            for (var a = 0; a < column.Parameters.Count; a++) _tables[a].Parameter = column.Parameters[a];
            return this.InternalMin<TMember>(column?.Body);
        }

        ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.OrderBy<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TMember>> column)
        {
            if (column == null) this.InternalOrderBy(column?.Body);
            for (var a = 0; a < column.Parameters.Count; a++) _tables[a].Parameter = column.Parameters[a];
            return this.InternalOrderBy(column?.Body);
        }

        ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.OrderByDescending<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TMember>> column)
        {
            if (column == null) this.InternalOrderBy(column?.Body);
            for (var a = 0; a < column.Parameters.Count; a++) _tables[a].Parameter = column.Parameters[a];
            return this.InternalOrderByDescending(column?.Body);
        }

        ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.OrderByIf<TMember>(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TMember>> column, bool descending)
        {
            if (condition == false || column == null) this.InternalOrderBy(column?.Body);
            for (var a = 0; a < column.Parameters.Count; a++) _tables[a].Parameter = column.Parameters[a];
            return descending ? this.InternalOrderByDescending(column?.Body) : this.InternalOrderBy(column?.Body);
        }

        decimal ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Sum<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TMember>> column)
        {
            if (column == null) this.InternalOrderBy(column?.Body);
            for (var a = 0; a < column.Parameters.Count; a++) _tables[a].Parameter = column.Parameters[a];
            return this.InternalSum(column?.Body);
        }

        TReturn ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.ToAggregate<TReturn>(Expression<Func<ISelectGroupingAggregate<T1>, ISelectGroupingAggregate<T2>, ISelectGroupingAggregate<T3>, ISelectGroupingAggregate<T4>, ISelectGroupingAggregate<T5>, ISelectGroupingAggregate<T6>, ISelectGroupingAggregate<T7>, ISelectGroupingAggregate<T8>, ISelectGroupingAggregate<T9>, ISelectGroupingAggregate<T10>, ISelectGroupingAggregate<T11>, ISelectGroupingAggregate<T12>, TReturn>> select)
        {
            if (select == null) return default(TReturn);
            for (var a = 0; a < select.Parameters.Count; a++) _tables[a].Parameter = select.Parameters[a];
            return this.InternalToAggregate<TReturn>(select?.Body);
        }
        ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Aggregate<TReturn>(Expression<Func<ISelectGroupingAggregate<T1>, ISelectGroupingAggregate<T2>, ISelectGroupingAggregate<T3>, ISelectGroupingAggregate<T4>, ISelectGroupingAggregate<T5>, ISelectGroupingAggregate<T6>, ISelectGroupingAggregate<T7>, ISelectGroupingAggregate<T8>, ISelectGroupingAggregate<T9>, ISelectGroupingAggregate<T10>, ISelectGroupingAggregate<T11>, ISelectGroupingAggregate<T12>, TReturn>> select, out TReturn result)
        {
            result = (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>).ToAggregate(select);
            return this;
        }

        List<TReturn> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.ToList<TReturn>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn>> select)
        {
            if (select == null) return this.InternalToList<TReturn>(select?.Body);
            for (var a = 0; a < select.Parameters.Count; a++) _tables[a].Parameter = select.Parameters[a];
            return this.InternalToList<TReturn>(select?.Body);
        }
        List<TDto> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.ToList<TDto>() => (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>).ToList(GetToListDtoSelector<TDto>());
        Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TDto>> GetToListDtoSelector<TDto>()
        {
            return Expression.Lambda<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TDto>>(
                typeof(TDto).InternalNewExpression(),
                _tables[0].Parameter ?? Expression.Parameter(typeof(T1), "a"),
                Expression.Parameter(typeof(T2), "b"),
                Expression.Parameter(typeof(T3), "c"),
                Expression.Parameter(typeof(T4), "d"),
                Expression.Parameter(typeof(T5), "e"),
                Expression.Parameter(typeof(T6), "f"),
                Expression.Parameter(typeof(T7), "g"),
                Expression.Parameter(typeof(T8), "h"),
                Expression.Parameter(typeof(T9), "i"),
                Expression.Parameter(typeof(T10), "j"),
                Expression.Parameter(typeof(T11), "k"),
                Expression.Parameter(typeof(T12), "l"));
        }
        public void ToChunk<TReturn>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn>> select, int size, Action<FetchCallbackArgs<List<TReturn>>> done)
        {
            if (select == null || done == null) return;
            for (var a = 0; a < select.Parameters.Count; a++) _tables[a].Parameter = select.Parameters[a];
            this.InternalToChunk<TReturn>(select.Body, size, done);
        }

        DataTable ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.ToDataTable<TReturn>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn>> select)
        {
            if (select == null) return this.InternalToDataTable(select?.Body);
            for (var a = 0; a < select.Parameters.Count; a++) _tables[a].Parameter = select.Parameters[a];
            return this.InternalToDataTable(select?.Body);
        }

        string ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.ToSql<TReturn>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn>> select, FieldAliasOptions fieldAlias)
        {
            if (select == null) return this.InternalToSql<TReturn>(select?.Body, fieldAlias);
            for (var a = 0; a < select.Parameters.Count; a++) _tables[a].Parameter = select.Parameters[a];
            return this.InternalToSql<TReturn>(select?.Body, fieldAlias);
        }

        ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.LeftJoin(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool>> exp)
        {
            if (exp == null) return this.InternalJoin(exp?.Body, SelectTableInfoType.LeftJoin);
            for (var a = 0; a < exp.Parameters.Count; a++) _tables[a].Parameter = exp.Parameters[a];
            return this.InternalJoin(exp?.Body, SelectTableInfoType.LeftJoin);
        }

        ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.InnerJoin(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool>> exp)
        {
            if (exp == null) return this.InternalJoin(exp?.Body, SelectTableInfoType.LeftJoin);
            for (var a = 0; a < exp.Parameters.Count; a++) _tables[a].Parameter = exp.Parameters[a];
            return this.InternalJoin(exp?.Body, SelectTableInfoType.InnerJoin);
        }

        ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.RightJoin(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool>> exp)
        {
            if (exp == null) return this.InternalJoin(exp?.Body, SelectTableInfoType.LeftJoin);
            for (var a = 0; a < exp.Parameters.Count; a++) _tables[a].Parameter = exp.Parameters[a];
            return this.InternalJoin(exp?.Body, SelectTableInfoType.RightJoin);
        }

        ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Where(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool>> exp)
        {
            if (exp == null) return this.Where(null);
            for (var a = 0; a < exp.Parameters.Count; a++) _tables[a].Parameter = exp.Parameters[a];
            return this.Where(_commonExpression.ExpressionWhereLambda(_tables, exp?.Body, null, _whereCascadeExpression, _params));
        }

        ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.WhereIf(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool>> exp)
        {
            if (condition == false || exp == null) return this.Where(null);
            for (var a = 0; a < exp.Parameters.Count; a++) _tables[a].Parameter = exp.Parameters[a];
            return condition ? this.Where(_commonExpression.ExpressionWhereLambda(_tables, exp?.Body, null, _whereCascadeExpression, _params)) : this;
        }

        bool ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Any(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool>> exp)
        {
            if (exp == null) return this.Any();
            for (var a = 0; a < exp.Parameters.Count; a++) _tables[a].Parameter = exp.Parameters[a];
            var oldwhere = _where.ToString();
            var ret = this.Where(_commonExpression.ExpressionWhereLambda(_tables, exp?.Body, null, _whereCascadeExpression, _params)).Any();
            _where.Clear().Append(oldwhere);
            return ret;
        }

        TReturn ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.ToOne<TReturn>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn>> select) => (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>).Limit(1).ToList(select).FirstOrDefault();
        TReturn ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.First<TReturn>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn>> select) => (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>).Limit(1).ToList(select).FirstOrDefault();
        TDto ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.First<TDto>() => (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>).Limit(1).ToList<TDto>().FirstOrDefault();

#if net40
#else
        Task<double> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AvgAsync<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TMember>> column)
        {
            if (column == null) return Task.FromResult(default(double));
            for (var a = 0; a < column.Parameters.Count; a++) _tables[a].Parameter = column.Parameters[a];
            return this.InternalAvgAsync(column?.Body);
        }

        Task<TMember> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.MaxAsync<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TMember>> column)
        {
            if (column == null) return Task.FromResult(default(TMember));
            for (var a = 0; a < column.Parameters.Count; a++) _tables[a].Parameter = column.Parameters[a];
            return this.InternalMaxAsync<TMember>(column?.Body);
        }

        Task<TMember> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.MinAsync<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TMember>> column)
        {
            if (column == null) return Task.FromResult(default(TMember));
            for (var a = 0; a < column.Parameters.Count; a++) _tables[a].Parameter = column.Parameters[a];
            return this.InternalMinAsync<TMember>(column?.Body);
        }

        Task<decimal> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.SumAsync<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TMember>> column)
        {
            if (column == null) this.InternalOrderBy(column?.Body);
            for (var a = 0; a < column.Parameters.Count; a++) _tables[a].Parameter = column.Parameters[a];
            return this.InternalSumAsync(column?.Body);
        }

        Task<TReturn> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.ToAggregateAsync<TReturn>(Expression<Func<ISelectGroupingAggregate<T1>, ISelectGroupingAggregate<T2>, ISelectGroupingAggregate<T3>, ISelectGroupingAggregate<T4>, ISelectGroupingAggregate<T5>, ISelectGroupingAggregate<T6>, ISelectGroupingAggregate<T7>, ISelectGroupingAggregate<T8>, ISelectGroupingAggregate<T9>, ISelectGroupingAggregate<T10>, ISelectGroupingAggregate<T11>, ISelectGroupingAggregate<T12>, TReturn>> select)
        {
            if (select == null) return Task.FromResult(default(TReturn));
            for (var a = 0; a < select.Parameters.Count; a++) _tables[a].Parameter = select.Parameters[a];
            return this.InternalToAggregateAsync<TReturn>(select?.Body);
        }

        Task<List<TReturn>> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.ToListAsync<TReturn>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn>> select)
        {
            if (select == null) return this.InternalToListAsync<TReturn>(select?.Body);
            for (var a = 0; a < select.Parameters.Count; a++) _tables[a].Parameter = select.Parameters[a];
            return this.InternalToListAsync<TReturn>(select?.Body);
        }
        Task<List<TDto>> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.ToListAsync<TDto>() => (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>).ToListAsync(GetToListDtoSelector<TDto>());

        Task<DataTable> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.ToDataTableAsync<TReturn>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn>> select)
        {
            if (select == null) return this.InternalToDataTableAsync(select?.Body);
            for (var a = 0; a < select.Parameters.Count; a++) _tables[a].Parameter = select.Parameters[a];
            return this.InternalToDataTableAsync(select?.Body);
        }

        async Task<bool> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.AnyAsync(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool>> exp)
        {
            if (exp == null) return await this.AnyAsync();
            for (var a = 0; a < exp.Parameters.Count; a++) _tables[a].Parameter = exp.Parameters[a];
            var oldwhere = _where.ToString();
            var ret = await this.Where(_commonExpression.ExpressionWhereLambda(_tables, exp?.Body, null, _whereCascadeExpression, _params)).AnyAsync();
            _where.Clear().Append(oldwhere);
            return ret;
        }

        async Task<TReturn> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.ToOneAsync<TReturn>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn>> select) => (await (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>).Limit(1).ToListAsync(select)).FirstOrDefault();
        async Task<TReturn> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.FirstAsync<TReturn>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TReturn>> select) => (await (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>).Limit(1).ToListAsync(select)).FirstOrDefault();
        async Task<TDto> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.FirstAsync<TDto>() => (await (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>).Limit(1).ToListAsync<TDto>()).FirstOrDefault();

#endif
    }
}
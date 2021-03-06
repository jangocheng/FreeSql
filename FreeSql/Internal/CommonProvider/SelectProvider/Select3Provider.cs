﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FreeSql.Internal.CommonProvider {

	abstract class Select3Provider<T1, T2, T3> : Select0Provider<ISelect<T1, T2, T3>, T1>, ISelect<T1, T2, T3>
			where T1 : class
			where T2 : class
			where T3 : class {

		public Select3Provider(IFreeSql orm, CommonUtils commonUtils, CommonExpression commonExpression, object dywhere) : base(orm, commonUtils, commonExpression, dywhere) {
			if (_orm.CodeFirst.IsAutoSyncStructure) _orm.CodeFirst.SyncStructure(typeof(T2), typeof(T3));
		}

		TMember ISelect<T1, T2, T3>.Avg<TMember>(Expression<Func<T1, T2, T3, TMember>> column) => this.InternalAvg<TMember>(column?.Body);

		Task<TMember> ISelect<T1, T2, T3>.AvgAsync<TMember>(Expression<Func<T1, T2, T3, TMember>> column) => this.InternalAvgAsync<TMember>(column?.Body);

		ISelectGrouping<TKey> ISelect<T1, T2, T3>.GroupBy<TKey>(Expression<Func<T1, T2, T3, TKey>> exp) => this.InternalGroupBy<TKey>(exp?.Body);

		TMember ISelect<T1, T2, T3>.Max<TMember>(Expression<Func<T1, T2, T3, TMember>> column) => this.InternalMax<TMember>(column?.Body);

		Task<TMember> ISelect<T1, T2, T3>.MaxAsync<TMember>(Expression<Func<T1, T2, T3, TMember>> column) => this.InternalMaxAsync<TMember>(column?.Body);

		TMember ISelect<T1, T2, T3>.Min<TMember>(Expression<Func<T1, T2, T3, TMember>> column) => this.InternalMin<TMember>(column?.Body);

		Task<TMember> ISelect<T1, T2, T3>.MinAsync<TMember>(Expression<Func<T1, T2, T3, TMember>> column) => this.InternalMinAsync<TMember>(column?.Body);

		ISelect<T1, T2, T3> ISelect<T1, T2, T3>.OrderBy<TMember>(Expression<Func<T1, T2, T3, TMember>> column) => this.InternalOrderBy(column?.Body);

		ISelect<T1, T2, T3> ISelect<T1, T2, T3>.OrderByDescending<TMember>(Expression<Func<T1, T2, T3, TMember>> column) => this.InternalOrderByDescending(column?.Body);

		TMember ISelect<T1, T2, T3>.Sum<TMember>(Expression<Func<T1, T2, T3, TMember>> column) => this.InternalSum<TMember>(column?.Body);

		Task<TMember> ISelect<T1, T2, T3>.SumAsync<TMember>(Expression<Func<T1, T2, T3, TMember>> column) => this.InternalSumAsync<TMember>(column?.Body);

		TReturn ISelect<T1, T2, T3>.ToAggregate<TReturn>(Expression<Func<ISelectGroupingAggregate<T1>, ISelectGroupingAggregate<T2>, ISelectGroupingAggregate<T3>, TReturn>> select) => this.InternalToAggregate<TReturn>(select?.Body);

		Task<TReturn> ISelect<T1, T2, T3>.ToAggregateAsync<TReturn>(Expression<Func<ISelectGroupingAggregate<T1>, ISelectGroupingAggregate<T2>, ISelectGroupingAggregate<T3>, TReturn>> select) => this.InternalToAggregateAsync<TReturn>(select?.Body);

		List<TReturn> ISelect<T1, T2, T3>.ToList<TReturn>(Expression<Func<T1, T2, T3, TReturn>> select) => this.InternalToList<TReturn>(select?.Body);

		Task<List<TReturn>> ISelect<T1, T2, T3>.ToListAsync<TReturn>(Expression<Func<T1, T2, T3, TReturn>> select) => this.InternalToListAsync<TReturn>(select?.Body);

		DataTable ISelect<T1, T2, T3>.ToDataTable<TReturn>(Expression<Func<T1, T2, T3, TReturn>> select) => this.InternalToDataTable(select?.Body);

		Task<DataTable> ISelect<T1, T2, T3>.ToDataTableAsync<TReturn>(Expression<Func<T1, T2, T3, TReturn>> select) => this.InternalToDataTableAsync(select?.Body);

		string ISelect<T1, T2, T3>.ToSql<TReturn>(Expression<Func<T1, T2, T3, TReturn>> select) => this.InternalToSql<TReturn>(select?.Body);

		ISelect<T1, T2, T3> ISelect<T1, T2, T3>.Where(Expression<Func<T1, T2, T3, bool>> exp) => this.Where(_commonExpression.ExpressionWhereLambda(_tables, exp?.Body, null));

		ISelect<T1, T2, T3> ISelect<T1, T2, T3>.WhereIf(bool condition, Expression<Func<T1, T2, T3, bool>> exp) => condition ? this.Where(_commonExpression.ExpressionWhereLambda(_tables, exp?.Body, null)) : this;

		bool ISelect<T1, T2, T3>.Any(Expression<Func<T1, T2, T3, bool>> exp) => this.Where(_commonExpression.ExpressionWhereLambda(_tables, exp?.Body, null)).Any();

		Task<bool> ISelect<T1, T2, T3>.AnyAsync(Expression<Func<T1, T2, T3, bool>> exp) => this.Where(_commonExpression.ExpressionWhereLambda(_tables, exp?.Body, null)).AnyAsync();
	}
}
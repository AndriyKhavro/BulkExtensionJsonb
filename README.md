### Getting started

1. Run postgres

```
docker run --name some-postgres -e POSTGRES_PASSWORD=somepassword -d -p 5432:5432 postgres
```

2. Update database

```
dotnet ef database update
```

3. Run the project
```
dotnet run
```


This code leads to KeyNotFoundException
```
Unhandled exception. System.Collections.Generic.KeyNotFoundException: The given key 'Reviews' was not present in the dictionary.
   at System.Collections.Generic.Dictionary`2.get_Item(TKey key)
   at EFCore.BulkExtensions.SqlAdapters.PostgreSql.PostgreSqlAdapter.InsertAsync[T](DbContext context, IEnumerable`1 entities, TableInfo tableInfo, Action`1 progress, Boolean isAsync, CancellationToken cancellationToken)
   at EFCore.BulkExtensions.SqlAdapters.PostgreSql.PostgreSqlAdapter.InsertAsync[T](DbContext context, IEnumerable`1 entities, TableInfo tableInfo, Action`1 progress, Boolean isAsync, CancellationToken cancellationToken)
   at EFCore.BulkExtensions.SqlAdapters.PostgreSql.PostgreSqlAdapter.InsertAsync[T](DbContext context, Type type, IEnumerable`1 entities, TableInfo tableInfo, Action`1 progress, CancellationToken cancellationToken)
   at EFCore.BulkExtensions.SqlAdapters.PostgreSql.PostgreSqlAdapter.MergeAsync[T](DbContext context, Type type, IEnumerable`1 entities, TableInfo tableInfo, OperationType operationType, Action`1 progress, Boolean isAsync, CancellationToken cancellationToken)
   at EFCore.BulkExtensions.SqlAdapters.PostgreSql.PostgreSqlAdapter.MergeAsync[T](DbContext context, Type type, IEnumerable`1 entities, TableInfo tableInfo, OperationType operationType, Action`1 progress, Boolean isAsync, CancellationToken cancellationToken)
   at EFCore.BulkExtensions.SqlAdapters.PostgreSql.PostgreSqlAdapter.MergeAsync[T](DbContext context, Type type, IEnumerable`1 entities, TableInfo tableInfo, OperationType operationType, Action`1 progress, CancellationToken cancellationToken)
   at EFCore.BulkExtensions.SqlBulkOperation.MergeAsync[T](DbContext context, Type type, IEnumerable`1 entities, TableInfo tableInfo, OperationType operationType, Action`1 progress, CancellationToken cancellationToken)
   at EFCore.BulkExtensions.DbContextBulkTransaction.ExecuteAsync[T](DbContext context, Type type, IEnumerable`1 entities, OperationType operationType, BulkConfig bulkConfig, Action`1 progress, CancellationToken cancellationToken)
   at Program.<Main>$(String[] args) in C:\code\BulkExtensionJsonb\Program.cs:line 14
   at Program.<Main>(String[] args)
```
using System;
using ToDoApp.Models;
using SQLite;

namespace ToDoApp.Data;

public class Database
{
private readonly SQLiteAsyncConnection _connection;
public Database()
{
var dataDir = FileSystem.AppDataDirectory;
var databasePath = Path.Combine(dataDir, "ToDoApp.db");
string _dbEncryptionKey = SecureStorage.GetAsync("dbKey").Result;

if (string.IsNullOrEmpty(_dbEncryptionKey))
{
    Guid g = new Guid();
    _dbEncryptionKey = g.ToString();
    SecureStorage.SetAsync("dbKey", _dbEncryptionKey);
}

var dbOptions = new SQLiteConnectionString(databasePath, true, key: _dbEncryptionKey);
_connection = new SQLiteAsyncConnection(dbOptions);
_ = Initialise();
}

private async Task Initialise()
{
    await _connection.CreateTableAsync<TodoItem>();
}

public async Task<List<TodoItem>> GetTodos()
{
    return await _connection.Table<TodoItem>().ToListAsync();
}

public async Task<TodoItem> GetTodo(int id)
{
    var query = _connection.Table<TodoItem>().Where(t => t.Id == id); 
    return await query.FirstOrDefaultAsync();
}

public async Task<int> AddTodo(TodoItem item)
{
    return await _connection.InsertAsync(item);
}

public async Task<int> DeleteTodo(TodoItem item)
{
    return await _connection.DeleteAsync(item);
}

public async Task<int> UpdateTodo(TodoItem item)
{
    return await _connection.UpdateAsync(item);

}
}


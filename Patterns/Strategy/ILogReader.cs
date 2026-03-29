/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 марта 2026 11:13:14
 * Version: 1.0.224
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}

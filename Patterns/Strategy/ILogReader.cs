/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 октября 2026 10:55:52
 * Version: 1.0.413
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}

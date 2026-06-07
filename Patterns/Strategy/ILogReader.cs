/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 июня 2026 18:20:54
 * Version: 1.0.296
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}

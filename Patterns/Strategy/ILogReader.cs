/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 октября 2025 10:14:54
 * Version: 1.0.58
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}

/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 октября 2025 13:18:12
 * Version: 1.0.61
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}

/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 октября 2025 06:57:33
 * Version: 1.0.53
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}

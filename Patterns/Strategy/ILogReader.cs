/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 октября 2025 06:51:58
 * Version: 1.0.75
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}

/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 октября 2025 06:51:52
 * Version: 1.0.73
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}

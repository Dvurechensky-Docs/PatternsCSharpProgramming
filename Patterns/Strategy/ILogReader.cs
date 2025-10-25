/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 октября 2025 06:51:55
 * Version: 1.0.69
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}

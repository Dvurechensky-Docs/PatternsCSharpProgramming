/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 октября 2025 06:51:59
 * Version: 1.0.54
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}

/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 августа 2025 06:57:08
 * Version: 1.0.10
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}

# DellPowerEdgeFansTuner
A tool for tuning Dell PowerEdge server fan speed by sending control instructions with ipmitool over LAN. With GUI built with C# WinForm.

# 戴尔服务器风扇转速控制工具
工作原理：借助 ipmitool for windows 命令行工具对风扇转速进行调整。
ipmitool 通过戴尔服务器的 IPMI 功能进行控制，因此要求服务器首先开启 IPMI over LAN 功能。
操作方法参考文章 https://zhuanlan.zhihu.com/p/157796567 

# Latest Release Download Link (最新版下载地址)
## V1.0.2 (添加独立风扇控制 @zzccchen)
https://github.com/zzccchen/dell_fans_controller/releases/download/v1.0.2/Dell_EMC_Fans_Controller_1.0.2.zip
## V1.0.1 (@jiafeng5513)
https://github.com/jiafeng5513/dell_fans_controller/releases/download/V1.0.1/Dell_EMC_Fans_Controller_1.0.1.zip
## V1.0.0 (@cw1997)
https://github.com/cw1997/dell_fans_controller/releases/download/v1.0.0/dell_fans_controller_v1.0.0.zip

### Build
1. Visual Studio 2022.<br>
2. Windows 11.<br>
3. .Net Framework.<br>

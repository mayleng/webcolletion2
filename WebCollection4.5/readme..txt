1.该网站通过 新建--》项目来创建  后期测试尽量以该种方式创建网站

2.关于MongoDB数据库采用 MongoDB.Driver 2.2
  目前Agent暂不支持（3.3版本agent已经支持）。


3.若想使用Access数据库需要安装Access Database Engine。
  
 数据库文件放在App_Data目录下 users.accdb

数据库驱动引擎文件在文件夹“Access数据库引擎文件”中。
如果不测试Access系统不需要安装。

对于x64系统，需要给网站设置启用32位程序
选择 该应用程序的 应用程序池 ------>选择高级设置 --------->启用32位应用程序 ------->true  
（另外由于64位操作系统不支持Microsoft OLE DB Provider for Jet驱动程序或者其他的一些驱动程序 如 pdfview时，
  也不支持更早的Microsoft Access Driver (*.mdb)方式连接。
 所以用于 Access 和 Excel 数据库的 Microsoft OLE DB Provider for Jet 在 64 位版本中不可用。
 ）

4.vs编译程序时可以选择x86 或者x64，默认是anyCPU
  当选择默认时，程序根据系统的位数自动适配为多少位的程序。

对于X86的程序，IIS的程序池必须开启32位应用程序池。

5./WebCollection4.5\WebCollection\bin\Release\PublishOutput
  该目录下的代码为发布后程序。D:\May\webapi\netframework\WebCollection4.5\WebCollection\bin\Release\PublishOutput
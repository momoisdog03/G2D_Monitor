# 鹅鸭杀辅助工具
仅供学习交流，不对使用产生的后果负责

仅支持64位游戏进程，因为注入的汇编代码只写了64位的，懒得再写32位，毕竟2023年了...

本项目代码不对游戏数值进行修改，如需修改要同时修改隐藏的加密数值，游戏的反作弊模块原理请查看：https://codestage.net/uas/actk

# Features
使用il2cpp函数读取地址，游戏版本更新也基本无需更新代码

游戏多开，使用方法请查看下面图片，原理就是把Mutex的句柄Kill掉，进游戏要用不同账号，不然没法进同一个房间

统计玩家信息(是否隐身、变形、被鹈鹕吃等等) 以及游戏信息（当前地图、房间号、当前游戏进程等）

当前死亡数、玩家位置的地图标记，标点分为普通(白色)、嫌疑人(粉色，进雾/开刀)、鸭子（暗红，隐身/变形），颜色和字体可自行设置

# Comming Features
添加每轮游戏回放功能，方便看清楚哪个老六混刀

<img src="https://user-images.githubusercontent.com/26305635/217161208-dbd99b39-a21f-443b-a77a-c40fc587efa1.png" alt="drawing" width="600"/>
<img src="https://user-images.githubusercontent.com/26305635/217161217-f74d9be9-b562-4814-9b9d-f8fa02b70b32.png" alt="drawing" width="600"/>
# 플레이어 대 몹

## 게임방법

-스킬 7개 중 하나를 선택하고, 몬스터와 플레이어는 서로 공격을 받거나 공격을 피할 수 있다.

-또는 먼저 도망치거나 다시 싸울 수도 있다. 몬스터를 쓰러트려야만 승리할 수 있다. 

### 사용한 스크립트

Thread Sleep, Clear
![image](https://user-images.githubusercontent.com/123847770/222946519-997c614e-00ae-498f-acf1-44db3da09763.png)


장면마다 바뀌기 위해 사용하였다. 플레이어가 먼저 몬스터를 공격하고 그 다음 결과가 나온다. 결과는 공격을 회피하거나 공격에 성공하는 두 결과가 랜덤으로 나온다.

Random
![image](https://user-images.githubusercontent.com/123847770/222946414-9bb7631b-b713-4151-8800-3e2491cde516.png)

공격에 성공하거나 실패를 랜덤으로 설정하기 위해 사용하였다. 공격 성공은 ReduceHp(); 공격 실패는 Avoid();로 if문과 else문으로 나뉘었다.

string
![image](https://user-images.githubusercontent.com/123847770/222946486-1dbb7384-8790-4188-9b76-ab007f2f0cb2.png)


string으로 스킬들을 선택하는 화면을 만들었다. 스킬을 선택하면 그대로 다음으로 넘어가 공격 성공/실패가 나온다.

interface
![image](https://user-images.githubusercontent.com/123847770/222946695-5a936e94-f0c4-48fd-94b1-d3429740b56e.png)


몬스터에 인터페이스를 만들어 Attack, Take Damage, Avoid, ReduceHp등을 만들었고, 플레이어 또한 마찬가지다.


게임 영상
https://user-images.githubusercontent.com/123847770/222947946-f351d006-c146-4a7c-85f1-db21d45e3995.mp4



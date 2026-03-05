# 1주차과제: 나만의디지털명함제작기-이름: 강민규(20040622)-
핵심기능: 배경색랜덤변경, 깃허브연결, 사진변경
## 실행화면(여기에실행중인스크린샷이나GIF를마우스로끌어다넣으세요!)
<img width="634" height="381" alt="image" src="https://github.com/user-attachments/assets/885e453c-0367-4621-af79-4e0ff04c84d6" />

## 구현시어려웠던점-, 깃허브 연결 버튼
예전 버전에선 UseShellExecute 버전이 ture였기에 ppt자료에 쓴 것처럼 구현이 가능했지만, 최신 버전은 false가 기본값으로 변경했기에
실행 파일로 인식하여 오류가 났었습니다. 이를 해결하기 위해 ProcessStartInfo 객체를 사용하여 설정을 명시하고, try, catch를 사용해 오류가 나도 실행이 되게끔
수정하였습니다

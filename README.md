# pp03_StudyBaekJoon
백준 알고리즘 공부하기

## 브론즈 4
### 01 백준 1264
- a, e, i, o, u를 찾아내기 성공
- 한줄 한줄 나눠서 찾아내기 실패

### 02 백준 2742
- textbox에 원하는 숫자 입력 시 richtextbox에 textbox숫자부터 1까지 -1로 출력하기

### 03 백준 2752
- 오름차순 정렬
- 랜덤으로 숫자 3개 나오고, 그 숫자가 오름차순으로 정렬되어 출력됨

### 04 백준 3046
- 숫자1, 평균값 입력받아 숫자2 값 알아내기
- 평균값 = (숫자 1 + 숫자 2) / 2
- 평균값 * 2 = 숫자 1 + 숫자 2
- 숫자 2 = 평균값 * 2 - 숫자 1
- 거꾸로 계산해서 올라감

### 05 백준 5532
- 방학일, 해야할 국어 페이지, 해야할 수학 페이지, 최대 가능한 국어 페이지, 최대 가능한 수학 페이지 입력받을 textbox
- 국어 페이지 % 최대 가능한 국어 페이지 (나머지)가 1이상일 경우 국어 페이지 / 최대 가능한 국어 페이지(몫) + 1
- 수학도 위와 같은 방법으로 계산
- 계산한 값 비교하여 더 큰 값을 최종 걸리는 시간으로 설정
- 방학일 - 최종걸리는 시간 => 결과값

### 06 백준 5543
- 상근버거, 중근버거, 하근버거, 콜라, 사이다 가격 입력할 textbox
- 버거, 음료로 배열만들기
- 이중 for문 활용하여 버거 + 음료 - 50값 비교 후 출력
- 처음 total 음료값을 0으로 설정하여 마지막 값이 출력됨 => 첫 total값을 버거1 + 음료1 - 50으로 설정해놓고 비교하여 최저값으로 출력되게 만듦

### 07 백준 5554
- 이동시간(초)을 계산하여 분,초로 변경하여 출력하기
- 이동시간 다 더해 분, 초 계산하여 출력

### 08 백준 5557
- 출근시간 퇴근시간 입력받아 근무시간 계산
- 입력받은 string을 int배열로 변경시키는 과정이 필요
- string getA = tbxA.Text;
  string[] A = getA.Split(' ');

  int[] timeA = A
      .Select(str => int.Parse(str))
      .ToArray();
- 시간, 분, 초를 뺀 뒤 출력하기

### 09 백준 5596
- 두 사람의 점수 4개를 순서대로 입력받아 4과목의 합계를 구하여 큰 합계 출력
- 5557과 같이 string 배열을 int 배열로 변경하여 합계 구함

### 10 백준 10039
- richtextbox를 이용하여 점수 5개 받아옴
- for문에 활용하기 위하여 richtextbox의 line수 찾음
  - richtextbox.Lines.Length
- for문에서 richtextbox.Lines[i]을 이용하여 해당 줄의 수를 알 수 있음
- 10039번에서 요구하는 조건 넣고 출력

### 11 백준 10101
- a = richtextbox의 줄수
- b, c, d = for문을 돌면서 richtextbox 각 줄의 값
- 조건식들을 넣어 출력

### 12 백준 10768
- a = richtextbox의 줄수
- month, date = richtextbox에서 받아온 월, 일
- 조건식들 넣어 출력


## 브론즈 3
### 01 백준 1267
- richtextbox.Lines[해당 줄수] -> 해당 줄 수의 입력값 받을 수 있음
- string 으로 받은 값이기 때문에 int로 바꿔야하고 int로 받은 수 비교해야함
- 조건1 (30초 미만 10원, 그 후로 30초당 10원씩 추가)
- 조건2 (60초 미만 15원, 그 후로 60초당 15원씩 추가)
- 처음에는 요금 변수를 0과 for문 밖에서 선언했었는데 그렇게 설정하니 리셋이 안되고 기본요금 설정이 안됨
- 요금 변수를 기본요금으로 설정하고 for문 안에서 선언하여 문제 해결
- sum변수를 추가하여 요금을 합쳐 최종 요금 확인할 수 있게 만들어 해결

### 02 백준 1284
- 아직 해결 못함
- 천의자리, 백의자리, 십의자리, 일의자리 숫자인 경우 공백 1추가하기 (O)
- 양쪽 끝 공백 1추가하기 (O)
- 해당 자리에서 숫자별로 공간 더해주기(X) -> 내일 마저 해결하기

## 2750 
#include<stdio.h>

int N;
int s[1000];

int main(){
    
    int tmp;
    
    scanf("%d", &N);
    for (int i = 0; i<N; i++)
        scanf("%d", $S[i]);
    
    for(int i = 0; i < (N-1); i++)
        for (int j = i+1; j < N; j++)
            if (S[j] < S[i]){
                tmp = S[i];
                S[i] = S[j];
                S[j] = tmp;
            }
    
    for (int i = 0; i<N; i++)
        printf("%d\n", S[i])
    
    return 0;
}

## 1920
#include<stdio.h>
#include<algorithm>
using namespace std;

int A[100001], N, M, B[10000];

int binarySearch (int a){
    int low = 1, high = N-1, mid;
    
    while (low <= high){
        mid = (low + high) / 2;
        if (a==A[mid]) return 1;
        else if(a < A[mid]) high = mid - 1;
        else low = mid + 1;
    }
    
    return 0;
}

int main(){

    scanf("%d", &N);
    
    for (int i = 0; i<N; i++)
        scanf("%d", &A[i]);
    
    sort(A, A+N);
        
    scanf("%d", &M);
    
    for(int i = 0; i<M; i++){
        scanf("%d", &B[i]);
    }
    
    for (int i = 0; i<M; i++){
        printf("%d\n", binarySearch(B[i]));
    }
    
    retrun 0;
}

위 코드들은 오류가 있음 => 수정해야할 필요가 있음

-- 재귀함수에 대해 공부함

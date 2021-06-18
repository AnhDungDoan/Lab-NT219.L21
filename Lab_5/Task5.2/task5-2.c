/* gcc -Wall task5-2.c -o task5 -lcrypto -lssl*/


#include <stdio.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "md5.h"
#include <openssl/md5.h>
#include <openssl/hmac.h>
#include <openssl/sha.h>
#include <openssl/evp.h>
#include <openssl/err.h>
unsigned char *SHA1(const unsigned char *d, unsigned long n,unsigned char *md);

int SHA1_Init(SHA_CTX *c);
int SHA1_Update(SHA_CTX *c, const void *data,unsigned long len);
int SHA1_Final(unsigned char *md, SHA_CTX *c);
const int size = 260 ;

void OutArray(int a[], int n)
{
    for(int i = 0;i < n; ++i)
    {
        printf("Phan tu different[%d] = %d\n", i, a[i]);
    }
}

int check(char *m1,char *m2)
{
    int i, index = 0 ;
    int different[size] ;
    for(i=0; m1[i]!='\0' || m2[i]!='\0'; i++)
    {
        if(m1[i] != m2[i]) 
        {
            different[index++] = i ;
        }
    }
    OutArray(different,index);
    return 0;

}   

int calculate_md5sum(char *filename)
{
  //open file for calculating md5sum
  FILE *file;
  file = fopen(filename, "rb");
  if (file==NULL)
  {
    perror("Error opening file");
    fflush(stdout);
    return 1;
  }

  int n;
  MD5_CTX c;
  char buf[512];
  ssize_t bytes;
  unsigned char out[MD5_DIGEST_LENGTH];

  MD5_Init(&c);
  do
  {
    bytes=fread(buf, 1, 512, file);
    MD5_Update(&c, buf, bytes);
  }while(bytes > 0);

  MD5_Final(out, &c);
  printf("%s = ", filename);
  for(n=0; n<MD5_DIGEST_LENGTH; n++)
          printf("%02x", out[n]);
  printf("\n");
  return 0;
}
int SHA1_file(char* filename)
{
    FILE *f;
    size_t len;
    unsigned char buffer[BUFSIZ];

    f = fopen(filename, "rb");
    if (!f)
    {
        fprintf(stderr, "couldn't open %s\n", filename);
        return 1;
    }
    // làm cho tất cả các thuật toán có sẵn cho các quy trình EVP * 
    OpenSSL_add_all_algorithms();
    // tải các chuỗi lỗi cho ERR_error_string 
    ERR_load_crypto_strings();

    EVP_MD_CTX hashctx;
    const EVP_MD *hashptr = EVP_get_digestbyname("SHA1");

    EVP_MD_CTX_init(&hashctx);
    EVP_DigestInit_ex(&hashctx, hashptr, NULL);

    do {
        len = fread(buffer, 1, BUFSIZ, f);
        EVP_DigestUpdate(&hashctx, buffer, len);
    } while (len == BUFSIZ);

    unsigned int outlen;
    EVP_DigestFinal_ex(&hashctx, buffer, &outlen);
    EVP_MD_CTX_cleanup(&hashctx);

    fclose(f);

    int i;
    printf("%s = ", filename);
    for (i = 0; i < outlen; ++i)
        printf("%02x", buffer[i]);
    printf("\n");
}

int main()
{
// Task1 -----------------------------------------
    char *message1= "d131dd02c5e6eec4693d9a0698aff95c2fcab58712467eab4004583eb8fb7f8955ad340609f4b30283e488832571415a085125e8f7cdc99fd91dbdf280373c5bd8823e3156348f5bae6dacd436c919c6dd53e2b487da03fd02396306d248cda0e99f33420f577ee8ce54b67080a80d1ec69821bcb6a8839396f9652b6ff72a70";
    char *message2= "d131dd02c5e6eec4693d9a0698aff95c2fcab50712467eab4004583eb8fb7f8955ad340609f4b30283e4888325f1415a085125e8f7cdc99fd91dbd7280373c5bd8823e3156348f5bae6dacd436c919c6dd53e23487da03fd02396306d248cda0e99f33420f577ee8ce54b67080280d1ec69821bcb6a8839396f965ab6ff72a70";
    int different[size]  ;
    printf("Message1 = %s\n",message1);
    printf("Message2 = %s\n",message2);
    check(message1,message2) ; 
    char *output1 = str2md5(message1, strlen(message1));
    char *output2 = str2md5(message2, strlen(message2));
    printf("Message1 = %s\n", output1);
    printf("Message2 = %s\n", output2);
    check(output1,output2);
    free(output1);
    free(output2);
// Task2------------------------------------------
    char *input = "hello" ; 
    calculate_md5sum(input);
    input = "erase" ; 
    calculate_md5sum(input);
// Task3 ------------------------------------------
    char *file = "shattered-1.pdf";
    SHA1_file(file);
    file = "shattered-2.pdf";
    SHA1_file(file);


    return 0;
}


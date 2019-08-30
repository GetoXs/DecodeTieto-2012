using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecodeTietoEI.Zad
{
    class Zad5
    {
        string A;
        string B;
        public int result=0;
        public void Run()
        {
            int res;
            Fill();
            string check;
            for (int len = 1; len < A.Length; len++)
            {
                for (int posA = 0; posA < A.Length - len; posA++)
                {
                    check = A.Substring(posA, len);
                    if (B.Contains(check))
                        result++;
                    //res = ContainsCount(ref B, ref check);
                    //result += res;
                }
                
            }
        }
        private int ContainsCount(ref string cmp, ref string value)
        {
            int res=0;
            for (int i = 0; i < cmp.Length; i++)
            {
                if (cmp.Substring(i).StartsWith(value))
                {
                    res++;
                    break;
                }
            }
            return res;
        }
        private void Fill()
        {
            A = "QnVpbGRpbmcgbGVhZGVycyBvZiB0aGUgZGlnaXRhbCB3b3JsZA0KV2l0aCBhYm91dCAxOCAwMDAgZXhwZXJ0cywgVGlldG8gaXMgdGhlIGxlYWRpbmcgSVQgc2VydmljZQ0KY29tcGFueSBpbiBOb3J0aGVybiBFdXJvcGUgcHJvdmlkaW5nIElUIGFuZCBwcm9kdWN0DQplbmdpbmVlcmluZyBzZXJ2aWNlcy4NCk91ciBzcGVjaWFsaXplZCBJVCBzb2x1dGlvbnMgYW5kIHNlcnZpY2VzIGNvbXBsZW1lbnRlZCBieQ0KYSBzdHJvbmcgdGVjaG5vbG9neSBwbGF0Zm9ybSBjcmVhdGUgdGFuZ2libGUgYnVzaW5lc3MgYmVuZWZpdHMuDQpBcyBhIHRydXN0ZWQgdHJhbnNmb3JtYXRpb24gcGFydG5lciwgd2UgYXJlIGNsb3NlIHRvIG91cg0KY3VzdG9tZXJzIGFuZCB1bmRlcnN0YW5kIHRoZWlyIHVuaXF1ZSBuZWVkcy4NCk91ciBidXNpbmVzcyBsaW5lcyBhcmUgdGhlIGZvbGxvd2luZzoNCmwgSW5kdXN0cnkgc29sdXRpb25zIHN1cHBvcnQgY3VzdG9tZXJzIGJ1c2luZXNzDQpwcm9jZXNzZXMgYXMgd2VsbCBhcyBoZWxwIHRoZW0gbWFuYWdlIGVuZC1jdXN0b21lcg0KaW50ZXJmYWNlIGFuZCBjcmVhdGUgZ3JlYXQgc2VydmljZSBleHBlcmllbmNlcy4gSW4gdGhpcw0KY2F0ZWdvcnksIHdlIHByb3ZpZGUgc29sdXRpb25zIHRvIGluZHVzdHJ5LXNwZWNpZmljIG5lZWRzLg0KVGhlc2Ugc29sdXRpb25zIGFyZSBvZnRlbiBiYXNlZCBvbiBwcm9kdWN0cyBkZXZlbG9wZWQNCmJ5IFRpZXRvLiBPbiB0b3Agb2YgdGhlc2UsIHdlIG9mZmVyIGluZHVzdHJ5IGNvbnN1bHRpbmcgYW5kDQpjdXN0b21lci1zcGVjaWZpYyBpbnRlZ3JhdGlvbiB3b3JrLg0KbCBFbnRlcnByaXNlIHNvbHV0aW9ucyBhcmUgdXNlZCBpbiBwcm9jZXNzZXMgYW5kDQpidXNpbmVzcyBzaXR1YXRpb25zIGNvbW1vbiBmb3IgYWxsIGluZHVzdHJpZXMuIFRoZXNlDQpzb2x1dGlvbnMgaW5jbHVkZSBwcm9kdWN0cyB0aGF0IGFyZSBkZXZlbG9wZWQgYnkgVGlldG8NCm9yIGEgdGhpcmQgcGFydHkgYXMgd2VsbCBhcyBzZXJ2aWNlcyByYW5naW5nIGZyb20gSVQNCmNvbnN1bHRpbmcgdG8gcmVsYXRlZCBpbnRlZ3JhdGlvbiwgYXBwbGljYXRpb24NCmRldmVsb3BtZW50IGFuZCBtYWludGVuYW5jZSB3b3JrLg0KbCBNYW5hZ2VkIHNlcnZpY2VzIGNvbXByaXNlcyBhcHBsaWNhdGlvbiBtYW5hZ2VtZW50DQppLmUuIG1haW50YWluaW5nLCBkZXZlbG9waW5nIGFuZCBlbmhhbmNpbmcgZXhpc3RpbmcgYXBwbGljYXRpb25zDQp1bmRlciBhIGxvbmctdGVybSBjb250cmFjdCwgYW5kIElDVCBpbmZyYXN0cnVjdHVyZQ0Kc2VydmljZXMgdGhhdCBlbnN1cmUgMjQvNyBvcGVyYXRpb25zIGZvciBjdXN0b21lcnMuDQpsIFByb2R1Y3QgZW5naW5lZXJpbmcgc29sdXRpb25zIGNvbXByaXNlIGRlc2lnbiwNCmRldmVsb3BtZW50IGFuZCBtYWludGVuYW5jZSBvZiBzb2Z0d2FyZSBmb3Igb3VyDQpjdXN0b21lcnMgcHJvZHVjdHMuIE91ciBzdHJvbmcgUiZEIG9mZmVyaW5nIGNvdmVycw0KdGVsZWNvbSBuZXR3b3JrcywgbW9iaWxlIGRldmljZXMgYXMgd2VsbCBhcyBhdXRvbW90aXZlDQphbmQgaW5kdXN0cmlhbCBSJkQgYXJlYXMu";
            B = "QSBsZWFkaW5nIHNlcnZpY2UgaW50ZWdyYXRvciBjcmVhdGluZyB0aGUgYmVzdA0Kc2VydmljZSBleHBlcmllbmNlIGluIElUDQpEZW1hbmQgZm9yIHNlcnZpY2VzIHRoYXQgYXJlIGF2YWlsYWJsZSBvbiBhIGNvbnRpbnVvdXMgYmFzaXMNCmFuZCBhcmUgZWFzeSB0byB1c2Ugd2l0aG91dCB0aW1lIG9yIHBsYWNlIHJlc3RyaWN0aW9ucw0KY29udGludWVzIHRvIHJpc2UuIEhvd2V2ZXIsIHRoZSByZWFsIHN1Y2Nlc3MgY29tZXMgZnJvbQ0KdXNhYmlsaXR5LCBleGNpdGVtZW50IGFuZCBhIGdyZWF0IHNlcnZpY2UgZXhwZXJpZW5jZS4gTmV3DQpzZXJ2aWNlcywgZS5nLiBtb2JpbGUgZW50ZXJwcmlzZSBzb2x1dGlvbnMsIGFyZSBrZXkgc291cmNlcyBmb3Igb3VyDQpmdXR1cmUgZ3Jvd3RoLiBFdmVyeXRoaW5nIGdvZXMgbW9iaWxlIQ0KSVQgaXMgaW5jcmVhc2luZ2x5IHBhY2thZ2VkIGFuZCBjb25zdW1lZCBhcyBhIHNlcnZpY2UuIE91cg0Kc3RyYXRlZ3kgZHJpdmVzIGZvciBoaWdoZXIgZGlmZmVyZW50aWF0aW9uIGFuZCBzcGVjaWFsaXphdGlvbiBhbmQNCmdvaW5nIGZvcndhcmQsIG1vcmUgZm9jdXMgaXMgcGxhY2VkIG9uIHByb2R1Y3RpemluZyBvdXIgaGlnaA0KdmFsdWUgYWRkaW5nIHNlcnZpY2VzIGFuZCBvZmZlcmluZ3MuDQpUaWV0b3MgdW5pcXVlIHZhbHVlIHByb3Bvc2l0aW9uIGRyaXZlcyBncm93dGggYW5kDQpwcm9maXRhYmlsaXR5DQpJbiB0b2RheXMgY29tcGV0aXRpdmUgbGFuZHNjYXBlLCBpdCBpcyBkaWZmaWN1bHQgdG8gYmVhdCB0aGUNCmNvbXBldGl0aW9uIG9uIHByaWNlIG9yIHB1cmUgcGVyZm9ybWFuY2UuIFdlIGhhdmUgY2hvc2VuIHRvDQpkaWZmZXJlbnRpYXRlIG91cnNlbHZlcyBmcm9tIHRoZSBjb21wZXRpdG9ycyB0aHJvdWdoIHN1cGVyaW9yDQpjdXN0b21lciBjZW50cmljaXR5LiBXZSBzZWVrIHRvIG1lZXQgb3VyIGN1c3RvbWVycyBidXNpbmVzcw0KY2hhbGxlbmdlcyB3aXRoIG91ciBzcGVjaWFsaXplZCBzZXJ2aWNlcy4NCldpdGggb3VyIHVuaXF1ZSB2YWx1ZSBwcm9wb3NpdGlvbiwgd2UgaGVscCBvdXIgY3VzdG9tZXJzDQp0byBncm93IGFuZCBpbXByb3ZlIHByb2R1Y3Rpdml0eS4gU3VwcG9ydGluZyBjdXN0b21lcnMgd2l0aA0KdGhlIHJlbGF0ZWQgYnVzaW5lc3MgdHJhbnNmb3JtYXRpb24gaXMgb25lIG9mIG91ciBjb3JlDQpjb21wZXRlbmNlcy4NClRoZSBzZWN0b3JzIHdlIGNvdmVyDQpUZWxlY29tIGFuZCBNZWRpYQ0KRmluYW5jZSBhbmQNCkluZHVzdHJ5IHNlY3RvcnMuDQpJbmR1c3RyeSBzZWN0b3JzIGluY2x1ZGUNCi0gQXV0b21vdGl2ZQ0KLSBFbmVyZ3kgKEVuZXJneSB1dGlsaXRpZXMgJiBPaWwgYW5kIGdhcykNCi0gSGVhbHRoY2FyZSBhbmQgd2VsZmFyZQ0KLSBNYW51ZmFjdHVyaW5nDQotIExvZ2lzdGljcw0KLSBQdWJsaWMNCi0gUmV0YWlsLg0KVGlldG8gYWltcyB0byBiZSBhIG1hcmtldCBsZWFkZXIgaW4gSVQgc2VydmljZXMgaW4NCk5vcnRoLUVhc3QgRXVyb3BlLCBhbmQgZXhwYW5kIG9wZXJhdGlvbnMgaW4gbmV3IG1hcmtldHMNCnN1Y2ggYXMgUnVzc2lhIGFuZCBQb2xhbmQuDQpPcGVyYXRpbmcgY291bnRyaWVzOiBBdXN0cmlhLCBHZXJtYW55LCBQb2xhbmQsIEJlbGFydXMsIEluZGlhLCBSdXNzaWEsDQpCZWxnaXVtLCBJbmRvbmVzaWEsIFNpbmdhcG9yZSwgQ2FuYWRhLCBJdGFseSwgU3BhaW4sIENoaW5hLCBMYXR2aWEsIFN3ZWRlbiwgQ3plY2ggUmVwdWJsaWMsIExpdGh1YW5pYSwgVWtyYWluZSwgRGVubWFyaywgTWFsYXlzaWEsIFVuaXRlZCBLaW5nZG9tLCBFc3RvbmlhLCBOZXRoZXJsYW5kcywgVVNBLCBGaW5sYW5kLCBOb3J3YXksIEZyYW5jZS4=";

        }
    }
}

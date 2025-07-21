char* __convention("regparm") sub_10002f29(char* arg1, char* arg2, char* arg3, void* arg4 @ ebp, char* arg5 @ esi, char* arg6 @ edi)
{
    *arg1 += arg1;
    arg1 += 6;
    char* ebx;
    *ebx[1] += *(arg4 - 0x3c);
    *arg1 += arg1;
    arg1 += 6;
    void* eax;
    eax = (&arg1[0xc57d]) + 0x7e;
    char* result = eax - *eax;
    *(arg5 + result);
    *(arg5 + result) += result;
    bool p = /* bool p = unimplemented  {add byte [esi+eax], al} */;
    void* result_1;
    int16_t es;
    void** ss;
    
    if (!p)
        ebx[0x2a0a0000] -= *result[1];
    else
    {
        *result += result;
        result += 0x7b;
        *arg6 = *arg5;
        arg6 = &arg6[1];
        arg5 = &arg5[1];
        *result += result;
        *arg3[1] |= arg6[0xffffffa5];
        *result += result;
        result |= *arg5;
        label_10002f50:
        *arg5 += 1;
        int32_t eflags;
        char temp0_1;
        char temp1_1;
        temp0_1 = __aaa(result, *result[1], eflags);
        result = temp0_1;
        *result[1] = temp1_1;
        int32_t temp4_1 = *result;
        *result = &result[*result];
        bool c_1 = &result[temp4_1] < temp4_1;
        *(result_1 - 4) = es;
        result_1 -= 4;
        
        while (c_1)
        {
            *result += result;
            *arg3[1] |= arg6[0xffffffa7];
            *result += result;
            *arg3[1] |= *arg2;
            *result += result;
            *ebx += arg2;
            *(result * 2) ^= result;
            label_10002f68:
            arg3 -= 1;
            *result += result;
            *arg5 += arg3;
            char temp6_1 = *result;
            *result += result;
            *(ebx + 0x38) = *(ebx + 0x38) + arg5;
            
            while (true)
            {
                *result = &result[*result];
                *(result_1 - 4) = es;
                result_1 -= 4;
                result |= *arg5;
                arg6 = &arg6[*(arg4 - 0x3a)];
                *result += result;
                result += 6;
                char temp7_1 = result;
                result += 0x7d;
                *result = 0x2060400;
                
                if (temp7_1 >= 0x83)
                    goto label_10002f50;
                
                *result += result;
                result += 6;
                void* eax_1;
                eax_1 = (&result[0xc97d]) + 0x7e;
                result = eax_1 - *eax_1;
                *(arg5 + result);
                *(arg5 + result) += result;
                bool p_1 = /* bool p_1 = unimplemented  {add byte [esi+eax], al} */;
                
                if (!p_1)
                {
                    result -= *result;
                    char temp10_1 = *result;
                    *result += result;
                    arg5 = arg5 + *result;
                    result = result;
                    goto label_10002f68;
                }
                
                *result += result;
                result += 0x7b;
                *arg6 = *arg5;
                arg6 = &arg6[1];
                arg5 = &arg5[1];
                *result += result;
                *arg3[1] |= arg6[0xffffffa5];
                *result += result;
                result |= *arg5;
                *arg5 += 1;
                *arg3;
                char temp11_1 = *arg5;
                *arg5 += result;
                c_1 = temp11_1 + result < temp11_1;
                
                if (!c_1)
                    break;
                
                *result += result;
                *arg3[1] |= arg6[0xffffffa7];
                *result += result;
                *arg3[1] |= *arg2;
                *result += result;
                *ebx += arg2;
                *(result * 2) ^= result;
                result ^= *ebx;
                *result += result;
                *result += result;
                char temp12_1 = *result;
                *result += result;
                
                if (temp12_1 + result < temp12_1)
                {
                    *result += result;
                    *0x1e172;
                    *result[1] |= *0x1e172;
                    *arg3;
                    *result += result;
                    *arg3[1] |= arg6[0xffffffa9];
                    *result += result;
                    *0x20772;
                    *result[1] |= *0x20772;
                    *arg2 = *arg2 - result;
                    result[0x28] += *arg2[1];
                    label_10002fee:
                    result = *0x6f0a0000;
                    /* unimplemented  {test eax, 0x250a0000} */
                    char temp27_1 = result;
                    char temp28_1 = *result;
                    result += *result;
                    
                    if (temp27_1 + temp28_1)
                    {
                        arg5 = __outsd(arg2, *arg5, arg5, eflags);
                        goto label_10003071;
                    }
                    
                    ebx = &ebx[1];
                    char temp31_1 = result;
                    char temp32_1 = *result;
                    result += *result;
                    bool c_6 = temp31_1 + temp32_1 < temp31_1;
                    bool o_3 = temp31_1 + temp32_1;
                    char* eax_2;
                    bool o_1;
                    bool o_7;
                    bool o_10;
                    bool o_14;
                    
                    if (o_3)
                    {
                        if (!o_3)
                            goto label_1000302d;
                        
                        while (true)
                        {
                            if (!o_3)
                            {
                                result = *0x6f0a0000;
                                
                                if ((result & 0x250a0000) < 0)
                                {
                                    char* result_4 = result;
                                    int32_t temp24_1 = *result;
                                    result = &result[*result];
                                    o_1 = result_4 + temp24_1;
                                    goto label_1000306a;
                                }
                                
                                char* result_5 = result;
                                int32_t temp26_1 = *result;
                                result = &result[*result];
                                
                                if (!(result_5 + temp26_1))
                                    goto label_1000306c;
                                
                                arg5 = __outsd(arg2, *arg5, arg5, eflags);
                                goto label_100030da;
                            }
                            
                            label_1000307f:
                            
                            if (!o_3)
                            {
                                eax_2 = *0x6f0a0000;
                                goto label_10003086;
                            }
                            
                            label_100030a9:
                            bool o_13;
                            
                            if (o_3)
                            {
                                char* result_13;
                                int32_t temp65_1;
                                
                                for (; !o_3; o_3 = result_13 + temp65_1)
                                {
                                    result = *0x6f0a0000;
                                    label_100030da:
                                    
                                    if ((result & 0x250a0000) >= 0)
                                    {
                                        char* result_8 = result;
                                        int32_t temp50_1 = *result;
                                        result = &result[*result];
                                        o_14 = result_8 + temp50_1;
                                        goto label_100030e3;
                                    }
                                    
                                    *0x3bd72;
                                    *result[1] |= *0x3bd72;
                                    o_13 = false;
                                    label_100030ce:
                                    
                                    if (o_13)
                                    {
                                        arg5 = __outsd(arg2, *arg5, arg5, eflags);
                                        goto label_10003143;
                                    }
                                    
                                    result = *(ebx + result);
                                    result_13 = result;
                                    temp65_1 = *result;
                                    result = &result[*result];
                                    c_6 = &result_13[temp65_1] < result_13;
                                }
                                
                                break;
                            }
                            
                            result = *0x6f0a0000;
                            label_100030b0:
                            
                            if ((result & 0x250a0000) >= 0)
                            {
                                char* result_6 = result;
                                int32_t temp42_1 = *result;
                                result = &result[*result];
                                
                                if (result_6 + temp42_1)
                                {
                                    arg5 = __outsd(arg2, *arg5, arg5, eflags);
                                    goto label_1000312e;
                                }
                                
                                int32_t* eax_5 = *arg5;
                                arg5 = &arg5[4];
                                result = eax_5 + *eax_5;
                                o_1 = eax_5 + *eax_5;
                                label_100030be:
                                
                                if (o_1)
                                    goto label_100030e8;
                                
                                result = *0x6f0a0000;
                                label_100030c5:
                                
                                if ((result & 0x250a0000) < 0)
                                {
                                    *0x35172;
                                    *result[1] |= *0x35172;
                                    o_10 = false;
                                    goto label_1000308f;
                                }
                                
                                char* result_7 = result;
                                int32_t temp46_1 = *result;
                                result = &result[*result];
                                o_13 = result_7 + temp46_1;
                                goto label_100030ce;
                            }
                            
                            *0x2df72;
                            *result[1] |= *0x2df72;
                            o_7 = false;
                            label_10003050:
                            
                            if (o_7)
                            {
                                arg5 = __outsd(arg2, *arg5, arg5, eflags);
                                goto label_100030c5;
                            }
                            
                            char temp29_1 = result;
                            char temp30_1 = *result;
                            result += *result;
                            c_6 = temp29_1 + temp30_1 < temp29_1;
                            o_3 = temp29_1 + temp30_1;
                        }
                        
                        goto label_100030fd;
                    }
                    
                    eax_2 = *0x6f0a0000;
                    bool o_11;
                    
                    if ((eax_2 & 0x250a0000) < 0)
                    {
                        label_1000306c:
                        
                        while (true)
                        {
                            result = *0x6f0a0000;
                            label_10003071:
                            void* temp35_1 = result & 0x250a0000;
                            
                            if (temp35_1 >= 0)
                            {
                                char* result_9 = result;
                                int32_t temp52_1 = *result;
                                result = &result[*result];
                                
                                if (result_9 + temp52_1)
                                {
                                    arg5 = __outsd(arg2, *arg5, arg5, eflags);
                                    goto label_100030ef;
                                }
                                
                                arg3 = &arg3[1];
                                char* result_11 = result;
                                int32_t temp59_1 = *result;
                                result = &result[*result];
                                c_6 = &result_11[temp59_1] < result_11;
                                o_3 = result_11 + temp59_1;
                                goto label_1000307f;
                            }
                            
                            if (temp35_1 >= 0)
                            {
                                char* result_10 = result;
                                int32_t temp57_1 = *result;
                                result = &result[*result];
                                c_6 = &result_10[temp57_1] < result_10;
                                o_3 = result_10 + temp57_1;
                                goto label_100030a9;
                            }
                            
                            result[0x28] += *arg2[1];
                            label_1000302d:
                            result = *0x6f0a0000;
                            
                            if ((result & 0x250a0000) >= 0)
                            {
                                char temp21_1 = result;
                                char temp22_1 = *result;
                                result += *result;
                                
                                if (!(temp21_1 + temp22_1))
                                    /* undefined */
                                
                                arg5 = __outsd(arg2, *arg5, arg5, eflags);
                                goto label_100030b0;
                            }
                            
                            char temp19_1 = result;
                            char temp20_1 = *result;
                            result += *result;
                            o_1 = temp19_1 + temp20_1;
                            
                            if (!o_1)
                                goto label_10002fee;
                            
                            label_10003016:
                            
                            if (!o_1)
                            {
                                result = *0x6f0a0000;
                                
                                if ((result & 0x250a0000) < 0)
                                {
                                    result &= 0x36972;
                                    o_11 = false;
                                    break;
                                }
                                
                                char temp37_1 = result;
                                char temp38_1 = *result;
                                result += *result;
                                
                                if (!(temp37_1 + temp38_1))
                                {
                                    *0x28700002;
                                    goto label_1000302d;
                                }
                                
                                arg5 = __outsd(arg2, *arg5, arg5, eflags);
                                goto label_1000309b;
                            }
                            
                            if (!o_1)
                            {
                                result = *0x6f0a0000;
                                
                                if ((result & 0x250a0000) < 0)
                                    goto label_1000302d;
                                
                                char temp17_1 = result;
                                char temp18_1 = *result;
                                result += *result;
                                o_7 = temp17_1 + temp18_1;
                                goto label_10003050;
                            }
                            
                            label_1000306a:
                            
                            if (o_1)
                                goto label_10003094;
                        }
                        
                        goto label_100030a4;
                    }
                    
                    char temp54_1 = eax_2;
                    char temp55_1 = *eax_2;
                    eax_2 += *eax_2;
                    
                    if (!(temp54_1 + temp55_1))
                    {
                        *arg2;
                        result = nullptr;
                        o_1 = /* o_1 = unimplemented  {imul eax, dword [edx], 0x0} */;
                        goto label_10003016;
                    }
                    
                    arg5 = __outsd(arg2, *arg5, arg5, eflags);
                    label_10003086:
                    bool o_19;
                    
                    if ((eax_2 & 0x250a0000) < 0)
                    {
                        result = eax_2 & 0x3e772;
                        o_14 = false;
                        label_100030e3:
                        void* eax_10;
                        
                        if (!o_14)
                        {
                            es = *result_1;
                            result_1 += 2;
                            char temp69_1 = result;
                            result = result;
                            o_1 = temp69_1 + 0;
                            label_100030e8:
                            
                            if (o_1)
                                goto label_10003112;
                            
                            result = *0x6f0a0000;
                            label_100030ef:
                            char temp76_1 = result;
                            result = result;
                            
                            if (!(temp76_1 + 0))
                            {
                                char temp0_2;
                                temp0_2 = __das(result, eflags);
                                result = temp0_2;
                                char temp81_1 = result;
                                result = result;
                                c_6 = temp81_1 >= 0;
                                o_3 = temp81_1 + 0;
                                label_100030fd:
                                
                                if (o_3)
                                {
                                    while (true)
                                    {
                                        if (o_3)
                                        {
                                            if (o_3)
                                                break;
                                            
                                            goto label_10003153;
                                        }
                                        
                                        result = *0x6f0a0000;
                                        label_1000312e:
                                        char temp70_1 = result;
                                        result = result;
                                        
                                        if (temp70_1 + 0)
                                        {
                                            arg5 = __outsd(arg2, *arg5, arg5, eflags);
                                            goto label_100031ac;
                                        }
                                        
                                        *ebx[1] = 4;
                                        result[0x28] += *arg2[1];
                                        label_1000313e:
                                        result = *0x6f0a0000;
                                        label_10003143:
                                        
                                        if ((result & 0x250a0000) >= 0)
                                            goto label_1000314a;
                                        
                                        result[0x28] += *arg2[1];
                                        label_10003114:
                                        result = *0x6f0a0000;
                                        label_10003119:
                                        
                                        if ((result & 0x250a0000) < 0)
                                            goto label_10003189;
                                        
                                        char temp77_1 = result;
                                        result = result;
                                        c_6 = temp77_1 >= 0;
                                        o_3 = temp77_1 + 0;
                                        
                                        if (o_3)
                                        {
                                            arg5 = __outsd(arg2, *arg5, arg5, eflags);
                                            goto label_10003197;
                                        }
                                        
                                        *(result * 2) = result;
                                    }
                                    
                                    goto label_1000317b;
                                }
                                
                                result = *0x6f0a0000;
                                goto label_10003104;
                            }
                            
                            arg5 = __outsd(arg2, *arg5, arg5, eflags);
                            label_1000316d:
                            
                            if ((result & 0x250a0000) < 0)
                            {
                                arg3[0x6f0a0000] -= *result[1];
                                label_10003197:
                                
                                if ((result & 0x250a0000) < 0)
                                {
                                    arg3[0x6f0a0000] -= *result[1];
                                    goto label_1000321c;
                                }
                                
                                result = &result[0x2a9ae000];
                                label_100031a8:
                                *result += result;
                                *arg3[1] |= arg6[0xffffffa9];
                                *result += result;
                                *0x59972;
                                *result[1] |= *0x59972;
                                *arg6 = result;
                                arg6 = &arg6[4];
                                goto label_100031b8;
                            }
                            
                            void* eax_7 = &result[0x1d727000];
                            int32_t temp85_1 = *eax_7;
                            result = eax_7 + *eax_7;
                            c_6 = eax_7 + temp85_1 < eax_7;
                            o_3 = eax_7 + temp85_1;
                            label_1000317b:
                            
                            if (!o_3)
                            {
                                result = *0x6f0a0000;
                                goto label_10003182;
                            }
                            
                            if (!o_3)
                            {
                                result = *0x6f0a0000;
                                label_100031ac:
                                result = &result[0xab727000];
                                label_100031b8:
                                result = &result[0xa1287000];
                                *result += result;
                                *arg3[1] |= arg6[0xffffffa9];
                                *result += result;
                                label_100031c4:
                                *0x5bb72;
                                *result[1] |= *0x5bb72;
                                label_100031cc:
                                *arg6 = result;
                                arg6 = &arg6[4];
                                label_100031d2:
                                result[0xa1287000] += (&result[0xa1287000]);
                                *arg3[1] |= arg6[0xffffffa9];
                                result[0xa1287000] += (&result[0xa1287000]);
                                *0x5e772;
                                *result[1] = *(&result[0xa1287000])[1] | *0x5e772;
                                eax_10 = result + *arg5;
                                goto label_100031e3;
                            }
                            
                            if (!o_3)
                            {
                                result = *0x6f0a0000;
                                goto label_100031d6;
                            }
                            
                            if (!o_3)
                                goto label_100031fb;
                            
                            if (!o_3)
                                goto label_10003225;
                            
                            int16_t ds;
                            
                            if (!o_3)
                            {
                                while (true)
                                {
                                    result = *0x6f0a0000;
                                    
                                    if ((result & 0x250a0000) >= 0)
                                        break;
                                    
                                    char* result_3 = arg6;
                                    arg6 = result;
                                    result = result_3;
                                    
                                    while (true)
                                    {
                                        *(result_1 - 4) = es;
                                        result_1 -= 4;
                                        char temp99_1 = result[0x72];
                                        result[0x72] += *arg2[1];
                                        bool o_22 = temp99_1 + *arg2[1];
                                        label_10003235:
                                        
                                        if (!o_22)
                                        {
                                            *arg3[1] |= arg6[0xffffffa9];
                                            *result += result;
                                            *0x6af72;
                                            *result[1] |= *0x6af72;
                                        }
                                        else
                                        {
                                            result[0x28] += *arg2[1];
                                            label_1000323a:
                                            result = *0x6f0a0000;
                                            void* temp100_1 = result & 0x250a0000;
                                            
                                            if (temp100_1 < 0)
                                            {
                                                if (temp100_1 >= 0)
                                                {
                                                    label_100031f7:
                                                    *(result_1 - 4) = es;
                                                    result_1 -= 4;
                                                    result[0x28] += *arg2[1];
                                                    label_100031fb:
                                                    result = *0x6f0a0000;
                                                    *(result_1 - 4) = es;
                                                    result_1 -= 4;
                                                    char temp101_1 = result[0x72];
                                                    result[0x72] += *arg2[1];
                                                    bool o_21;
                                                    
                                                    if (!(temp101_1 + *arg2[1]))
                                                    {
                                                        *arg3[1] |= arg6[0xffffffa9];
                                                        *result += result;
                                                        *0x68172;
                                                        *result[1] |= *0x68172;
                                                        o_21 = false;
                                                    }
                                                    else
                                                    {
                                                        result[0x28] += *arg2[1];
                                                        label_10003210:
                                                        result = *0x6f0a0000;
                                                        label_1000321c:
                                                        *(result_1 - 4) = es;
                                                        result_1 -= 4;
                                                        char temp90_1 = result[0x72];
                                                        result[0x72] += *arg2[1];
                                                        o_21 = temp90_1 + *arg2[1];
                                                    }
                                                    
                                                    if (!o_21)
                                                    {
                                                        *arg3[1] |= arg6[0xffffffa9];
                                                        *result += result;
                                                        *0x69772;
                                                        *result[1] |= *0x69772;
                                                        o_22 = false;
                                                        goto label_10003235;
                                                    }
                                                    
                                                    result[0x28] += *arg2[1];
                                                    label_10003225:
                                                    result = *0x6f0a0000;
                                                    
                                                    if ((result & 0x250a0000) < 0)
                                                        goto label_100031c8;
                                                    
                                                    continue;
                                                }
                                                
                                                *0x6af72;
                                                *result[1] |= *0x6af72;
                                            }
                                            else
                                            {
                                                *(result_1 - 4) = es;
                                                result_1 -= 4;
                                                result[0x72] += *arg2[1];
                                            }
                                        }
                                        
                                        void* eax_11;
                                        eax_11 = __lds_gprz_memp(*arg5);
                                        *(eax_11 + 0x28) += *arg2[1];
                                        break;
                                    }
                                }
                                
                                *(result_1 - 4) = es;
                                result_1 -= 4;
                                result[0x72] += *arg2[1];
                                goto label_10003260;
                            }
                            
                            if (o_3)
                            {
                                if (!o_3)
                                    goto label_100032a3;
                                
                                if (o_3)
                                {
                                    *ebx = *ebx - 0;
                                    *(arg2 + arg4) += result;
                                    *arg2;
                                    result = &result[*(result + arg4)];
                                }
                                else
                                {
                                    while (true)
                                    {
                                        result = *0x6f0a0000;
                                        
                                        if ((result & 0x250a0000) >= 0)
                                            break;
                                        
                                        *result += result;
                                        *0x74172;
                                        *result[1] |= *0x74172;
                                        label_1000329e:
                                        *(result_1 - 4) = arg4;
                                        *(result_1 - 4);
                                        result_1 -= 2;
                                        result[0x28] += *arg2[1];
                                        label_100032a3:
                                        result = *0x6f0a0000;
                                        *result_1;
                                        result_1 += 2;
                                        label_100032b0:
                                        result[0x72] += *arg2[1];
                                        *arg6 -= 0x5ed79000;
                                        *result += result;
                                        *arg3[1] |= arg6[0xffffffa9];
                                        *result += result;
                                        *0x79172;
                                        *result[1] |= *0x79172;
                                        label_100032c8:
                                        *arg6 = result;
                                        arg6 = &arg6[4];
                                        *result_1;
                                        result_1 += 2;
                                        result[0x28] += *arg2[1];
                                    }
                                    
                                    es = *result_1;
                                    result_1 += 2;
                                    char temp123_1 = result[0x72];
                                    result[0x72] += *arg2[1];
                                    arg3 -= 1;
                                    
                                    if (temp123_1 == -(*arg2[1]) || arg3)
                                        arg5 = __outsd(arg2, *arg5, arg5, eflags);
                                    else
                                    {
                                        result[0x28] += *arg2[1];
                                        label_100032e2:
                                        result = *0x6f0a0000;
                                    }
                                    
                                    result = result - *result;
                                    ebx[arg5 << 1] += result;
                                    *arg6 = result;
                                    arg6 = &arg6[1];
                                    *result += result;
                                    result |= result[0x400001b];
                                    *ebx[1] -= *arg2;
                                    result += *ebx;
                                    result += 0x28;
                                }
                                
                                *arg6 = result;
                                arg6 = &arg6[4];
                                *result += result;
                                ebx |= *result;
                                void* result_15 = result_1;
                                result_1 = result;
                                result = result_15 + 0x2a02fe;
                                *ebx += arg2;
                                *(result * 2) ^= result;
                            }
                            else
                            {
                                while (true)
                                {
                                    result = *0x6f0a0000;
                                    
                                    if ((result & 0x250a0000) < 0)
                                        goto label_100032b0;
                                    
                                    es = *result_1;
                                    result_1 += 2;
                                    result[0x72] += *arg2[1];
                                    ebx = &ebx[1];
                                    char temp110_1 = result;
                                    char temp111_1 = *result;
                                    result += *result;
                                    o_1 = temp110_1 + temp111_1;
                                    label_1000328c:
                                    
                                    if (!o_1)
                                    {
                                        result = *0x6f0a0000;
                                        *result_1;
                                        result_1 += 2;
                                        result[0x72] += *arg2[1];
                                        goto label_1000329e;
                                    }
                                    
                                    if (o_1)
                                        break;
                                    
                                    result = *0x6f0a0000;
                                    
                                    if ((result & 0x250a0000) >= 0)
                                    {
                                        *result_1;
                                        result_1 += 2;
                                        result[0x72] += *arg2[1];
                                        goto label_100032c8;
                                    }
                                    
                                    *result += result;
                                    *0x6d572;
                                    *result[1] |= *0x6d572;
                                    label_10003260:
                                    *(result_1 - 4) = es;
                                    result_1 -= 4;
                                    result[0x28] += *arg2[1];
                                    label_10003264:
                                    void* eax_12 = *0x6f0a0000;
                                    
                                    if ((eax_12 & 0x250a0000) < 0)
                                    {
                                        *result_1;
                                        result_1 += 2;
                                    }
                                    else
                                    {
                                        *result_1;
                                        result_1 += 2;
                                        char temp107_1 = *(eax_12 + 0x72);
                                        *(eax_12 + 0x72) += *arg2[1];
                                        eax_12 = eax_12 - *arg6;
                                    }
                                    
                                    *(eax_12 + 0x28) += *arg2[1];
                                }
                                
                                if (!o_1)
                                    goto label_100032e2;
                                
                                char temp112_1 = *result;
                                *result += result;
                                arg5 = arg5 + *result;
                                result = result;
                            }
                            
                            char temp0_3;
                            temp0_3 = __das(result, eflags);
                            result = temp0_3;
                            *result += result;
                            *arg6 += arg3;
                            char temp115_1 = *result;
                            *result += result;
                            *arg2 = *arg2 + result;
                            void* eax_14 = &result[*(result + arg4)];
                            *arg6 = eax_14;
                            arg6 = &arg6[4];
                            *eax_14 += eax_14;
                            *arg2;
                            arg3 |= *arg2;
                            *(result_1 - 4) = es;
                            *(arg4 + eax_14 - 0x72e6ecce) = *(arg4 + eax_14 - 0x72e6ecce) - arg2;
                            *0x25010000 = eax_14;
                            *(result_1 - 8) = ss;
                            result_1 -= 8;
                            ebx += arg5[0x9e031725];
                            result = eax_14 & 0x2a9e0418;
                            *(result_1 - 4) = es;
                            *(result_1 - 8) = ss;
                            *(result - 4) = es;
                            ss = *(result - 4);
                            result_1 -= 8;
                            *arg3[1] |= *arg2;
                            *arg2 = 0x16;
                            int32_t eax_18;
                            arg2 = HIGHD(&result[0xac26]);
                            eax_18 = LOWD(&result[0xac26]);
                            result = eax_18 & *eax_18;
                            *result += result;
                            char temp116 = *result;
                            *result += result;
                            char* ecx = arg3 - 1;
                            
                            if (temp116 != -(result) && ecx)
                                goto label_100033c2;
                            
                            arg2 = *result_1;
                            void* esp_8 = result_1 + 4;
                            char* eax_19 = *arg2 * 0x239917;
                            *eax_19 += eax_19;
                            char temp120_1 = *eax_19;
                            *eax_19 += eax_19;
                            ecx -= 1;
                            void* eax_25;
                            void* eax_28;
                            
                            if (temp120_1 != -(eax_19) && ecx)
                            {
                                eax_28 = eax_19 & 0x94170617;
                                label_100033d5:
                                uint8_t temp0_10;
                                temp0_10 = __insb(arg6, arg2, eflags);
                                *arg6 = temp0_10;
                                eax_25 = eax_28 & *eax_28;
                                *eax_25 += eax_25;
                                char temp125_1 = *eax_25;
                                *eax_25 += eax_25;
                                ecx -= 1;
                                
                                if (temp125_1 == -(eax_25) || !ecx)
                                    goto label_100033df;
                            }
                            else
                            {
                                arg2 = *esp_8;
                                esp_8 += 4;
                                char* eax_20 = *arg2 * 0x239918;
                                *eax_20 += eax_20;
                                char temp124_1 = *eax_20;
                                *eax_20 += eax_20;
                                ecx -= 1;
                                char* eax_24;
                                void* esp_19;
                                
                                if (temp124_1 != -(eax_20) && ecx)
                                {
                                    label_100033df:
                                    ebx = *esp_8;
                                    void* esp_18 = esp_8 + 4;
                                    esp_8 = *0x18061825;
                                    uint8_t temp0_12;
                                    temp0_12 = __insb(arg6, arg2, eflags);
                                    *arg6 = temp0_12;
                                    eax_25 = esp_18 & *esp_18;
                                    *eax_25 += eax_25;
                                    char temp126_1 = *eax_25;
                                    *eax_25 += eax_25;
                                    ecx -= 1;
                                    
                                    if (temp126_1 != -(eax_25) && ecx)
                                        goto label_1000345e;
                                    
                                    ebx = *esp_8;
                                    esp_19 = esp_8 + 4;
                                    int32_t eax_32;
                                    int32_t* edx_3;
                                    edx_3 = HIGHD(*0x19021925);
                                    eax_32 = LOWD(*0x19021925);
                                    int32_t* eax_33 = *0x2a;
                                    arg5 = arg5 + *eax_33;
                                    eax_24 = &eax_33[0x8c0];
                                    *eax_24 += edx_3;
                                    char temp132_1 = *eax_24;
                                    *eax_24 += eax_24;
                                    *edx_3 = *edx_3 + eax_24;
                                    *arg5 -= ecx;
                                    goto label_1000340b;
                                }
                                
                                int32_t* edx = *esp_8;
                                int32_t* eax_21 = *ebx * 0x2b28;
                                *esp_8 = es;
                                eax_21 -= *eax_21;
                                char temp127_1 = *eax_21;
                                *eax_21 += eax_21;
                                arg5 = arg5 + *eax_21;
                                *arg6 += ecx;
                                char temp128_1 = eax_21[0x1c40];
                                eax_21[0x1c40] += (&eax_21[0x1c40]);
                                *edx = *edx + &eax_21[0x1c40];
                                *(esp_8 - 4) = ss;
                                int32_t eax_23;
                                char edx_1;
                                edx_1 = HIGHD(&eax_21[0x1c40]);
                                eax_23 = LOWD(&eax_21[0x1c40]);
                                eax_24 = eax_23 & *eax_23;
                                *eax_24 += eax_24;
                                char temp129_1 = *eax_24;
                                *eax_24 += eax_24;
                                void* esp_12;
                                void* esp_13;
                                void* result_2;
                                
                                if (temp129_1 != -(eax_24) && ecx != 1)
                                {
                                    char temp133_1 = *eax_24;
                                    *eax_24 += eax_24;
                                    *eax_24 = *eax_24 + eax_24;
                                    *(ecx - 1) += edx_1;
                                    *ecx[1] = *(ecx - 1)[1] + *eax_24;
                                    int16_t cs;
                                    *(esp_8 - 8) = cs;
                                    esp_19 = esp_8 - 8;
                                    label_1000340b:
                                    *eax_24 = &eax_24[*eax_24];
                                    *(esp_19 - 4) = es;
                                    esp_12 = esp_19 - 4;
                                    arg4 += *eax_24;
                                    label_10003410:
                                    eax_24[cs] += eax_24;
                                    *(esp_12 - 4) = es;
                                    eax_24 |= *arg5;
                                    *(esp_12 - 8) = ss;
                                    esp_13 = esp_12 - 8;
                                    *arg5;
                                    *arg5;
                                    arg2 = HIGHD(*arg5 * 0x19);
                                    eax_25 = LOWD(*arg5 * 0x19);
                                    label_10003424:
                                    arg5 = nullptr;
                                    *arg2 += ecx;
                                    ecx -= arg2[0x72];
                                    __int1();
                                    es = *esp_13;
                                    result_2 = esp_13 + 2;
                                    *(eax_25 + 2) += *arg2[1];
                                    *0x30a0000 -= *ecx[1];
                                    arg6[0x2a0a0000] -= *ecx[1];
                                    goto label_1000343e;
                                }
                                
                                esp_12 = esp_8;
                                eax_24 = **(esp_8 - 4) * 0x239917;
                                *eax_24 += eax_24;
                                char temp134_1 = *eax_24;
                                *eax_24 += eax_24;
                                ecx -= 2;
                                
                                if (temp134_1 != -(eax_24) && ecx)
                                    goto label_10003410;
                                
                                arg2 = *esp_12;
                                esp_13 = esp_12 + 4;
                                eax_25 = *arg2 * 0x239918;
                                *eax_25 += eax_25;
                                char temp137_1 = *eax_25;
                                *eax_25 += eax_25;
                                ecx -= 1;
                                
                                if (temp137_1 != -(eax_25) && ecx)
                                {
                                    ecx[0x9919066b] = ecx[0x9919066b] - ebx;
                                    goto label_10003424;
                                }
                                
                                arg2 = *esp_13;
                                result = *ebx * 0x2c28;
                                *esp_13 = es;
                                ebx |= *arg2;
                                *(result * 2 + 0x162500fc) = es;
                                result_1 = result * 2 + 0x162500fc;
                                label_100033c2:
                                *(result_1 - 4) = ss;
                                result_2 = result;
                                uint8_t temp0_8;
                                temp0_8 = __insb(arg6, arg2, eflags);
                                *arg6 = temp0_8;
                                eax_25 = (result_1 - 4) & *(result_1 - 4);
                                *eax_25 += eax_25;
                                char temp119_1 = *eax_25;
                                *eax_25 += eax_25;
                                ecx -= 1;
                                
                                if (temp119_1 == -(eax_25) || !ecx)
                                {
                                    ebx = *result_2;
                                    esp_8 = *0x17061725;
                                    eax_28 = result_2 + 4;
                                    goto label_100033d5;
                                }
                                
                                *ecx[1] |= *arg2;
                                label_1000343e:
                                *(result_2 - 4) = ds;
                                esp_8 = result_2 - 4;
                                *ecx[1] += *eax_25;
                                eax_25 = 0;
                                *arg2 += ecx;
                                eax_25 = 0 - *eax_25;
                                *ebx += ebx;
                                *ebx ^= eax_25;
                                ecx += *eax_25[1];
                            }
                            *eax_25 += eax_25;
                            *ecx += arg2;
                            char temp130_1 = *eax_25;
                            *eax_25 += eax_25;
                            *arg2 = *arg2 + eax_25;
                            arg5 = __outsd(arg2, *arg5, arg5, eflags);
                            
                            while (true)
                            {
                                *eax_25 += eax_25;
                                *ecx[1] |= arg6[0xffffffb1];
                                *eax_25 += eax_25;
                                label_1000345e:
                                *ebx[1] |= arg5[0xffffffce];
                                *eax_25 += eax_25;
                                eax_25 += 0x25;
                                *(eax_25 + 0x3281d9e9) += (eax_25 + 0x3281d9e9);
                                void* eax_40;
                                eax_40 = (eax_25 + 0x3281d9e9) - 2;
                                *(esp_8 - 4) = es;
                                arg2 = 0;
                                *arg2 += ecx;
                                void* eax_41;
                                eax_41 = (eax_40 & 0xce80) + 0x28;
                                *(esp_8 - 4);
                                *eax_41 += eax_41;
                                arg6 -= *(arg5 - 0x31);
                                *eax_41 += eax_41;
                                eax_41 += 0x25;
                                *(eax_41 + 0x3281d9e9) += (eax_41 + 0x3281d9e9);
                                eax_25 = (eax_41 + 0x3281d9e9) - 2;
                                *(esp_8 - 6) = es;
                                int32_t temp131_1 = *eax_25;
                                *eax_25 += eax_25;
                                *(esp_8 - 0xa) = es;
                                esp_8 -= 0xa;
                                
                                if (temp131_1 + eax_25 < temp131_1)
                                    break;
                                
                                char temp138_1 = *eax_25;
                                *eax_25 += eax_25;
                                *eax_25 = *eax_25 + eax_25;
                                *(ecx - 1) = *(ecx - 1);
                                *ecx[1] = *(ecx - 1)[1] + arg6[0x42];
                            }
                            
                            *eax_25 += eax_25;
                            *eax_25[1] |= *0xcf80;
                            eax_25 += 0x28;
                            *eax_25 &= eax_25;
                            *ebx += *ecx[1];
                            *ecx -= *eax_25[1];
                            *eax_25 += eax_25;
                            char ecx_1 = ecx - *arg2;
                            *(esp_8 - 4) = es;
                            __outsd(arg2, *arg5, arg5, eflags);
                            *eax_25[1] = 0;
                            *arg2 += ecx_1;
                            *ebx;
                            eax_25 = eax_25 - 0x12;
                            *eax_25 += arg4 | *ebx;
                            *arg2 = *arg2;
                            void* eax_42;
                            eax_42 = (eax_25 & 0xcc7b) + 0x28;
                            eax_42 &= *eax_42;
                            *ebx = *ebx;
                            arg6[0x7d0a0000] -= *arg2[1];
                            breakpoint();
                        }
                        
                        arg5 = __outsd(arg2, *arg5, arg5, eflags);
                        label_1000315d:
                        
                        while ((result & 0x250a0000) < 0)
                            arg3[0x6f0a0000] -= *result[1];
                        
                        char temp80_1 = result;
                        result = result;
                        o_19 = temp80_1 + 0;
                        label_10003161:
                        
                        if (!o_19)
                        {
                            label_10003168:
                            result = *0x6f0a0000;
                            goto label_1000316d;
                        }
                        
                        arg5 = __outsd(arg2, *arg5, arg5, eflags);
                        label_100031d6:
                        
                        if ((result & 0x250a0000) < 0)
                            goto label_100031c4;
                        
                        eax_10 = &result[0x13727000];
                        *(result_1 - 4) = es;
                        result_1 -= 4;
                        label_100031e3:
                        *(eax_10 + 0x28) += *arg2[1];
                    }
                    else
                    {
                        result = &eax_2[*eax_2];
                        o_10 = eax_2 + *eax_2;
                        label_1000308f:
                        char* eax_8;
                        
                        if (o_10)
                        {
                            arg5 = __outsd(arg2, *arg5, arg5, eflags);
                            label_10003104:
                            
                            if ((result & 0x250a0000) >= 0)
                                goto label_1000310b;
                            
                            label_1000314a:
                            char temp78_1 = result;
                            result = result;
                            
                            if (!(temp78_1 + 0))
                            {
                                if (!arg3)
                                {
                                    *result += result;
                                    *arg3[1] |= arg6[0xffffffa9];
                                    *result += result;
                                    *0x4f372;
                                    *result[1] |= *0x4f372;
                                    o_19 = false;
                                    goto label_10003161;
                                }
                                
                                result[0x28] += *arg2[1];
                                label_10003153:
                                result = *0x6f0a0000;
                                goto label_1000315d;
                            }
                            
                            arg5 = __outsd(arg2, *arg5, arg5, eflags);
                            label_100031c1:
                            
                            if ((result & 0x250a0000) >= 0)
                            {
                                label_100031c8:
                                result = &result[0xab727000];
                                goto label_100031d2;
                            }
                            
                            *result += result;
                            *0x54372;
                            *result[1] |= *0x54372;
                            arg6 = *result_1;
                            arg5 = *(result_1 + 4);
                            arg4 = *(result_1 + 8);
                            ebx = *(result_1 + 0x10);
                            arg2 = *(result_1 + 0x14);
                            arg3 = *(result_1 + 0x18);
                            eax_8 = *(result_1 + 0x1c);
                            result_1 += 0x20;
                            goto label_10003193;
                        }
                        
                        arg3 = &arg3[1];
                        char* result_12 = result;
                        int32_t temp63_1 = *result;
                        result = &result[*result];
                        o_1 = result_12 + temp63_1;
                        label_10003094:
                        
                        if (o_1)
                            goto label_100030be;
                        
                        result = *0x6f0a0000;
                        label_1000309b:
                        
                        if ((result & 0x250a0000) >= 0)
                        {
                            char* result_14 = result;
                            int32_t temp68_1 = *result;
                            result = &result[*result];
                            o_11 = result_14 + temp68_1;
                            label_100030a4:
                            
                            if (o_11)
                            {
                                arg5 = __outsd(arg2, *arg5, arg5, eflags);
                                goto label_10003119;
                            }
                            
                            int32_t temp61_1 = *ebx;
                            *ebx = *ebx;
                            c_6 = temp61_1 >= 0;
                            o_3 = temp61_1 + 0;
                            goto label_100030a9;
                        }
                        
                        label_1000310b:
                        char temp66_1 = result;
                        result = result;
                        
                        if (temp66_1 + 0)
                        {
                            arg5 = __outsd(arg2, *arg5, arg5, eflags);
                            label_10003182:
                            
                            if ((result & 0x250a0000) < 0)
                                goto label_100031cc;
                            
                            label_10003189:
                            eax_8 = &result[0x61727000];
                            label_10003193:
                            eax_8[0xa1287000] += (&eax_8[0xa1287000]);
                            *arg3[1] |= arg6[0xffffffa9];
                            eax_8[0xa1287000] += (&eax_8[0xa1287000]);
                            *0x57172;
                            *result[1] = *(&eax_8[0xa1287000])[1] | *0x57172;
                            *0xa1287000 = result;
                            goto label_100031a8;
                        }
                        
                        arg3 = *result_1;
                        result_1 += 4;
                        char temp79_1 = result;
                        result = result;
                        o_1 = temp79_1 + 0;
                        label_10003112:
                        
                        if (!o_1)
                            goto label_10003114;
                        
                        if (!o_1)
                            goto label_1000313e;
                        
                        if (!o_1)
                            goto label_10003168;
                        
                        if (!o_1)
                        {
                            result = *0x6f0a0000;
                            goto label_10003197;
                        }
                        
                        if (!o_1)
                        {
                            result = *0x6f0a0000;
                            goto label_100031c1;
                        }
                        
                        if (o_1)
                        {
                            if (!o_1)
                                goto label_10003210;
                            
                            if (!o_1)
                                goto label_1000323a;
                            
                            if (o_1)
                                goto label_1000328c;
                            
                            goto label_10003264;
                        }
                    }
                    result = *0x6f0a0000;
                    
                    if ((result & 0x250a0000) < 0)
                        goto label_1000321c;
                    
                    *(result_1 - 4) = es;
                    result_1 -= 4;
                    result[0x72] += *arg2[1];
                    ebx -= 1;
                    goto label_100031f7;
                }
            }
        }
        
        char temp5_1 = *ebx;
        *ebx += *arg3[1];
        result = result + *0xa3280512;
        *result += result;
        *arg3[1] |= *arg2;
    }
    
    char temp3 = *result;
    *result += result;
    char* esi_1 = arg5 + *result;
    result = result;
    *result += result;
    *0x73110000 += arg3 - 1;
    *(ss + result) = &result[*(ss + result)];
    *(result_1 - 4) = es;
    result |= *esi_1;
    *(arg4 - 0x3e);
    *result += result;
    result += 6;
    result += 0x7d;
    return result;
}

int32_t __convention("regparm") sub_1000303e(char* arg1, char* arg2, char* arg3, char* arg4 @ ebp, int32_t* arg5 @ esi, void* arg6 @ edi)
{
    char temp1 = arg1;
    char temp2 = *arg1;
    arg1 += *arg1;
    bool o = temp1 + temp2;
    label_10003040:
    bool o_1;
    
    if (!o)
    {
        arg1 = *0x6f0a0000;
        
        if ((arg1 & 0x250a0000) < 0)
            goto label_1000302d;
        
        char temp4_1 = arg1;
        char temp5_1 = *arg1;
        arg1 += *arg1;
        o_1 = temp4_1 + temp5_1;
        goto label_10003050;
    }
    
    label_1000306a:
    
    if (!o)
        goto label_1000306c;
    
    int32_t eflags;
    int32_t* ebx;
    void* esp;
    int16_t es;
    int16_t ds;
    
    while (true)
    {
        bool c_1;
        bool o_2;
        bool o_5;
        bool o_9;
        
        if (o)
        {
            label_100030be:
            
            if (o)
                goto label_100030e8;
            
            arg1 = *0x6f0a0000;
            label_100030c5:
            
            if ((arg1 & 0x250a0000) < 0)
            {
                *0x35172;
                *arg1[1] |= *0x35172;
                o_5 = false;
                label_1000308f:
                
                if (o_5)
                    arg5 = __outsd(arg2, *arg5, arg5, eflags);
                else
                {
                    arg3 = &arg3[1];
                    char* temp41_1 = arg1;
                    int32_t temp42_1 = *arg1;
                    arg1 = &arg1[*arg1];
                    o = temp41_1 + temp42_1;
                    continue;
                }
                
                goto label_10003104;
            }
            
            char* temp23_1 = arg1;
            int32_t temp24_1 = *arg1;
            arg1 = &arg1[*arg1];
            bool o_8 = temp23_1 + temp24_1;
            
            while (true)
            {
                if (o_8)
                {
                    arg5 = __outsd(arg2, *arg5, arg5, eflags);
                    goto label_10003143;
                }
                
                arg1 = *(ebx + arg1);
                char* temp43_1 = arg1;
                int32_t temp44_1 = *arg1;
                arg1 = &arg1[*arg1];
                c_1 = &temp43_1[temp44_1] < temp43_1;
                o_2 = temp43_1 + temp44_1;
                label_100030d3:
                
                if (o_2)
                    break;
                
                arg1 = *0x6f0a0000;
                label_100030da:
                
                if ((arg1 & 0x250a0000) >= 0)
                {
                    char* temp68_1 = arg1;
                    int32_t temp69_1 = *arg1;
                    arg1 = &arg1[*arg1];
                    o_9 = temp68_1 + temp69_1;
                    goto label_100030e3;
                }
                
                *0x3bd72;
                *arg1[1] |= *0x3bd72;
                o_8 = false;
            }
            
            goto label_100030fd;
        }
        
        arg1 = *0x6f0a0000;
        label_1000309b:
        char* eax_5;
        void* eax_7;
        
        if ((arg1 & 0x250a0000) < 0)
        {
            label_1000310b:
            char temp12_1 = arg1;
            arg1 = arg1;
            
            if (!(temp12_1 + 0))
            {
                arg3 = *esp;
                esp += 4;
                char temp28_1 = arg1;
                arg1 = arg1;
                o = temp28_1 + 0;
                label_10003112:
                
                if (!o)
                    goto label_10003114;
                
                if (!o)
                {
                    while (true)
                    {
                        arg1 = *0x6f0a0000;
                        label_10003143:
                        
                        if ((arg1 & 0x250a0000) >= 0)
                            goto label_1000314a;
                        
                        arg1[0x28] += *arg2[1];
                        label_10003114:
                        arg1 = *0x6f0a0000;
                        label_10003119:
                        
                        if ((arg1 & 0x250a0000) < 0)
                            goto label_10003189;
                        
                        char temp39_1 = arg1;
                        arg1 = arg1;
                        c_1 = temp39_1 >= 0;
                        o_2 = temp39_1 + 0;
                        
                        if (o_2)
                        {
                            arg5 = __outsd(arg2, *arg5, arg5, eflags);
                            goto label_10003197;
                        }
                        
                        *(arg1 * 2) = arg1;
                        label_10003127:
                        
                        if (o_2)
                        {
                            if (o_2)
                                break;
                            
                            goto label_10003153;
                        }
                        
                        arg1 = *0x6f0a0000;
                        label_1000312e:
                        char temp71_1 = arg1;
                        arg1 = arg1;
                        
                        if (temp71_1 + 0)
                        {
                            arg5 = __outsd(arg2, *arg5, arg5, eflags);
                            goto label_100031ac;
                        }
                        
                        *ebx[1] = 4;
                        arg1[0x28] += *arg2[1];
                    }
                    
                    goto label_1000317b;
                }
                
                if (!o)
                {
                    label_10003168:
                    arg1 = *0x6f0a0000;
                    goto label_1000316d;
                }
                
                if (!o)
                {
                    arg1 = *0x6f0a0000;
                    goto label_10003197;
                }
                
                if (!o)
                {
                    arg1 = *0x6f0a0000;
                    goto label_100031c1;
                }
                
                if (!o)
                    goto label_100031e6;
                
                if (!o)
                    goto label_10003210;
                
                if (!o)
                {
                    while (true)
                    {
                        arg1 = *0x6f0a0000;
                        void* temp85_1 = arg1 & 0x250a0000;
                        
                        if (temp85_1 >= 0)
                            break;
                        
                        bool o_17;
                        
                        if (temp85_1 < 0)
                        {
                            while (true)
                            {
                                *0x6af72;
                                *arg1[1] |= *0x6af72;
                                label_1000324a:
                                void* eax_8;
                                eax_8 = __lds_gprz_memp(*arg5);
                                *(eax_8 + 0x28) += *arg2[1];
                                label_1000324f:
                                arg1 = *0x6f0a0000;
                                
                                if ((arg1 & 0x250a0000) >= 0)
                                {
                                    *(esp - 4) = es;
                                    esp -= 4;
                                    arg1[0x72] += *arg2[1];
                                    goto label_10003260;
                                }
                                
                                void* temp0_2 = arg6;
                                arg6 = arg1;
                                arg1 = temp0_2;
                                label_10003231:
                                *(esp - 4) = es;
                                esp -= 4;
                                char temp88_1 = arg1[0x72];
                                arg1[0x72] += *arg2[1];
                                o_17 = temp88_1 + *arg2[1];
                                label_10003235:
                                
                                if (o_17)
                                    break;
                                
                                *arg3[1] |= *(arg6 - 0x57);
                                *arg1 += arg1;
                            }
                            
                            arg1[0x28] += *arg2[1];
                        }
                        else
                        {
                            while (true)
                            {
                                *(esp - 4) = es;
                                esp -= 4;
                                arg1[0x28] += *arg2[1];
                                label_100031fb:
                                arg1 = *0x6f0a0000;
                                *(esp - 4) = es;
                                esp -= 4;
                                char temp90_1 = arg1[0x72];
                                arg1[0x72] += *arg2[1];
                                bool o_16;
                                
                                if (!(temp90_1 + *arg2[1]))
                                {
                                    *arg3[1] |= *(arg6 - 0x57);
                                    *arg1 += arg1;
                                    *0x68172;
                                    *arg1[1] |= *0x68172;
                                    o_16 = false;
                                    goto label_10003220;
                                }
                                
                                arg1[0x28] += *arg2[1];
                                label_10003210:
                                arg1 = *0x6f0a0000;
                                label_100031f0:
                                
                                do
                                {
                                    *(esp - 4) = es;
                                    esp -= 4;
                                    char temp81_1 = arg1[0x72];
                                    arg1[0x72] += *arg2[1];
                                    o_16 = temp81_1 + *arg2[1];
                                    label_10003220:
                                    
                                    if (!o_16)
                                    {
                                        *arg3[1] |= *(arg6 - 0x57);
                                        *arg1 += arg1;
                                        *0x69772;
                                        *arg1[1] |= *0x69772;
                                        o_17 = false;
                                        goto label_10003235;
                                    }
                                    
                                    arg1[0x28] += *arg2[1];
                                    label_10003225:
                                    arg1 = *0x6f0a0000;
                                    
                                    if ((arg1 & 0x250a0000) >= 0)
                                        goto label_10003231;
                                    
                                    label_100031c8:
                                    arg1 = &arg1[0xab727000];
                                    label_100031d2:
                                    arg1[0xa1287000] += (&arg1[0xa1287000]);
                                    *arg3[1] |= *(arg6 - 0x57);
                                    arg1[0xa1287000] += (&arg1[0xa1287000]);
                                    *0x5e772;
                                    *arg1[1] = *(&arg1[0xa1287000])[1] | *0x5e772;
                                    eax_7 = arg1 + *arg5;
                                    label_100031e3:
                                    *(eax_7 + 0x28) += *arg2[1];
                                    label_100031e6:
                                    arg1 = *0x6f0a0000;
                                } while ((arg1 & 0x250a0000) < 0);
                                
                                *(esp - 4) = es;
                                esp -= 4;
                                arg1[0x72] += *arg2[1];
                                ebx -= 1;
                            }
                        }
                    }
                    
                    *(esp - 4) = es;
                    esp -= 4;
                    arg1[0x72] += *arg2[1];
                    goto label_1000324a;
                }
                
                if (!o)
                    goto label_10003264;
                
                while (true)
                {
                    if (!o)
                    {
                        arg1 = *0x6f0a0000;
                        *esp;
                        esp += 2;
                        arg1[0x72] += *arg2[1];
                        goto label_1000329e;
                    }
                    
                    if (o)
                    {
                        if (o)
                        {
                            char temp98_1 = *arg1;
                            *arg1 += arg1;
                            arg5 = arg5 + *arg1;
                            arg1 = arg1;
                            break;
                        }
                        
                        arg1 = *0x6f0a0000;
                    }
                    else
                    {
                        arg1 = *0x6f0a0000;
                        
                        if ((arg1 & 0x250a0000) < 0)
                        {
                            *arg1 += arg1;
                            *0x6d572;
                            *arg1[1] |= *0x6d572;
                            label_10003260:
                            *(esp - 4) = es;
                            esp -= 4;
                            arg1[0x28] += *arg2[1];
                            label_10003264:
                            void* eax_9 = *0x6f0a0000;
                            
                            if ((eax_9 & 0x250a0000) < 0)
                            {
                                *esp;
                                esp += 2;
                            }
                            else
                            {
                                *esp;
                                esp += 2;
                                char temp89_1 = *(eax_9 + 0x72);
                                *(eax_9 + 0x72) += *arg2[1];
                                eax_9 = eax_9 - *arg6;
                            }
                            
                            *(eax_9 + 0x28) += *arg2[1];
                            label_10003279:
                            arg1 = *0x6f0a0000;
                            
                            if ((arg1 & 0x250a0000) < 0)
                                goto label_100032b0;
                            
                            es = *esp;
                            esp += 2;
                            arg1[0x72] += *arg2[1];
                            ebx += 1;
                            char temp105_1 = arg1;
                            char temp106_1 = *arg1;
                            arg1 += *arg1;
                            o = temp105_1 + temp106_1;
                            continue;
                        }
                        else
                        {
                            *esp;
                            esp += 2;
                            arg1[0x72] += *arg2[1];
                            
                            while (true)
                            {
                                *arg6 = arg1;
                                arg6 += 4;
                                *esp;
                                esp += 2;
                                arg1[0x28] += *arg2[1];
                                label_100032cd:
                                arg1 = *0x6f0a0000;
                                
                                if ((arg1 & 0x250a0000) >= 0)
                                    break;
                                
                                *arg1 += arg1;
                                *0x74172;
                                *arg1[1] |= *0x74172;
                                label_1000329e:
                                *(esp - 4) = arg4;
                                *(esp - 4);
                                esp -= 2;
                                arg1[0x28] += *arg2[1];
                                label_100032a3:
                                arg1 = *0x6f0a0000;
                                *esp;
                                esp += 2;
                                label_100032b0:
                                arg1[0x72] += *arg2[1];
                                *arg6 -= 0x5ed79000;
                                *arg1 += arg1;
                                *arg3[1] |= *(arg6 - 0x57);
                                *arg1 += arg1;
                                *0x79172;
                                *arg1[1] |= *0x79172;
                            }
                            
                            es = *esp;
                            esp += 2;
                            char temp114_1 = arg1[0x72];
                            arg1[0x72] += *arg2[1];
                            arg3 -= 1;
                            
                            if (temp114_1 == -(*arg2[1]) || arg3)
                                arg5 = __outsd(arg2, *arg5, arg5, eflags);
                            else
                            {
                                arg1[0x28] += *arg2[1];
                                arg1 = *0x6f0a0000;
                            }
                        }
                    }
                    
                    arg1 = arg1 - *arg1;
                    *(ebx + (arg5 << 1)) += arg1;
                    *arg6 = arg1;
                    arg6 += 1;
                    *arg1 += arg1;
                    arg1 |= arg1[0x400001b];
                    *ebx[1] -= *arg2;
                    arg1 += *ebx;
                    arg1 += 0x28;
                    goto label_10003300;
                }
                
                break;
            }
            
            arg5 = __outsd(arg2, *arg5, arg5, eflags);
            label_10003182:
            
            if ((arg1 & 0x250a0000) >= 0)
            {
                label_10003189:
                eax_5 = &arg1[0x61727000];
                label_10003193:
                eax_5[0xa1287000] += (&eax_5[0xa1287000]);
                *arg3[1] |= *(arg6 - 0x57);
                eax_5[0xa1287000] += (&eax_5[0xa1287000]);
                *0x57172;
                *arg1[1] = *(&eax_5[0xa1287000])[1] | *0x57172;
                *0xa1287000 = arg1;
                label_100031a8:
                *arg1 += arg1;
                *arg3[1] |= *(arg6 - 0x57);
                *arg1 += arg1;
                *0x59972;
                *arg1[1] |= *0x59972;
                *arg6 = arg1;
                arg6 += 4;
                label_100031b8:
                arg1 = &arg1[0xa1287000];
                *arg1 += arg1;
                *arg3[1] |= *(arg6 - 0x57);
                *arg1 += arg1;
                *0x5bb72;
                *arg1[1] |= *0x5bb72;
            }
        }
        else
        {
            char* temp13_1 = arg1;
            int32_t temp14_1 = *arg1;
            arg1 = &arg1[*arg1];
            bool o_6 = temp13_1 + temp14_1;
            label_100030a4:
            
            if (o_6)
            {
                arg5 = __outsd(arg2, *arg5, arg5, eflags);
                goto label_10003119;
            }
            
            int32_t temp29_1 = *ebx;
            *ebx = *ebx;
            c_1 = temp29_1 >= 0;
            o_2 = temp29_1 + 0;
            label_100030a9:
            
            if (o_2)
                goto label_100030d3;
            
            arg1 = *0x6f0a0000;
            
            while (true)
            {
                if ((arg1 & 0x250a0000) >= 0)
                {
                    char* temp37_1 = arg1;
                    int32_t temp38_1 = *arg1;
                    arg1 = &arg1[*arg1];
                    
                    if (temp37_1 + temp38_1)
                    {
                        arg5 = __outsd(arg2, *arg5, arg5, eflags);
                        goto label_1000312e;
                    }
                    
                    int32_t* eax_2 = *arg5;
                    arg5 = &arg5[1];
                    arg1 = eax_2 + *eax_2;
                    o = eax_2 + *eax_2;
                    goto label_100030be;
                }
                
                *0x2df72;
                *arg1[1] |= *0x2df72;
                o_1 = false;
                label_10003050:
                
                if (o_1)
                {
                    arg5 = __outsd(arg2, *arg5, arg5, eflags);
                    goto label_100030c5;
                }
                
                char temp19_1 = arg1;
                char temp20_1 = *arg1;
                arg1 += *arg1;
                c_1 = temp19_1 + temp20_1 < temp19_1;
                o_2 = temp19_1 + temp20_1;
                label_10003055:
                int32_t* eax_1;
                
                if (!o_2)
                {
                    arg1 = *0x6f0a0000;
                    
                    if ((arg1 & 0x250a0000) < 0)
                    {
                        char* temp60_1 = arg1;
                        int32_t temp61_1 = *arg1;
                        arg1 = &arg1[*arg1];
                        o = temp60_1 + temp61_1;
                        goto label_1000306a;
                    }
                    
                    char* temp62_1 = arg1;
                    int32_t temp63_1 = *arg1;
                    arg1 = &arg1[*arg1];
                    
                    if (temp62_1 + temp63_1)
                    {
                        arg5 = __outsd(arg2, *arg5, arg5, eflags);
                        goto label_100030da;
                    }
                    
                    label_1000306c:
                    arg1 = *0x6f0a0000;
                    label_10003071:
                    void* temp3_1 = arg1 & 0x250a0000;
                    
                    if (temp3_1 < 0)
                    {
                        if (temp3_1 >= 0)
                        {
                            char* temp15_1 = arg1;
                            int32_t temp16_1 = *arg1;
                            arg1 = &arg1[*arg1];
                            c_1 = &temp15_1[temp16_1] < temp15_1;
                            o_2 = temp15_1 + temp16_1;
                            goto label_100030a9;
                        }
                        
                        arg1[0x28] += *arg2[1];
                        label_1000302d:
                        arg1 = *0x6f0a0000;
                        
                        if ((arg1 & 0x250a0000) >= 0)
                        {
                            char temp10_1 = arg1;
                            char temp11_1 = *arg1;
                            arg1 += *arg1;
                            
                            if (!(temp10_1 + temp11_1))
                                /* undefined */
                            
                            arg5 = __outsd(arg2, *arg5, arg5, eflags);
                            continue;
                        }
                        
                        char temp8_1 = arg1;
                        char temp9_1 = *arg1;
                        arg1 += *arg1;
                        o = temp8_1 + temp9_1;
                        
                        if (!o)
                        {
                            arg1 = *0x6f0a0000;
                            /* unimplemented  {test eax, 0x250a0000} */
                            char temp25_1 = arg1;
                            char temp26_1 = *arg1;
                            arg1 += *arg1;
                            
                            if (temp25_1 + temp26_1)
                            {
                                arg5 = __outsd(arg2, *arg5, arg5, eflags);
                                goto label_10003071;
                            }
                            
                            ebx += 1;
                            char temp33_1 = arg1;
                            char temp34_1 = *arg1;
                            arg1 += *arg1;
                            c_1 = temp33_1 + temp34_1 < temp33_1;
                            o_2 = temp33_1 + temp34_1;
                            
                            if (o_2)
                            {
                                if (o_2)
                                    goto label_10003055;
                                
                                goto label_1000302d;
                            }
                            
                            eax_1 = *0x6f0a0000;
                            
                            if ((eax_1 & 0x250a0000) < 0)
                                goto label_1000306c;
                            
                            char temp58_1 = eax_1;
                            char temp59_1 = *eax_1;
                            eax_1 += *eax_1;
                            
                            if (temp58_1 + temp59_1)
                            {
                                arg5 = __outsd(arg2, *arg5, arg5, eflags);
                                goto label_10003086;
                            }
                            
                            *arg2;
                            arg1 = nullptr;
                            o = /* o = unimplemented  {imul eax, dword [edx], 0x0} */;
                        }
                        
                        if (o)
                            goto label_10003040;
                        
                        arg1 = *0x6f0a0000;
                        
                        if ((arg1 & 0x250a0000) < 0)
                        {
                            arg1 &= 0x36972;
                            o_6 = false;
                            goto label_100030a4;
                        }
                        
                        char temp31_1 = arg1;
                        char temp32_1 = *arg1;
                        arg1 += *arg1;
                        
                        if (temp31_1 + temp32_1)
                        {
                            arg5 = __outsd(arg2, *arg5, arg5, eflags);
                            goto label_1000309b;
                        }
                        
                        *0x28700002;
                        goto label_1000302d;
                    }
                    else
                    {
                        char* temp6_1 = arg1;
                        int32_t temp7_1 = *arg1;
                        arg1 = &arg1[*arg1];
                        
                        if (temp6_1 + temp7_1)
                        {
                            arg5 = __outsd(arg2, *arg5, arg5, eflags);
                            goto label_100030ef;
                        }
                        
                        arg3 = &arg3[1];
                        char* temp17_1 = arg1;
                        int32_t temp18_1 = *arg1;
                        arg1 = &arg1[*arg1];
                        c_1 = &temp17_1[temp18_1] < temp17_1;
                        o_2 = temp17_1 + temp18_1;
                    }
                }
                
                if (o_2)
                    goto label_100030a9;
                
                eax_1 = *0x6f0a0000;
                label_10003086:
                
                if ((eax_1 & 0x250a0000) < 0)
                {
                    arg1 = eax_1 & 0x3e772;
                    o_9 = false;
                    break;
                }
                
                arg1 = eax_1 + *eax_1;
                o_5 = eax_1 + *eax_1;
                goto label_1000308f;
            }
            
            label_100030e3:
            bool o_14;
            
            if (!o_9)
            {
                es = *esp;
                esp += 2;
                char temp76_1 = arg1;
                arg1 = arg1;
                o = temp76_1 + 0;
                label_100030e8:
                
                if (o)
                    goto label_10003112;
                
                arg1 = *0x6f0a0000;
                label_100030ef:
                char temp27_1 = arg1;
                arg1 = arg1;
                
                if (!(temp27_1 + 0))
                {
                    char temp0_1;
                    temp0_1 = __das(arg1, eflags);
                    arg1 = temp0_1;
                    char temp40_1 = arg1;
                    arg1 = arg1;
                    c_1 = temp40_1 >= 0;
                    o_2 = temp40_1 + 0;
                    label_100030fd:
                    
                    if (o_2)
                        goto label_10003127;
                    
                    arg1 = *0x6f0a0000;
                    label_10003104:
                    
                    if ((arg1 & 0x250a0000) < 0)
                    {
                        label_1000314a:
                        char temp49_1 = arg1;
                        arg1 = arg1;
                        
                        if (!(temp49_1 + 0))
                        {
                            if (!arg3)
                            {
                                *arg1 += arg1;
                                *arg3[1] |= *(arg6 - 0x57);
                                *arg1 += arg1;
                                *0x4f372;
                                *arg1[1] |= *0x4f372;
                                o_14 = false;
                                goto label_10003161;
                            }
                            
                            arg1[0x28] += *arg2[1];
                            label_10003153:
                            arg1 = *0x6f0a0000;
                            goto label_1000315d;
                        }
                        
                        arg5 = __outsd(arg2, *arg5, arg5, eflags);
                        label_100031c1:
                        
                        if ((arg1 & 0x250a0000) >= 0)
                            goto label_100031c8;
                        
                        *arg1 += arg1;
                        *0x54372;
                        *arg1[1] |= *0x54372;
                        arg6 = *esp;
                        arg5 = *(esp + 4);
                        arg4 = *(esp + 8);
                        ebx = *(esp + 0x10);
                        arg2 = *(esp + 0x14);
                        arg3 = *(esp + 0x18);
                        eax_5 = *(esp + 0x1c);
                        esp += 0x20;
                        goto label_10003193;
                    }
                    
                    goto label_1000310b;
                }
                
                arg5 = __outsd(arg2, *arg5, arg5, eflags);
                label_1000316d:
                
                if ((arg1 & 0x250a0000) < 0)
                {
                    arg3[0x6f0a0000] -= *arg1[1];
                    label_10003197:
                    
                    if ((arg1 & 0x250a0000) >= 0)
                    {
                        arg1 = &arg1[0x2a9ae000];
                        goto label_100031a8;
                    }
                    
                    arg3[0x6f0a0000] -= *arg1[1];
                    goto label_100031f0;
                }
                
                void* eax_4 = &arg1[0x1d727000];
                int32_t temp65_1 = *eax_4;
                arg1 = eax_4 + *eax_4;
                c_1 = eax_4 + temp65_1 < eax_4;
                o_2 = eax_4 + temp65_1;
                label_1000317b:
                
                if (!o_2)
                {
                    arg1 = *0x6f0a0000;
                    goto label_10003182;
                }
                
                if (!o_2)
                {
                    arg1 = *0x6f0a0000;
                    label_100031ac:
                    arg1 = &arg1[0xab727000];
                    goto label_100031b8;
                }
                
                if (!o_2)
                {
                    arg1 = *0x6f0a0000;
                    goto label_100031d6;
                }
                
                if (!o_2)
                    goto label_100031fb;
                
                if (!o_2)
                    goto label_10003225;
                
                if (!o_2)
                    goto label_1000324f;
                
                if (!o_2)
                    goto label_10003279;
                
                if (!o_2)
                    goto label_100032a3;
                
                if (!o_2)
                    goto label_100032cd;
                
                *ebx = *ebx - 0;
                *(arg2 + arg4) += arg1;
                *arg2;
                arg1 = &arg1[*(arg1 + arg4)];
                label_10003300:
                *arg6 = arg1;
                arg6 += 4;
                *arg1 += arg1;
                ebx |= *arg1;
                void* temp0_3 = esp;
                esp = arg1;
                arg1 = temp0_3 + 0x2a02fe;
                *ebx += arg2;
                *(arg1 * 2) ^= arg1;
                break;
            }
            
            arg5 = __outsd(arg2, *arg5, arg5, eflags);
            label_1000315d:
            
            while ((arg1 & 0x250a0000) < 0)
                arg3[0x6f0a0000] -= *arg1[1];
            
            char temp84_1 = arg1;
            arg1 = arg1;
            o_14 = temp84_1 + 0;
            label_10003161:
            
            if (!o_14)
                goto label_10003168;
            
            arg5 = __outsd(arg2, *arg5, arg5, eflags);
            label_100031d6:
            
            if ((arg1 & 0x250a0000) >= 0)
            {
                eax_7 = &arg1[0x13727000];
                *(esp - 4) = es;
                esp -= 4;
                goto label_100031e3;
            }
            
            *0x5bb72;
            *arg1[1] |= *0x5bb72;
        }
        *arg6 = arg1;
        arg6 += 4;
        goto label_100031d2;
    }
    
    char temp0_4;
    temp0_4 = __das(arg1, eflags);
    arg1 = temp0_4;
    *arg1 += arg1;
    *arg6 += arg3;
    char temp99_1 = *arg1;
    *arg1 += arg1;
    *arg2 = *arg2 + arg1;
    void* eax_11 = &arg1[*(arg1 + arg4)];
    *arg6 = eax_11;
    arg6 += 4;
    *eax_11 += eax_11;
    *arg2;
    arg3 |= *arg2;
    *(esp - 4) = es;
    *(arg4 + eax_11 - 0x72e6ecce) = *(arg4 + eax_11 - 0x72e6ecce) - arg2;
    *0x25010000 = eax_11;
    int16_t ss;
    *(esp - 8) = ss;
    esp -= 8;
    ebx += *(arg5 - 0x61fce8db);
    arg1 = eax_11 & 0x2a9e0418;
    *(esp - 4) = es;
    *(esp - 8) = ss;
    *(arg1 - 4) = es;
    ss = *(arg1 - 4);
    esp -= 8;
    *arg3[1] |= *arg2;
    *arg2 = 0x16;
    int32_t eax_15;
    arg2 = HIGHD(&arg1[0xac26]);
    eax_15 = LOWD(&arg1[0xac26]);
    arg1 = eax_15 & *eax_15;
    *arg1 += arg1;
    char temp102 = *arg1;
    *arg1 += arg1;
    char* ecx = arg3 - 1;
    
    if (temp102 != -(arg1) && ecx)
        goto label_100033c2;
    
    arg2 = *esp;
    void* esp_9 = esp + 4;
    char* eax_16 = *arg2 * 0x239917;
    *eax_16 += eax_16;
    char temp108_1 = *eax_16;
    *eax_16 += eax_16;
    ecx -= 1;
    void* eax_22;
    void* eax_25;
    
    if (temp108_1 != -(eax_16) && ecx)
    {
        eax_25 = eax_16 & 0x94170617;
        label_100033d5:
        uint8_t temp0_11;
        temp0_11 = __insb(arg6, arg2, eflags);
        *arg6 = temp0_11;
        eax_22 = eax_25 & *eax_25;
        *eax_22 += eax_22;
        char temp115_1 = *eax_22;
        *eax_22 += eax_22;
        ecx -= 1;
        
        if (temp115_1 == -(eax_22) || !ecx)
            goto label_100033df;
    }
    else
    {
        arg2 = *esp_9;
        esp_9 += 4;
        char* eax_17 = *arg2 * 0x239918;
        *eax_17 += eax_17;
        char temp109_1 = *eax_17;
        *eax_17 += eax_17;
        ecx -= 1;
        void* eax_21;
        void* esp_21;
        
        if (temp109_1 != -(eax_17) && ecx)
        {
            label_100033df:
            ebx = *esp_9;
            void* esp_20 = esp_9 + 4;
            esp_9 = *0x18061825;
            uint8_t temp0_13;
            temp0_13 = __insb(arg6, arg2, eflags);
            *arg6 = temp0_13;
            eax_22 = esp_20 & *esp_20;
            *eax_22 += eax_22;
            char temp116_1 = *eax_22;
            *eax_22 += eax_22;
            ecx -= 1;
            
            if (temp116_1 != -(eax_22) && ecx)
                goto label_1000345e;
            
            ebx = *esp_9;
            esp_21 = esp_9 + 4;
            int32_t eax_29;
            int32_t* edx_3;
            edx_3 = HIGHD(*0x19021925);
            eax_29 = LOWD(*0x19021925);
            int32_t* eax_30 = *0x2a;
            arg5 = arg5 + *eax_30;
            eax_21 = &eax_30[0x8c0];
            *eax_21 += edx_3;
            char temp122_1 = *eax_21;
            *eax_21 += eax_21;
            *edx_3 = *edx_3 + eax_21;
            *arg5 -= ecx;
            goto label_1000340b;
        }
        
        int32_t* edx = *esp_9;
        int32_t* eax_18 = *ebx * 0x2b28;
        *esp_9 = es;
        eax_18 -= *eax_18;
        char temp117_1 = *eax_18;
        *eax_18 += eax_18;
        arg5 = arg5 + *eax_18;
        *arg6 += ecx;
        char temp118_1 = eax_18[0x1c40];
        eax_18[0x1c40] += (&eax_18[0x1c40]);
        *edx = *edx + &eax_18[0x1c40];
        *(esp_9 - 4) = ss;
        int32_t eax_20;
        char edx_1;
        edx_1 = HIGHD(&eax_18[0x1c40]);
        eax_20 = LOWD(&eax_18[0x1c40]);
        eax_21 = eax_20 & *eax_20;
        *eax_21 += eax_21;
        char temp119_1 = *eax_21;
        *eax_21 += eax_21;
        void* esp_13;
        void* esp_14;
        void* esp_18;
        
        if (temp119_1 != -(eax_21) && ecx != 1)
        {
            char temp123_1 = *eax_21;
            *eax_21 += eax_21;
            *eax_21 = *eax_21 + eax_21;
            *(ecx - 1) += edx_1;
            *ecx[1] = *(ecx - 1)[1] + *eax_21;
            int16_t cs;
            *(esp_9 - 8) = cs;
            esp_21 = esp_9 - 8;
            label_1000340b:
            *eax_21 += eax_21;
            *(esp_21 - 4) = es;
            esp_13 = esp_21 - 4;
            arg4 = &arg4[*eax_21];
            label_10003410:
            *(cs + eax_21) += eax_21;
            *(esp_13 - 4) = es;
            eax_21 |= *arg5;
            *(esp_13 - 8) = ss;
            esp_14 = esp_13 - 8;
            *arg5;
            *arg5;
            arg2 = HIGHD(*arg5 * 0x19);
            eax_22 = LOWD(*arg5 * 0x19);
            label_10003424:
            arg5 = nullptr;
            *arg2 += ecx;
            ecx -= arg2[0x72];
            __int1();
            es = *esp_14;
            esp_18 = esp_14 + 2;
            *(eax_22 + 2) += *arg2[1];
            *0x30a0000 -= *ecx[1];
            *(arg6 + 0x2a0a0000) -= *ecx[1];
            goto label_1000343e;
        }
        
        esp_13 = esp_9;
        eax_21 = **(esp_9 - 4) * 0x239917;
        *eax_21 += eax_21;
        char temp124_1 = *eax_21;
        *eax_21 += eax_21;
        ecx -= 2;
        
        if (temp124_1 != -(eax_21) && ecx)
            goto label_10003410;
        
        arg2 = *esp_13;
        esp_14 = esp_13 + 4;
        eax_22 = *arg2 * 0x239918;
        *eax_22 += eax_22;
        char temp127_1 = *eax_22;
        *eax_22 += eax_22;
        ecx -= 1;
        
        if (temp127_1 != -(eax_22) && ecx)
        {
            ecx[0x9919066b] = ecx[0x9919066b] - ebx;
            goto label_10003424;
        }
        
        arg2 = *esp_14;
        arg1 = *ebx * 0x2c28;
        *esp_14 = es;
        ebx |= *arg2;
        *(arg1 * 2 + 0x162500fc) = es;
        esp = arg1 * 2 + 0x162500fc;
        label_100033c2:
        *(esp - 4) = ss;
        esp_18 = arg1;
        uint8_t temp0_9;
        temp0_9 = __insb(arg6, arg2, eflags);
        *arg6 = temp0_9;
        eax_22 = (esp - 4) & *(esp - 4);
        *eax_22 += eax_22;
        char temp107_1 = *eax_22;
        *eax_22 += eax_22;
        ecx -= 1;
        
        if (temp107_1 == -(eax_22) || !ecx)
        {
            ebx = *esp_18;
            esp_9 = *0x17061725;
            eax_25 = esp_18 + 4;
            goto label_100033d5;
        }
        
        *ecx[1] |= *arg2;
        label_1000343e:
        *(esp_18 - 4) = ds;
        esp_9 = esp_18 - 4;
        *ecx[1] += *eax_22;
        eax_22 = 0;
        *arg2 += ecx;
        eax_22 = 0 - *eax_22;
        *ebx += ebx;
        *ebx ^= eax_22;
        ecx += *eax_22[1];
    }
    *eax_22 += eax_22;
    *ecx += arg2;
    char temp120_1 = *eax_22;
    *eax_22 += eax_22;
    *arg2 = *arg2 + eax_22;
    arg5 = __outsd(arg2, *arg5, arg5, eflags);
    
    while (true)
    {
        *eax_22 += eax_22;
        *ecx[1] |= *(arg6 - 0x4f);
        *eax_22 += eax_22;
        label_1000345e:
        *ebx[1] |= *(arg5 - 0x32);
        *eax_22 += eax_22;
        eax_22 += 0x25;
        *(eax_22 + 0x3281d9e9) += (eax_22 + 0x3281d9e9);
        void* eax_37;
        eax_37 = (eax_22 + 0x3281d9e9) - 2;
        *(esp_9 - 4) = es;
        arg2 = 0;
        *arg2 += ecx;
        void* eax_38;
        eax_38 = (eax_37 & 0xce80) + 0x28;
        *(esp_9 - 4);
        *eax_38 += eax_38;
        arg6 -= *(arg5 - 0x31);
        *eax_38 += eax_38;
        eax_38 += 0x25;
        *(eax_38 + 0x3281d9e9) += (eax_38 + 0x3281d9e9);
        eax_22 = (eax_38 + 0x3281d9e9) - 2;
        *(esp_9 - 6) = es;
        int32_t temp121_1 = *eax_22;
        *eax_22 += eax_22;
        *(esp_9 - 0xa) = es;
        esp_9 -= 0xa;
        
        if (temp121_1 + eax_22 < temp121_1)
            break;
        
        char temp128_1 = *eax_22;
        *eax_22 += eax_22;
        *eax_22 = *eax_22 + eax_22;
        *(ecx - 1) = *(ecx - 1);
        *ecx[1] = *(ecx - 1)[1] + *(arg6 + 0x42);
    }
    
    *eax_22 += eax_22;
    *eax_22[1] |= *0xcf80;
    eax_22 += 0x28;
    *eax_22 &= eax_22;
    *ebx += *ecx[1];
    *ecx -= *eax_22[1];
    *eax_22 += eax_22;
    char ecx_1 = ecx - *arg2;
    *(esp_9 - 4) = es;
    __outsd(arg2, *arg5, arg5, eflags);
    *eax_22[1] = 0;
    *arg2 += ecx_1;
    *ebx;
    eax_22 = eax_22 - 0x12;
    *eax_22 += arg4 | *ebx;
    *arg2 = *arg2;
    void* eax_39;
    eax_39 = (eax_22 & 0xcc7b) + 0x28;
    eax_39 &= *eax_39;
    *ebx = *ebx;
    *(arg6 + 0x7d0a0000) -= *arg2[1];
    breakpoint();
}

int32_t __convention("regparm") sub_100036c4(int32_t* arg1, char* arg2, char* arg3, int32_t arg4 @ ebp, uint16_t* arg5 @ esi, char* arg6 @ edi)
{
    int16_t ss;
    uint32_t var_4 = ss;
    uint32_t* esp = &var_4;
    
    while (true)
    {
        *arg1 -= arg1;
        char* ebx;
        *ebx += ebx;
        int32_t eflags;
        arg5 = __outsd(arg2, *arg5, arg5, eflags);
        char* eax = arg1 ^ 0xdc0a0000;
        int16_t es;
        *(esp - 4) = es;
        void* esp_1 = esp - 4;
        
        if (eax <= 0)
            break;
        
        while (true)
        {
            *eax += eax;
            eax += 0x25;
            *(eax + 0x3281d9e9) += (eax + 0x3281d9e9);
            void* eax_1;
            eax_1 = (eax + 0x3281d9e9) - 2;
            *(esp_1 - 4) = es;
            arg3 -= 1;
            int32_t temp0_1 = *eax_1;
            *eax_1 += eax_1;
            *(esp_1 - 8) = es;
            esp_1 -= 8;
            
            if (temp0_1 + eax_1 >= temp0_1)
            {
                *arg2 += arg3;
                void* eax_3;
                eax_3 = (eax_1 & 0xcc7b) + 0x28;
                eax_3 &= *eax_3;
                *ebx += *arg3[1];
                goto label_100036ac;
            }
            
            *eax_1 += eax_1;
            *eax_1[1] |= *0xda80;
            eax_1 += 0x28;
            eax = eax_1 & *eax_1;
            char temp1_1 = *ebx;
            *ebx += *arg3[1];
            
            if (temp1_1 > -(*arg3[1]))
            {
                *eax += eax;
                eax += 0x25;
                *(eax + 0x3281d9e9) += (eax + 0x3281d9e9);
                arg1 = (eax + 0x3281d9e9) - 2;
                *(esp_1 - 4) = es;
                arg2 -= 1;
                int32_t temp2_1 = *arg1;
                *arg1 += arg1;
                *(esp_1 - 8) = es;
                esp = esp_1 - 8;
                
                if (temp2_1 + arg1 >= temp2_1)
                    break;
                
                *arg1 += arg1;
                *arg1[1] |= *0xdc80;
                arg1 += 0x28;
                arg1 = 0;
                *ebx += *arg3[1];
                arg1 = 0 - *arg1;
                *arg1 += arg1;
                *arg1 = &arg2[*arg1];
                *arg1 += arg1;
                arg1 += *arg1;
                *(esp - 4) = arg1;
                *(esp - 8) = arg3;
                *(esp - 0xc) = arg2;
                *(esp - 0x10) = ebx;
                *(esp - 0x14) = esp - 0x10;
                *(esp - 0x18) = arg4;
                *(esp - 0x1c) = arg5;
                *(esp - 0x20) = arg6;
                *arg3 += *arg3[1];
                *arg1 = arg1;
                int16_t cs;
                *(esp - 0x24) = cs;
                *arg1 += arg1;
                char temp3 = *arg1;
                *arg1 += arg1;
                char* esi = arg5 + *arg1;
                *arg1 |= arg1;
                int32_t ebp = *(esp - 0x24);
                *arg1 += arg1;
                *ebx += arg2;
                char temp4 = *arg1;
                *arg1 += arg1;
                *(ebx + 0x50) = *(ebx + 0x50) + esi;
                *arg1 += arg1;
                *(esp - 0x24) = es;
                void* esp_7 = esp - 0x24;
                *arg2;
                arg1 |= *arg2;
                bool p = /* bool p = unimplemented  {or al, byte [edx]} */;
                
                if (!p)
                {
                    *arg1 += arg1;
                    *(esp_7 - 4) = es;
                    esp_7 -= 4;
                }
                else
                {
                    *arg1 += arg1;
                    arg1 += 0x2c;
                    char* eax_2 = arg1 | 0x1c7b02;
                    eax_2[ebp] += eax_2;
                    eax_2 = eax_2;
                    *ebx += *arg3[1];
                    arg1 = (eax_2 - 0x28030227) ^ *(eax_2 - 0x28030227);
                    *esi += arg1;
                    ebp += *arg1;
                    arg1 = arg1;
                    *esi += arg1;
                }
                
                *0x32b0000 -= *arg3[1];
                *ebx -= *arg2[1];
                *arg1 += arg1;
                *(esp_7 - 4) = es;
                void* esp_8 = esp_7 - 4;
                
                while (true)
                {
                    *0x282b0000 -= *arg3[1];
                    arg1 = arg1;
                    char temp7_1 = *ebx;
                    *ebx += *arg3[1];
                    bool p_1 = /* bool p_1 = unimplemented  {add byte [ebx], ch} */;
                    
                    if (temp7_1 + *arg3[1] < 0 == temp7_1 + *arg3[1])
                    {
                        *(esp_8 - 4) = es;
                        esp_8 -= 4;
                        
                        if (p_1)
                            goto label_10003796;
                        
                        arg1 = arg1 - 0;
                        *(esi + arg1) += arg1;
                        goto label_1000377b;
                    }
                    
                    *arg1 += arg1;
                    arg1 += 6;
                    label_1000377b:
                    arg1 += 0x6f;
                    *arg1 = 0xe07d0a00;
                    *arg1 += arg1;
                    arg1 += 6;
                    bool p_2 = /* bool p_2 = unimplemented  {add al, 0x6} */;
                    
                    if (p_2)
                    {
                        *arg1 += arg1;
                        arg1 += 0x28;
                        /* unimplemented  {enter 0x0, 0xa} */
                        arg1 -= 0xe07b060e;
                        label_10003796:
                        *arg1 += arg1;
                        arg1 += 0x6f;
                        *arg1 += arg1;
                        arg2 |= *arg6;
                        *esi ^= arg1;
                        *esi -= *arg3[1];
                        *arg1 += arg1;
                        int32_t* ebp_1 = ebp - *arg2;
                        arg1 += 0x1f;
                        arg6[0xffffffca];
                        *arg1 += arg1;
                        *ebx[1] |= *arg3;
                        *ebp_1;
                        *arg1 += arg1;
                        *(arg6 + ebx) += arg1;
                        *arg3[1] -= arg6[0xffffffca];
                        *arg1 += arg1;
                        *arg3[1] |= arg2[esi << 1];
                        *(arg6 + 0x42);
                        *arg1 += arg1;
                        arg1 |= ebx[esi << 1];
                        /* undefined */
                    }
                    
                    *esi += arg1;
                }
            }
        }
    }
    
    label_100036ac:
    arg6[0x7d0a0000] -= *arg2[1];
    breakpoint();
}

int32_t __convention("regparm") sub_10003baf(char* arg1, char* arg2, int32_t* arg3, void* arg4 @ ebp, uint16_t* arg5 @ esi, void* arg6 @ edi)
{
    *arg1 += arg1;
    *arg2[1] |= arg2[0xffffff85];
    *arg1;
    *arg1 |= arg1;
    bool p = /* bool p = unimplemented  {or byte [eax], al} */;
    int32_t eflags;
    arg5 = __outsd(arg2, *arg5, arg5, eflags);
    arg1 = 0x120a3bbe();
    
    if (p)
    {
        *arg1 += arg1;
        *arg2[1] |= arg2[0xffffff9f];
        *arg1;
        *arg1 |= arg1;
        /* undefined */
    }
    
    *arg1;
    *arg1 |= arg1;
    *arg1 += arg1;
    *arg1 += arg1;
    __outsd(arg2, *arg5, arg5, eflags);
    /* jump -> 0x120a3bad */
}

int32_t __convention("regparm") sub_1000931d(char* arg1, char arg2, char arg3, int64_t* arg4 @ ebp, char* arg5 @ esi, char* arg6 @ edi, int64_t arg7 @ st7, long double arg8 @ st0, int16_t arg9, uint32_t arg10, uint32_t arg11)
{
    *arg6;
    char* ebx;
    ebx |= *arg6;
    arg1 = arg1 - *arg1;
    int16_t cs;
    uint32_t var_2 = cs;
    *arg5 += *arg1[1];
    arg6[0xf] |= arg2;
    arg1 |= *arg1;
    uint32_t* var_6 = &var_2;
    
    if (arg1 < 0)
    {
        arg1 |= *arg1;
        __psubusb_mmxq_memq(arg7, *arg4);
        int64_t* eax;
        eax = arg4 | *arg4;
        int32_t eflags_1;
        char temp0_2;
        char temp1;
        temp0_2 = __aam_immb(0x29, eax);
        eax = temp0_2;
        *eax[1] = temp1;
        int32_t eflags_2;
        char temp0_3;
        char temp1_1;
        temp0_3 = __aas(eax, *eax[1], eflags_1);
        eax = temp0_3;
        *eax[1] = temp1_1;
        void* eax_1;
        eax_1 = (eax + 1) | *(eax + 1);
        arg5[0x3f] += 1;
        int16_t es;
        int16_t var_a = es;
        char* var_c;
        *(arg1 - 0x58fff9d8) |= &*var_c[2];
        var_c = arg6;
        __clts();
        *ebx += ebx;
        *(arg1 + 0x1e000a28);
        /* undefined */
    }
    
    arg2 += 7 + 1;
    arg1 -= 0xbe;
    *arg5 &= arg2;
    char temp3 = *arg5;
    *arg5 += arg2;
    bool c_1 = /* bool c_1 = unimplemented  {sbb eax, 0xa386b} */;
    uint32_t esi = var_2;
    uint32_t arg_e;
    char* edx = arg_e;
    uint32_t ecx_2 = arg10;
    char* eax_4 = arg11;
    void arg_1a;
    void* esp_1 = &arg_1a;
    
    if (arg1 - 0xa386b < 0)
    {
        eax_4 = eax_4 + *eax_4;
        arg11 = cs;
        char temp5_1 = var_6[-0xebffc79];
        bool p_1 = /* bool p_1 = unimplemented  {cmp dl, byte [edi-0x3afff1e4]} */;
        bool a_1 = /* bool a_1 = unimplemented  {cmp dl, byte [edi-0x3afff1e4]} */;
        arg10 = var_6;
        *eax_4;
        *eax_4;
        bool c_2 = /* bool c_2 = unimplemented  {imul eax, dword [eax]} */;
        int32_t eax_5;
        *eax_5[1] = (edx - temp5_1 < 0 ? 1 : 0) << 7 | (edx == temp5_1 ? 1 : 0) << 6
            | (a_1 ? 1 : 0) << 4 | (p_1 ? 1 : 0) << 2 | (c_2 ? 1 : 0);
        char* eax_6 = eax_5 ^ *eax_5;
        *edx += ecx_2;
        *(__return_addr + 0xa2b7932) += ecx_2;
        *eax_6 += *ecx_2[1];
        int16_t es_2 = *arg10[2];
        arg10 = es_2;
        *ecx_2[1] *= 2;
        *(var_6 + 0xf) |= edx;
        eax_4 = (eax_6 - 1) | *(eax_6 - 1);
        eax_4 = 0x20;
        *eax_4;
        arg_e = es_2;
        esp_1 = &arg_e;
    }
    
    *ecx_2 += eax_4;
    int16_t ds_1 = *esp_1;
    *var_6 = *esi;
    void* edi_1 = &var_6[1];
    char* esi_1 = esi + 4;
    *esi_1 -= eax_4;
    esi_1[0x19] += *arg9[1];
    *edi_1 = *esi_1;
    void* edi_2 = edi_1 + 4;
    void* esi_2 = &esi_1[4];
    char temp8 = *edi_2;
    *edi_2 -= *edx[1];
    bool p_2 = /* bool p_2 = unimplemented  {sub byte [edi], dh} */;
    bool a_2 = /* bool a_2 = unimplemented  {sub byte [edi], dh} */;
    *eax_4[1] = (temp8 - *edx[1] < 0 ? 1 : 0) << 7 | (temp8 == *edx[1] ? 1 : 0) << 6
        | (a_2 ? 1 : 0) << 4 | (p_2 ? 1 : 0) << 2 | (temp8 < *edx[1] ? 1 : 0);
    char* eax_7 = eax_4 ^ *eax_4;
    *edx += ecx_2;
    *(__return_addr + 0x36) += *ecx_2[1];
    int16_t es_3 = *(esp_1 + 2);
    *esp_1 = ds_1;
    ecx_2 *= 2;
    int32_t temp9 = *(esi_2 + __return_addr + 0x4248000a) | ecx_2;
    *(esi_2 + __return_addr + 0x4248000a) = temp9;
    
    if (temp9 >= 0)
    {
        *esi_2 += ecx_2;
        /* undefined */
    }
    
    eax_7 |= *eax_7;
    int32_t eflags;
    __out_dx_oeax(edx, eax_7, eflags);
    void* eax_9 = eax_7 & 0x22b79;
    *(eax_9 + 0x31) += edx;
    int32_t eflags_3;
    char temp0_4;
    char temp1_2;
    temp0_4 = __aas(eax_9, *eax_9[1], eflags);
    eax_9 = temp0_4;
    *eax_9[1] = temp1_2;
    *(esp_1 - 4) = es_3;
    *(ecx_2 + 0xa28a507) += ecx_2;
    *0xa403f28 += ecx_2;
    edx[0x18] += *ecx_2[1];
    int32_t eflags_4;
    char temp0_5;
    char temp1_3;
    temp0_5 = __aas((eax_9 + 1), *(eax_9 + 1)[1], eflags_3);
    void* eax_10;
    eax_10 = temp0_5;
    *eax_10[1] = temp1_3;
    void* eax_11;
    eax_11 = (eax_10 + 1) | *(eax_10 + 1);
    *(esp_1 - 8) = cs;
    /* undefined */
}

int32_t __convention("regparm") sub_100093ea(void* arg1, char* arg2, void* arg3, void* arg4 @ ebp, int32_t* arg5 @ esi, int32_t* arg6 @ edi, long double arg7 @ st0)
{
    int32_t eflags;
    int32_t eflags_25;
    char temp0_31;
    char temp1_21;
    temp0_31 = __aas(arg1, *arg1[1], eflags);
    arg1 = temp0_31;
    *arg1[1] = temp1_21;
    int16_t es;
    uint32_t var_4 = es;
    char* ebx;
    *(arg4 + 0x1a) += *ebx[1];
    *arg6 = *arg5;
    void* edi = &arg6[1];
    void* esi = &arg5[1];
    *arg2 -= arg3;
    *(arg1 + 0xa403f0e) += *(arg1 + 1)[1];
    *(arg1 + 1) += *(arg1 + 1)[1];
    *edi &= edi;
    void* eax_1;
    eax_1 = (arg1 + 2) | *(arg1 + 2);
    *eax_1[1] |= *0x638d8;
    int16_t ss;
    uint32_t var_8 = ss;
    eax_1 |= 0xa5;
    *esi -= eax_1;
    arg2[0xa28a507] += eax_1;
    *(arg3 + 0x638d80f) += ebx;
    *ebx += ebx;
    *(arg4 + 0x4d005328) -= &var_8;
    eax_1 -= *eax_1;
    char temp1 = ebx[1];
    ebx[1] += arg2;
    bool p = /* bool p = unimplemented  {add byte [ebx+0x1], dl} */;
    bool a = /* bool a = unimplemented  {add byte [ebx+0x1], dl} */;
    *eax_1[1] = (temp1 + arg2 < 0 ? 1 : 0) << 7 | (temp1 == -(arg2) ? 1 : 0) << 6 | (a ? 1 : 0) << 4
        | (p ? 1 : 0) << 2 | (temp1 + arg2 < temp1 ? 1 : 0);
    char* eax_2 = eax_1 ^ *eax_1;
    *ebx += arg2;
    *(edi + 0x6000033) = &ebx[*(edi + 0x6000033)];
    char temp2 = *eax_2;
    *eax_2 += eax_2;
    int16_t* esp = &var_8 - *(arg4 + 0x15000628);
    *eax_2[1] -= *(arg4 + 0x15000628);
    int16_t ds = *esp;
    ebx = 0x35;
    *(esp - 2) = es;
    char temp3 = *ebx[1];
    char temp4 = *ebx[1];
    *ebx[1] *= 2;
    *(arg4 - 0x27fff9d8) = *(arg4 - 0x27fff9d8) + esp - 2;
    char temp5 = *(arg4 - 0x20fff9d8);
    *(arg4 - 0x20fff9d8) -= *eax_2[1];
    char* eax_4 = *(eax_2 - 0xa28a5 + 0x3f) * 0x40;
    eax_4 |= *eax_4;
    int32_t eflags_1;
    char temp0_1;
    char temp1_1;
    temp0_1 = __aas(ebx, *ebx[1], eflags_25);
    char* eax_5;
    eax_5 = temp0_1;
    *eax_5[1] = temp1_1;
    *(esp - 6) = es;
    arg2[0x17] += *(&eax_5[1])[1];
    int32_t eax_8;
    char* edx;
    edx = HIGHD((&eax_5[1] ^ 0x6403f) * *edi);
    eax_8 = LOWD((&eax_5[1] ^ 0x6403f) * *edi);
    *(esp - 0xa) = eax_8;
    *(esp - 0xe) = arg3;
    *(esp - 0x12) = edx;
    *(esp - 0x16) = &eax_4[1];
    *(esp - 0x1a) = esp - 0x16;
    *(esp - 0x1e) = arg4;
    *(esp - 0x22) = esi;
    *(esp - 0x26) = edi;
    *(esp - 0x2a) = es;
    char temp6 = *esi;
    *esi += *eax_8[1];
    int32_t esp_6 = esp - 0x2a - *(arg4 - 0x3bfff9d8);
    bool c_5 = /* bool c_5 = unimplemented  {sbb esp, dword [ebp-0x3bfff9d8]} */;
    int32_t* eax_9 = eax_8 - 0x635b3;
    *edx[1] = 0x26;
    char* edi_1 = *eax_9 * 0xa;
    *(eax_9 + 0x41) += *eax_9[1];
    int32_t eflags_2;
    char temp0_2;
    char temp1_2;
    temp0_2 = __aas(eax_9, *eax_9[1], eflags_1);
    eax_9 = temp0_2;
    *eax_9[1] = temp1_2;
    *(esp_6 - 4) = es;
    *(arg4 + 0x635b31a) += *(&eax_4[2])[1];
    void* ebx_3;
    *ebx_3[1] = *(&eax_4[2])[1] + *(eax_9 + 1)[1];
    *(ebx_3 + 0xf000635) ^= esi;
    void* ebp = arg4 - *(ebx_3 + 0x38);
    *(esp_6 - 8) = es;
    void* eax_10;
    eax_10 = (eax_9 + 1) + *(eax_9 + 1)[1];
    int32_t eflags_3;
    char temp0_3;
    temp0_3 = __das(eax_10, eflags_2);
    eax_10 = temp0_3;
    ebx_3 = 0x35;
    *(esp_6 - 0xc) = es;
    *edx += arg3;
    *(esp_6 - 0x10) = ds;
    int32_t eflags_4;
    char temp0_4;
    temp0_4 = __daa(eax_10, eflags_3);
    eax_10 = temp0_4;
    eax_10 ^= 0xa;
    edi_1[0x23] += 0x35;
    int32_t eflags_5;
    char temp0_5;
    char temp1_3;
    temp0_5 = __aas(eax_10, *eax_10[1], eflags_4);
    eax_10 = temp0_5;
    *eax_10[1] = temp1_3;
    void* eax_11;
    eax_11 = (eax_10 + 1) | *(eax_10 + 1);
    *edi_1 |= *ebx_3[1];
    void* eax_13;
    eax_13 = eax_11 | *eax_11;
    uint64_t* edx_1 = *(esp_6 - 0x10);
    void* esp_11 = esp_6 - 0xc;
    int32_t eflags_6;
    char temp0_6;
    temp0_6 = __das(eax_13, eflags_5);
    eax_13 = temp0_6;
    int32_t eflags_7;
    char temp0_7;
    char temp1_4;
    temp0_7 = __aas(eax_13, *eax_13[1], eflags_6);
    eax_13 = temp0_7;
    *eax_13[1] = temp1_4;
    void* eax_14;
    eax_14 = (eax_13 + 1) | *(eax_13 + 1);
    int32_t eflags_8;
    char temp0_8;
    char temp1_5;
    temp0_8 = __aas(eax_14, *eax_14[1], eflags_7);
    eax_14 = temp0_8;
    *eax_14[1] = temp1_5;
    void* eax_15;
    eax_15 = (eax_14 + 1) | *(eax_14 + 1);
    
    if (!eax_15)
    {
        eax_15 &= (ebx_3 + 2);
        *esi;
    }
    else
    {
        int32_t eflags_9;
        char temp0_9;
        char temp1_6;
        temp0_9 = __aas(eax_15, *eax_15[1], eflags_8);
        eax_15 = temp0_9;
        *eax_15[1] = temp1_6;
        void* eax_16;
        eax_16 = (eax_15 + 1) | *(eax_15 + 1);
        __fldenv_memmem28(*edi_1);
        char temp0_10;
        char temp1_7;
        temp0_10 = __aas(eax_16, *eax_16[1], eflags_9);
        eax_16 = temp0_10;
        *eax_16[1] = temp1_7;
        void* eax_17;
        eax_17 = (eax_16 + 1) | *(eax_16 + 1);
        
        if (eax_17 <= 0)
        {
            edx_1 -= 1;
            eax_17 -= 0x3f;
        }
        else
        {
            int32_t eflags_10;
            char temp0_11;
            char temp1_8;
            temp0_11 = __aas(eax_17, *eax_17[1], eflags_8);
            eax_17 = temp0_11;
            *eax_17[1] = temp1_8;
            eax_17 = (eax_17 + 1) | *(eax_17 + 1);
            *arg3[1] *= 2;
            *0x222b7943 = ss;
            esp_11 = 0x222b7943;
            int16_t es_1;
            ebp = __les_gprz_memp(*edx_1);
            *(esi + 0xa2cc444) += *arg3[1];
            *(eax_17 + ebp + 0x79) += (ebx_3 + 2);
            arg3 -= *edx_1;
            *(edx_1 + 0x2c) += arg3;
            char temp0_12;
            char temp1_9;
            temp0_12 = __aas(eax_17, *eax_17[1], eflags_10);
            eax_17 = temp0_12;
            *eax_17[1] = temp1_9;
        }
        
        void* eax_18;
        eax_18 = (eax_17 + 1) | *(eax_17 + 1);
        *arg3[1] += *(edi_1 * 2);
        eax_15 = (eax_18 + 1) | *(eax_18 + 1);
        *edx_1;
        edi_1[0x3a] += eax_15;
        eax_15 |= *(ss + eax_15);
        *eax_15;
        *(esp_11 - 2) = *esp_11;
        esp_11 -= 2;
    }
    
    *(eax_15 + 0x1f) += *eax_15[1];
    *edi_1 = *esi;
    void* edi_2 = &edi_1[4];
    void* esi_1 = esi + 4;
    *edx_1 -= arg3;
    *(edx_1 + 0x27) += *(ebx_3 + 2)[1];
    int32_t eflags_11;
    char temp0_13;
    char temp1_10;
    temp0_13 = __aas(eax_15, *eax_15[1], eflags_8);
    eax_15 = temp0_13;
    *eax_15[1] = temp1_10;
    *(esp_11 - 4) = ds;
    *(ebx_3 + 0x1b) += *edx_1[1];
    int16_t gs;
    *esi_1 = gs;
    void* eax_19;
    eax_19 = (eax_15 + 1) | *(eax_15 + 1);
    void* eax_20 = eax_19 | 0xa403f;
    arg3 = 0x3d;
    int32_t eflags_13;
    char temp0_14;
    char temp1_11;
    temp0_14 = __aas(eax_20, *eax_20[1], __sti(eflags_11));
    eax_20 = temp0_14;
    *eax_20[1] = temp1_11;
    *(eax_20 + 1);
    char* eax_21;
    eax_21 = (eax_20 + 1) | *(eax_20 + 1);
    char* ebx_5;
    ebx_5 = (ebx_3 + 2) + *(ebx_3 + 2);
    int32_t eflags_14;
    char temp0_15;
    char temp1_12;
    temp0_15 = __aas(eax_21, *eax_21[1], eflags_13);
    eax_21 = temp0_15;
    *eax_21[1] = temp1_12;
    void* eax_22;
    eax_22 = (&eax_21[1]) | eax_21[1];
    void* eax_23 = esp_11 - 4;
    int16_t es_3 = *eax_22;
    void* esp_15 = eax_22 + 2;
    void* eax_24;
    bool cond:1_1;
    
    if (eax_22 < 0)
    {
        eax_23 |= *eax_23;
        eax_24 = (eax_23 + 1) | *(eax_23 + 1);
        
        if (eax_24 > 0)
        {
            eax_24 |= *eax_24;
            cond:1_1 = eax_24 >= 0;
            goto label_10009580;
        }
        
        int32_t eflags_15;
        char temp0_17;
        char temp1_13;
        temp0_17 = __aas(eax_24, *eax_24[1], eflags_14);
        eax_24 = temp0_17;
        *eax_24[1] = temp1_13;
        void* eax_25;
        eax_25 = (eax_24 + 1) | *(eax_24 + 1);
        uint8_t* edi_3;
        uint8_t temp0_18;
        temp0_18 = __insb(edi_2, edx_1, eflags_15);
        *edi_3 = temp0_18;
        *ebx_5[1] ^= *(arg3 + 0x2b);
        eax_25 |= *eax_25;
        *esp_15;
        __vmwrite_gpr32_memd(ebp, *ebx_5);
        eax_25 |= *eax_25;
        /* undefined */
    }
    
    edx_1[6] += *arg3[1];
    
    if (edx_1[6] + *arg3[1] >= 0)
        goto label_10009591;
    
    *(esp_15 - 4) = es_3;
    char temp12_1 = ebx_5;
    ebx_5 += *arg3[1];
    *0x59000a0e = *0x59000a0e - edx_1;
    eax_24 = (eax_23 - 0x6cfff9c9) - 0x15;
    int16_t cs;
    *(esp_15 - 8) = cs;
    *(esp_15 - 0xc) = es_3;
    esp_15 -= 0xc;
    char temp13_1 = *(esp_15 + ebp + 0xa0e15);
    *(esp_15 + ebp + 0xa0e15) += ebx_5;
    cond:1_1 = temp13_1 + ebx_5 >= 0;
    label_10009580:
    void* esp_20 = eax_24;
    char temp0_20;
    temp0_20 = __daa(esp_15, eflags_14);
    eax_23 = temp0_20;
    
    if (!cond:1_1)
    {
        *(esp_20 - 4) = es_3;
        *(eax_23 + 0xa397933) += edx_1;
        *eax_23 += 0x3d;
        edi_2 ^= *(arg3 + 0x2b);
        *(esp_20 - 8) = es_3;
        esp_15 = esp_20 - 8;
        label_10009591:
        ebx_5 += *eax_23[1];
        *edi_2 = *esi_1;
        void* esi_2 = esi_1 + 4;
        *esi_2 -= (eax_23 + 1);
        *0x628a524 += *ebx_5[1];
        arg3 = 0x3d + *edx_1[1];
        arg3 += 1;
        *(edi_2 + 4) = *esi_2;
        esi_1 = esi_2 + 4;
        *esi_1 -= (eax_23 + 1);
        *edx_1 += *(eax_23 + 1)[1];
        esp_20 = esp_15 | *(ebp + 0x23001628);
        char temp0_21;
        temp0_21 = __daa((eax_23 + 1), eflags_14);
        eax_23 = temp0_21;
        *eax_23;
    }
    
    edx_1 += *eax_23[1];
    int32_t eflags_17;
    char temp0_22;
    char temp1_14;
    temp0_22 = __aas(eax_23, *eax_23[1], eflags_14);
    eax_23 = temp0_22;
    *eax_23[1] = temp1_14;
    int32_t edi_7 = *eax_23 * 0xa;
    *ebx_5 += *ebx_5[1];
    int32_t* edi_8 = edi_7 ^ *(arg3 + 0x2b);
    *(esp_20 - 4) = es_3;
    void* esp_21 = esp_20 - 4;
    *ebx_5 += *eax_23[1];
    eax_23 |= 0xa5;
    *edx_1 -= arg3;
    char temp14 = *(ebx_5 + esi_1);
    *(ebx_5 + esi_1) += *arg3[1];
    
    if (temp14 + *arg3[1] < 0)
    {
        eax_23 |= *eax_23;
        int32_t eflags_18 = __sti(eflags_17);
        *0xc7000a37 |= eax_23;
        char temp0_23;
        char temp1_15;
        temp0_23 = __aaa(eax_23, *eax_23[1], eflags_18);
        eax_23 = temp0_23;
        *eax_23[1] = temp1_15;
        void* eax_26;
        eax_26 = (eax_23 - 0x71000621) & 0x15;
        *(esp_21 - 4) = cs;
        *eax_26;
        eax_26 |= *eax_26;
        *edi_8 = *edi_8 - edi_8;
        eax_23 = eax_26 + 1;
        *(esp_21 - 8) = es_3;
        esp_21 -= 8;
        *0x628a523 += *arg3[1];
        *(edi_8 + 0x2b) += *eax_23[1];
        *edi_8 = *esi_1;
        edi_8 = &edi_8[1];
        esi_1 += 4;
        *edx_1 -= arg3;
        *(ebp + 0xa38d827) += ebx_5;
    }
    
    char temp15 = *(ebp + 0x3e);
    *(ebp + 0x3e) += *arg3[1];
    void* esp_23;
    bool c_8;
    
    if (temp15 + *arg3[1] >= 0)
    {
        char temp18_1 = *(eax_23 + esi_1 + 0x57);
        *(eax_23 + esi_1 + 0x57) += ebx_5;
        c_8 = temp18_1 + ebx_5 < temp18_1;
        eax_23 += 1;
        label_10009626:
        eax_23 = eax_23 + *eax_23;
        *esi_1 ^= *ebx_5[1];
        *edi_8 -= *ebx_5[1];
        *(esp_21 - 4) = es_3;
        ebx_5[0xb] += (eax_23 + 1);
        *edi_8 = *0x1c000a20;
        edi_8 = &edi_8[1];
        esi_1 = 0x1c000a24;
        *edx_1 -= arg3;
        void* eax_27;
        eax_27 = (eax_23 + 1) + ebx_5;
        eax_27 &= ebx_5;
        *edx_1;
        char temp20_1 = *esi_1;
        *esi_1 += edx_1;
        *edi_8 = *edi_8 - *ebx_5[1];
        eax_23 = eax_27 + 1;
        *(esp_21 - 8) = es_3;
        esp_23 = esp_21 - 8;
    }
    else
    {
        *(esp_21 - 4) = es_3;
        esp_23 = esp_21 - 4;
        *(ebp + 8) += *edx_1[1];
        *edi_8 = *esi_1;
        void* edi_9 = &edi_8[1];
        void* esi_3 = esi_1 + 4;
        *esi_3 -= eax_23;
        char temp19_1 = *edx_1[1];
        *edx_1[1] += arg3;
        *(ebp - 0x14fff5d8) = *(ebp - 0x14fff5d8) - esp_23;
        *0xa1000621 &= ebp;
        *edi_9 = *(esi_3 + 1);
        void* edi_10 = edi_9 + 4;
        esi_1 = esi_3 + 5;
        *esi_1 -= *eax_23[1];
        *(edx_1 + esi_1 + 0x3d) += edx_1;
        arg3 += 1;
        eax_23 |= *eax_23;
        edi_8 = edi_10 + 1;
        
        if (edi_10 + 1 < 0)
        {
            *(esp_23 - 4) = es_3;
            *edx_1[1] += *eax_23[1];
            es_3 = *(esp_23 - 4);
            *(esp_23 - 6) = edi_8;
            *eax_23;
            esp_21 = *(esp_23 - 6);
            edi_8[0x10];
            edi_8[0x10] ^= edx_1;
            c_8 = false;
            goto label_10009626;
        }
    }
    char temp21 = *eax_23[1];
    char temp22 = *eax_23[1];
    *eax_23[1] *= 2;
    *(ebp - 0x78fff5d8) = *(ebp - 0x78fff5d8) - esp_23;
    int32_t eflags_19;
    char temp0_24;
    temp0_24 = __daa(eax_23, eflags_17);
    eax_23 = temp0_24;
    int32_t eflags_20;
    char temp0_25;
    char temp1_16;
    temp0_25 = __aas(eax_23, *eax_23[1], eflags_19);
    eax_23 = temp0_25;
    *eax_23[1] = temp1_16;
    void* eax_28;
    eax_28 = (eax_23 + 1) | *(eax_23 + 1);
    eax_28 = __salc(eflags_20);
    *(esp_23 - 3) = ss;
    int32_t eflags_21;
    char temp0_27;
    char temp1_17;
    temp0_27 = __aas((eax_28 + 0x4afff5df), *(eax_28 + 0x4afff5df)[1], eflags_20);
    void* eax_29;
    eax_29 = temp0_27;
    *eax_29[1] = temp1_17;
    *(esp_23 - 7) = es_3;
    *(edi_8 + 0x2f) += *ebx_5[1];
    *edi_8 = *esi_1;
    void* esi_5 = esi_1 + 4;
    *edx_1 -= arg3;
    *(eax_29 + 0xa403f0e) += ebx_5;
    *(edx_1 + 0x27) += *arg3[1];
    int32_t eflags_22;
    char temp0_28;
    char temp1_18;
    temp0_28 = __aas((eax_29 + 1), *(eax_29 + 1)[1], eflags_21);
    void* eax_30;
    eax_30 = temp0_28;
    *eax_30[1] = temp1_18;
    void* eax_31;
    eax_31 = (eax_30 + 1) | *(eax_30 + 1);
    int32_t eax_32 = eax_31;
    *(esp_23 - 0xb) = ss;
    int32_t eflags_23;
    char temp0_29;
    char temp1_19;
    temp0_29 = __aas(eax_32, *eax_32[1], eflags_22);
    eax_32 = temp0_29;
    *eax_32[1] = temp1_19;
    char* eax_33;
    eax_33 = (eax_32 + 1) | *(eax_32 + 1);
    float* eax_34;
    
    if (!eax_33 || arg3 != 1)
    {
        void* eax_35;
        eax_35 = (&eax_33[1]) | eax_33[1];
        edi_8[1] = eax_35;
        eax_34 = (eax_35 | 0xa403f) & edx_1[-5];
        *edx_1;
        *esi_5 += *ebx_5[1];
    }
    else
    {
        if (eax_33 >= 0)
        {
            *ebx_5[1] += *(arg3 - 1)[1];
            eax_33 ^= 0x3f;
            void* eax_37;
            eax_37 = (&eax_33[1]) | eax_33[1];
            breakpoint();
        }
        
        eax_33 |= *eax_33;
        *eax_33 += ebx_5;
        int32_t eflags_24;
        char temp0_30;
        char temp1_20;
        temp0_30 = __aas(eax_33, *eax_33[1], eflags_23);
        eax_33 = temp0_30;
        *eax_33[1] = temp1_20;
        eax_34 = (&eax_33[1]) | eax_33[1];
        ebx_5[0xa403f0d] += *(arg3 - 1)[1];
        *ebx_5 += *eax_34[1];
        *eax_34;
        eax_34 |= *eax_34;
    }
    
    *eax_34;
    eax_34 |= *eax_34;
    /* undefined */
}

void __convention("regparm") sub_1000969b(int32_t arg1, char* arg2, int16_t arg3, int32_t* arg4 @ esi, int32_t* arg5 @ edi) __noreturn
{
    int32_t ebx;
    void* eax = arg1 ^ ebx;
    *arg4;
    *(eax + 0x2b) += eax;
    *arg5 = *arg4;
    *arg2 -= arg3;
    *ebx[1] += *arg3[1];
    eax ^= 0x3f;
    void* eax_1;
    eax_1 = (eax + 1) | *(eax + 1);
    breakpoint();
}

void __convention("regparm") sub_1000a133(int32_t* arg1, int32_t arg2, char arg3, int32_t arg4 @ ebp, int32_t* arg5 @ esi) __noreturn
{
    int16_t ss;
    uint32_t var_4 = ss;
    int32_t temp0 = *arg1;
    *arg1 += arg1;
    bool p = /* bool p = unimplemented  {add dword [eax], eax} */;
    
    if (!p)
    {
        *arg5 = *arg5 - arg2;
        *arg5 += arg3;
    }
    else
    {
        arg1 = *0xa003619;
        arg1 |= 0x1619a5;
        int16_t cs;
        uint32_t var_8_1 = cs;
    }
    
    *(arg2 - 0x2efff9e7);
    int32_t eflags;
    int32_t eflags_1;
    char temp0_1;
    char temp1;
    temp0_1 = __aaa(arg1, *arg1[1], eflags);
    arg1 = temp0_1;
    *arg1[1] = temp1;
    trap(0xd);
}

void __convention("regparm") sub_1000a14b(int16_t arg1, char arg2, char arg3, char* arg4 @ edi) __noreturn
{
    int16_t ss;
    uint32_t var_4 = ss;
    int16_t es;
    uint32_t var_8 = es;
    int16_t ebx;
    *arg4 += *ebx[1];
    char* cs;
    *(cs + arg4) = ~*(cs + arg4);
    uint32_t var_c = es;
    int32_t eflags;
    int32_t eflags_1;
    char temp0;
    char temp1;
    temp0 = __aaa(arg1, *arg1[1], eflags);
    arg1 = temp0;
    *arg1[1] = temp1;
    trap(0xd);
}

int32_t __convention("regparm") sub_1000a157(int32_t arg1, char* arg2, char* arg3, void* arg4 @ ebp, int32_t* arg5 @ esi, char* arg6 @ edi)
{
    int16_t ss;
    uint32_t var_4 = ss;
    int16_t es;
    uint32_t var_8 = es;
    void* ebx;
    *arg6 += *ebx[1];
    char* cs;
    *(cs + arg6) = ~*(cs + arg6);
    int16_t var_c = es;
    *(arg4 + 0x36188736) += *arg2[1];
    *arg2 += arg3;
    char temp1 = *(ebx + 8);
    *(ebx + 8) += *ebx[1];
    *arg5 = *arg5 - arg5;
    *arg2 += arg3;
    char* eax_2 = ((arg1 | 0x1619b4) - 0x1619b900) | 0x1619c6;
    char temp2 = ebx;
    ebx += arg3;
    *arg5 = *arg5 - arg2;
    char temp3 = *(arg4 + eax_2 - 0x35);
    *(arg4 + eax_2 - 0x35) += arg2;
    *arg5 = *arg5 - arg2;
    *eax_2[1] += ebx;
    char temp4 = arg2;
    arg2 += *arg3[1];
    *arg5 = *arg5 - eax_2;
    *(arg4 + 0x50177d17) += *arg2[1];
    *eax_2 &= eax_2;
    *eax_2 += eax_2;
    arg5[0x4cea86] += eax_2;
    *arg3 += eax_2;
    eax_2[0x20] += ebx;
    *eax_2 += eax_2;
    *eax_2 += eax_2;
    char temp0 = *eax_2;
    *eax_2 = ebx;
    ebx = temp0;
    *arg6 = eax_2;
    void* edi = &arg6[1];
    *arg3 = *arg3 - eax_2;
    eax_2[0x20] += *arg2[1];
    *eax_2 += eax_2;
    *eax_2 += eax_2;
    char temp0_1 = *eax_2;
    *eax_2 = (ebx ^ edi);
    int32_t ebx_1;
    ebx_1 = temp0_1;
    *edi = eax_2;
    void* edi_1 = edi + 1;
    *arg3 = *arg3 - eax_2;
    *(edi_1 + 0x20) += *ebx_1[1];
    *eax_2 += eax_2;
    *eax_2 += eax_2;
    char temp0_2 = *eax_2;
    *eax_2 = ebx_1;
    ebx_1 = temp0_2;
    *edi_1 = eax_2;
    char* edi_2 = edi_1 + 1;
    char* ebx_2 = ebx_1 ^ edi_2;
    *arg3 = *arg3 - eax_2;
    arg5[8] += arg3;
    arg5[0x14cea86] += eax_2;
    *arg3 += eax_2;
    *(arg4 + 0x20) += ebx_2;
    char temp9 = arg5[-0x577c7fe];
    arg5[-0x577c7fe] += eax_2;
    *arg3 = *arg3 - eax_2;
    *(arg4 + 0x20) += *eax_2[1];
    arg3[0x4820f008] += eax_2;
    *arg3 |= eax_2;
    arg5[8] += *arg3[1];
    char temp10 = arg3[0xef372508];
    arg3[0xef372508] += eax_2;
    *arg2 = *arg2 - eax_2;
    arg5[8] += *arg2[1];
    char temp11 = arg3[0xfa373208];
    arg3[0xfa373208] += eax_2;
    *arg2 = *arg2 - eax_2;
    edi_2[0x20] += *ebx_2[1];
    *arg2[1] += eax_2;
    char temp12 = *arg5;
    *arg5 += *eax_2[1];
    bool c_7 = temp12 + *eax_2[1] < temp12;
    char temp13 = *arg5;
    *arg5 = temp13 + eax_2;
    eax_2 = eax_2 - *ebx_2;
    *arg3[1] += eax_2;
    *eax_2 &= eax_2;
    *eax_2 += eax_2;
    *arg2[1] += eax_2;
    *(edi_2 + arg2 + 0x4003b) += arg2;
    *eax_2 &= eax_2;
    *eax_2 += eax_2;
    char temp14 = arg5[0x306fa80];
    arg5[0x306fa80] += eax_2;
    eax_2 = eax_2 - *0x21b800;
    *eax_2 += eax_2;
    char temp15 = arg5[0x546f600];
    arg5[0x546f600] += eax_2;
    arg3 = arg3 - *eax_2;
    *eax_2 += *ebx_2[1];
    eax_2 &= *eax_2;
    *eax_2 += eax_2;
    *arg2[1] += eax_2;
    char temp16 = ebx_2;
    char temp17 = ebx_2;
    ebx_2 *= 2;
    eax_2 = eax_2 - 1;
    *arg3 += arg3;
    eax_2 *= 2;
    eax_2 &= *eax_2;
    *eax_2 += eax_2;
    arg5[0x4cea86] += eax_2;
    *arg3 += arg3;
    eax_2 += arg3;
    eax_2 &= *eax_2;
    *eax_2 += eax_2;
    char temp18 = arg5[0x6c85802];
    arg5[0x6c85802] += eax_2;
    arg3 = arg3 - *arg3;
    eax_2 += arg2;
    eax_2 &= *eax_2;
    *eax_2 += eax_2;
    char temp19 = arg5[0x8085ac2];
    arg5[0x8085ac2] += eax_2;
    arg3 = arg3 - *arg3;
    arg3 += ebx_2;
    eax_2 &= *eax_2;
    *eax_2 += eax_2;
    char temp20 = arg5[0x98eb202];
    arg5[0x98eb202] += eax_2;
    arg3 = arg3 - *arg2;
    arg3 += *eax_2[1];
    eax_2 &= *eax_2;
    *eax_2 += eax_2;
    char temp21 = arg5[0xbceb782];
    arg5[0xbceb782] += eax_2;
    arg3 = arg3 - *arg2;
    arg2 += *arg3[1];
    eax_2 &= *eax_2;
    *eax_2 += eax_2;
    char temp22 = ebx_2[0x393aa608];
    ebx_2[0x393aa608] += eax_2;
    arg3 = arg3 - *ebx_2;
    arg2 += *arg2[1];
    eax_2 &= *eax_2;
    *eax_2 += eax_2;
    char temp23 = ebx_2[0x423ab708];
    ebx_2[0x423ab708] += eax_2;
    arg3 = arg3 - *ebx_2;
    *eax_2 += eax_2;
    void* eax_3 = eax_2 & *eax_2;
    *eax_3 += eax_3;
    *arg2[1] += eax_3;
    char temp24 = *arg5;
    *arg5 += *eax_3[1];
    bool c_18 = temp24 + *eax_3[1] < temp24;
    char temp25 = *arg5;
    *arg5 = temp25 + eax_3;
    arg3 = arg3 - *(eax_3 * 2);
    *ebx_2 |= *eax_3[1];
    *eax_3 += eax_3;
    *eax_3 += eax_3;
    *eax_3 = 0x94;
    *0;
    *eax_3;
    char* eax_4 = eax_3 | 0x23c000;
    *eax_4 += eax_4;
    arg3[0x1209200] += eax_4;
    *arg5 += arg3;
    eax_4 += *arg2[1];
    eax_4 = 0;
    *eax_4 = *eax_4;
    char temp26 = arg3[0x2021af00];
    arg3[0x2021af00] = arg3[0x2021af00];
    arg3 = arg3 - *arg5;
    *eax_4 += *eax_4[1];
    *0 -= 0x5c;
    *arg3 = 0;
    *edi_2 += arg3;
    *0x25 += *ebx_2[1];
    *0 = *0;
    *0 = *0;
    char temp0_3 = *0;
    *0 = 0;
    int32_t eax_5;
    eax_5 = temp0_3;
    /* undefined */
}

int32_t __convention("regparm") sub_1000a89d(char* arg1, char* arg2, char* arg3, int32_t* arg4 @ esi, int32_t* arg5 @ edi)
{
    arg2 |= *arg1;
    *arg1 += arg1;
    char temp1 = arg4[0x1a05be82];
    arg4[0x1a05be82] += arg1;
    arg1 = arg1 + 0x7b;
    *arg2 += arg2;
    char* var_4 = arg1;
    *arg1 += arg1;
    char temp2 = *arg1;
    *arg1 += arg1;
    char temp0 = *arg1;
    *arg1 = arg3;
    arg3 = temp0;
    *arg5 = *arg5 + arg2;
    bool o = /* bool o = unimplemented  {adc dword [edi], edx} */;
    
    if (!o)
    {
        char temp0_1 = *arg1;
        *arg1 = arg1;
        arg1 = temp0_1;
        arg1 -= 0x50;
        *arg1 += arg1;
        *arg1 += arg1;
        char temp0_2 = *arg1;
        *arg1 = arg3;
        arg3 = temp0_2;
        *arg4 <<= 0x1a;
    }
    else
    {
        *arg1;
        arg2 = arg2 - *arg1;
        *arg1 += arg1;
        arg4[0x68ed4c2] += arg1;
        arg4[0x1408c0] = &arg1[arg4[0x1408c0]];
        *arg1 += arg1;
        arg4[-0x1871247e] += arg1;
        arg4[0x140b00] |= arg1;
        *arg1 += arg1;
        arg4[0x68db042] += arg1;
    }
    
    arg5[0x140d00] = &arg1[arg5[0x140d00]];
    *arg1 += arg1;
    arg4[-0x1872493e] += arg1;
    arg5[0x140f40] |= arg1;
    *arg1 += arg1;
    arg4[0x690edc2] += arg1;
    *(arg1 + 0x504500) = &arg3[*(arg1 + 0x504500)];
    *arg1 += arg1;
    arg4[-0x186f0c3e] += arg1;
    *(arg1 + 0x504e00) |= arg3;
    *arg1 += arg1;
    arg4[0x1e465202] += arg1;
    *(arg3 + 0x505600) |= arg3;
    *arg1 += arg1;
    arg4[0x1c65542] += arg1;
    arg1 |= 0x89;
    char* ebx;
    arg5[0x14] += ebx;
    *arg1 += arg1;
    *arg1 += arg1;
    char temp0_3 = *arg1;
    *arg1 = arg3;
    arg3 = temp0_3;
    char temp5 = ebx;
    ebx -= *arg3;
    
    if (temp5 - *arg3 >= 0)
    {
        *arg3;
        *arg3 |= *ebx[1];
        *arg5 = *arg5 - arg1;
    }
    else
    {
        arg1 = *arg1;
        int16_t var_8_1 = arg1;
        *arg1 += arg1;
        *arg1 += arg1;
        char temp0_4 = *arg1;
        *arg1 = arg3;
        arg3 = temp0_4;
        *arg3;
    }
    
    arg1 |= 0x8a;
    arg1[0x50] += *arg2[1];
    *arg1 += arg1;
    *arg1 += arg1;
    char temp0_5 = *arg1;
    *arg1 = arg3;
    arg3 = temp0_5;
    *ebx <<= 1;
    /* undefined */
}

int32_t __convention("regparm") sub_1000a957(char* arg1, int32_t, int32_t arg3, void* arg4 @ edi)
{
    int16_t ebx;
    arg1[0x50] += *ebx[1];
    *arg1 += arg1;
    *arg1 += arg1;
    char temp0 = *arg1;
    *arg1 = arg3;
    arg3 = temp0;
    int32_t eflags;
    char* eax_1 = __in_oeax_immb(0x33, eflags) - 0x7eff7500;
    char* var_4 = eax_1;
    *eax_1 += eax_1;
    *eax_1 += eax_1;
    char temp0_1 = *eax_1;
    *eax_1 = arg3;
    arg3 = temp0_1;
    *(arg4 + 0x1a) |= eax_1;
    *(eax_1 * 2 + 0x5089) += arg3;
    *eax_1 += eax_1;
    char temp0_2 = *eax_1;
    *eax_1 = arg3;
    arg3 = temp0_2;
    *(arg4 - 0x62) &= eax_1;
    *(eax_1 * 2 + 0x5092) |= arg3;
    *eax_1 += eax_1;
    char temp0_3 = *eax_1;
    *eax_1 = arg3;
    arg3 = temp0_3;
    eax_1 = 0x15;
    /* undefined */
}

int32_t __convention("regparm") sub_1000b537(char* arg1, void* arg2, int32_t* arg3, void* arg4 @ ebp, char* arg5 @ esi, int32_t* arg6 @ edi, int16_t arg7)
{
    arg1 = *arg1;
    *arg1 += arg1;
    char temp1 = arg3[-0x113313fa];
    arg3[-0x113313fa] += arg2;
    char* ebx;
    *arg3[1] = *arg3[1] - *ebx;
    void* ebx_1 = ebx + arg2;
    arg1 = *arg1;
    *arg1 += arg1;
    arg5[0x133aa18] += arg1;
    *ebx_1 += *arg3[1];
    void* ebx_2 = ebx_1 * 2;
    arg1 = *arg1;
    *arg1 += arg1;
    *(ebx_2 + 0x39064b00) += arg1;
    void* eax = arg1 - *arg3;
    int32_t eflags;
    __out_immb_oeax(0x8a, eax, eflags);
    *eax += eax;
    *eax += eax;
    *eax += 0x47;
    *arg6 |= arg6;
    eax -= 1;
    eax = *eax;
    *eax += eax;
    arg5[0x133aa18] += eax;
    *0x8b0001 += *arg3[1];
    *eax += eax;
    *(ebx_2 + 0x1049e00) += eax;
    *0x8d1c01 += *arg3[1];
    *eax += eax;
    arg3 += *eax[1];
    *(arg6 + 0x43) += arg2;
    *eax += eax;
    *(eax - 0x8f3801) += (eax - 0x8f3801);
    arg3 += *(eax - 0x8f3801)[1];
    void* eax_2 = eax - 0x8f3801 + arg2;
    *arg3[1] = *arg3[1] - *arg5;
    *0x8f4601 += *arg3[1];
    *eax_2 += eax_2;
    char temp4 = arg3[-0x113313fa];
    arg3[-0x113313fa] += arg2;
    *arg3[1] = *arg3[1] - *arg5;
    *(arg2 - 0x71) += arg2;
    *eax_2 += eax_2;
    *eax_2 += eax_2;
    char temp0 = *eax_2;
    *eax_2 = ebx_2;
    ebx_2 = temp0;
    *arg6 = eax_2;
    void* edi = arg6 + 1;
    char* eax_3 = eax_2 ^ *arg3;
    *arg5 += *arg3[1];
    *(arg2 - 0x71) += ebx_2;
    *eax_3 += eax_3;
    *eax_3 += eax_3;
    *eax_3 += 0x18;
    void* eax_4 = &eax_3[*(arg4 + 0x1f)];
    int32_t arg_4;
    int32_t cs;
    *(cs + arg2 - 0x71) += &arg_4;
    *eax_4 += eax_4;
    *eax_4 += eax_4;
    char temp0_1 = *eax_4;
    *eax_4 = ebx_2;
    ebx_2 = temp0_1;
    *edi = eax_4;
    char* edi_1 = edi + 1;
    char* eax_5 = eax_4 ^ *arg3;
    *edi_1 += *arg3[1];
    *(edi_1 + (arg3 << 2)) += arg4;
    *eax_5 += eax_5;
    *(ebx_2 + 0x1041c00) += eax_5;
    *edi_1 += *arg3[1];
    *eax_5 = arg_4;
    *eax_5 += eax_5;
    arg5[0x133aa18] += eax_5;
    *edi_1 += *arg3[1];
    *eax_5 = &eax_5[*eax_5];
    *eax_5 += eax_5;
    *eax_5 += eax_5;
    *eax_5 = *eax_5;
    eax_5 += 1;
    *edi_1 += *arg3[1];
    arg3[0x24] += arg3;
    arg5[0x133aa18] += eax_5;
    *edi_1 += *arg3[1];
    arg3[0x24] += arg2;
    char temp5 = *(ebx_2 - 0x2df8a300);
    *(ebx_2 - 0x2df8a300) += eax_5;
    int32_t* eax_6 = eax_5 + 0x6f58fed1;
    *eax_6 += eax_6;
    char temp6 = *eax_6;
    *eax_6 += eax_6;
    char* eax_7 = arg3;
    eax_7[0x301abb33] = eax_7[0x301abb33] - *arg2[1];
    *(ebx_2 + 0x90) = &arg5[*(ebx_2 + 0x90)];
    arg5[0x133aa18] += eax_7;
    *eax_7 += *arg2[1];
    *(ebx_2 + 0x90) = &edi_1[*(ebx_2 + 0x90)];
    *(ebx_2 + 0x4b003700) += eax_7;
    *eax_6 ^= eax_7;
    int32_t edx;
    int16_t es;
    edx = __les_gprz_memp(*eax_7);
    *eax_7 -= 0x7b;
    int32_t* ecx;
    ecx = eax_6 | eax_7;
    arg_4 = arg7;
    *ecx ^= eax_7;
    /* undefined */
}

char* __convention("regparm") sub_1000b7ef(char* arg1)
{
    int16_t cs;
    uint32_t var_4 = cs;
    *arg1 += arg1;
    arg1 += *arg1;
    *arg1 += arg1;
    *arg1 = &arg1[*arg1];
    return arg1;
}

char* __convention("regparm") sub_1000b825(char* arg1, char* arg2, char* arg3, void* arg4 @ ebp, char* arg5 @ esi, char* arg6 @ edi, int80_t arg7 @ st0, int80_t arg8 @ st1)
{
    int16_t cs;
    uint32_t var_4 = cs;
    bool c;
    *arg1 = *arg1 + arg2;
    arg1 += *arg1;
    *arg6 = arg1;
    void* edi = &arg6[1];
    char temp1 = arg1;
    arg1 -= 0x10;
    char* ebx;
    *ebx = *ebx + arg1;
    *arg5 += *arg1[1];
    int16_t ss;
    uint32_t var_8 = ss;
    uint32_t* esp_1 = &var_8;
    *arg1 += arg1;
    *arg1 = &arg1[*arg1];
    char* eax = *0x200003d;
    *eax += *arg3[1];
    int0_t ldtr;
    *eax = __sldt_memw(ldtr);
    *eax;
    bool c_2 = &eax[*eax] < eax;
    int32_t eflags;
    char* eax_2 = __in_oeax_dx(arg2, eflags);
    eax_2 = eax_2 - *eax_2;
    *arg3 += eax_2;
    arg3[0x200003d] += *eax_2[1];
    *eax_2 += *arg3[1];
    *eax_2 = __sldt_memw(ldtr);
    *eax_2;
    bool c_3 = &eax_2[*eax_2] < eax_2;
    char* eax_4 = __in_oeax_dx(arg2, eflags);
    eax_4 = eax_4 - *eax_4;
    *arg3 += eax_4;
    *(arg4 + 0x2d) += *arg3[1];
    *eax_4 += eax_4;
    char* eax_5 = *0x300003d;
    *eax_5 += *arg3[1];
    *eax_5 = __sldt_memw(ldtr);
    *eax_5 = &eax_5[*eax_5];
    arg7 - *edi;
    *eax_5 += eax_5;
    *eax_5 = &eax_5[*eax_5];
    void* eax_6 = eax_5 & 0x20000;
    *edi = RORD(*edi, 0);
    *ebx += eax_6;
    arg2[0xd] += eax_6;
    *eax_6 += eax_6;
    eax_6 = eax_6;
    ebx[0x1a] += *arg2[1];
    *(eax_6 + 0x100003a) += (eax_6 + 0x100003a);
    void* eax_7;
    eax_7 = (eax_6 + 0x100003a) + *(eax_6 + 0x100003a);
    ebx = *eax_7;
    *eax_7 += eax_7;
    *eax_7 += eax_7;
    eax_7 &= 0x3a;
    *eax_7 = *eax_7 + arg2;
    eax_7 += *eax_7;
    eax_7 = __salc(eflags);
    *eax_7 = __sldt_memw(ldtr);
    *eax_7 += eax_7;
    void* eax_8 = eax_7 & 0x20000;
    int32_t esi_2 = __outsd(arg2, *(arg5 - 2), arg5 - 2, eflags);
    *(cs + eax_8) += eax_8;
    *eax_8 += eax_8;
    eax_8 &= 0x3a;
    *eax_8 = *eax_8 + arg2;
    eax_8 += *eax_8;
    eax_8 = __salc(eflags);
    *eax_8 = __sldt_memw(ldtr);
    *eax_8 += eax_8;
    eax_8 &= 0x3a;
    *eax_8 += eax_8;
    *eax_8 += eax_8;
    eax_8 &= 0x3a;
    *eax_8 += eax_8;
    *eax_8 += eax_8;
    void* eax_9;
    eax_9 = (eax_8 & 0x10000) & 0x3a;
    *eax_9 += eax_9;
    char temp8 = eax_9;
    char temp9 = *eax_9;
    eax_9 += *eax_9;
    bool p = /* bool p = unimplemented  {add al, byte [eax]} */;
    
    if (!p)
    {
        eax_9 &= 0x3a;
        label_1000b904:
        *eax_9 += eax_9;
        *eax_9;
        eax_9 += *eax_9;
        bool p_2 = /* bool p_2 = unimplemented  {add al, byte [eax]} */;
        
        if (!p_2)
            goto label_1000b939;
        
        *eax_9 += eax_9;
        *eax_9 += eax_9;
        /* jump -> *(esi_2 - 1) */
    }
    
    *eax_9 = *eax_9 + arg2;
    char* eax_10 = eax_9 + *eax_9;
    
    if (eax_9 + *eax_9 < eax_9)
    {
        arg2[0x100001b] += *ebx[1];
        label_1000b8ef:
        *(arg2 + edi) += *eax_10[1];
        *eax_10 += eax_10;
        *eax_10 = &eax_10[*eax_10];
        *arg3[1] += ebx;
        eax_9 = (&eax_10[0x210103a]) & eax_10[0x210103a];
        *arg3 += eax_9;
        *(arg2 + edi) += *eax_9[1];
        goto label_1000b904;
    }
    
    *eax_10 += eax_10;
    *eax_10 = &eax_10[*eax_10];
    eax_10 &= 0x3a;
    *eax_10 += eax_10;
    *eax_10;
    eax_10 += *eax_10;
    bool p_1 = /* bool p_1 = unimplemented  {add al, byte [eax]} */;
    
    if (p_1)
    {
        *eax_10 += eax_10;
        eax_10 = &eax_10[*eax_10];
        arg2 = 0x100001b;
        goto label_1000b8ef;
    }
    
    eax_10 &= 0x3a;
    *eax_10 += eax_10;
    char temp16_1 = eax_10;
    char temp17_1 = *eax_10;
    eax_10 += *eax_10;
    bool p_3 = /* bool p_3 = unimplemented  {add al, byte [eax]} */;
    
    if (!p_3)
    {
        if (temp16_1 + temp17_1 >= temp16_1)
            goto label_1000b966;
        
        goto label_1000b94c;
    }
    
    *eax_10 += eax_10;
    eax_9 = &eax_10[*eax_10];
    arg3 = 0x1000046;
    *0x100003a += eax_9;
    ebx[0x1a] += *arg2[1];
    *eax_9 += eax_9;
    eax_9 += *eax_9;
    ebx = *eax_9;
    *eax_9 += eax_9;
    *eax_9 += eax_9;
    label_1000b939:
    eax_10 = eax_9 & 0x10000;
    int16_t ds;
    uint32_t var_c = ds;
    esp_1 = &var_c;
    *eax_10 ^= eax_10;
    *arg2 += eax_10;
    arg3[0x1000010] += ebx;
    ebx[0x1a] += *arg2[1];
    label_1000b94c:
    *eax_10 += eax_10;
    eax_10 += *eax_10;
    ebx = *eax_10;
    *eax_10 += eax_10;
    *eax_10 = &eax_10[*eax_10];
    eax_10 &= 0x3a;
    *eax_10 += eax_10;
    char temp18_1 = eax_10;
    char temp19_1 = *eax_10;
    eax_10 += *eax_10;
    bool p_4 = /* bool p_4 = unimplemented  {add al, byte [eax]} */;
    
    if (p_4)
    {
        *eax_10 = *eax_10 + arg2;
        char* temp20_1 = eax_10;
        int32_t temp21_1 = *eax_10;
        eax_10 = &eax_10[*eax_10];
        
        if (&temp20_1[temp21_1] < temp20_1)
        {
            arg2 += ebx;
            *esp_1;
            esp_1 += 2;
        }
        else
        {
            *eax_10 += eax_10;
            label_1000b966:
            *eax_10 = &eax_10[*eax_10];
            *(esp_1 - 4) = arg3;
            *eax_10;
            *arg3 += eax_10;
            arg2 += ebx;
            *(esp_1 - 4);
            esp_1 -= 2;
            *eax_10 += eax_10;
            *eax_10 = &eax_10[*eax_10];
            arg8 - *edi;
        }
        
        *eax_10 += eax_10;
        *eax_10 = &eax_10[*eax_10];
        /* unimplemented  {ficomp st0, dword [edi]} f- *edi */ - *edi;
        /* unimplemented  {ficomp st0, dword [edi]} */
        *eax_10 += eax_10;
        *eax_10 = &eax_10[*eax_10];
        eax_10 &= 0x10000;
    }
    
    /* unimplemented  {ficomp st0, dword [edi]} f- *edi */ - *edi;
    /* unimplemented  {ficomp st0, dword [edi]} */
    *eax_10 += eax_10;
    *eax_10 = &eax_10[*eax_10];
    /* unimplemented  {ficomp st0, dword [edi]} f- *edi */ - *edi;
    /* unimplemented  {ficomp st0, dword [edi]} */
    *eax_10 += eax_10;
    *eax_10 = &eax_10[*eax_10];
    /* unimplemented  {ficomp st0, dword [edi]} f- *edi */ - *edi;
    /* unimplemented  {ficomp st0, dword [edi]} */
    *eax_10 += eax_10;
    *eax_10 = &eax_10[*eax_10];
    /* unimplemented  {ficomp st0, dword [edi]} f- *edi */ - *edi;
    /* unimplemented  {ficomp st0, dword [edi]} */
    *eax_10 += eax_10;
    *eax_10 = &eax_10[*eax_10];
    /* unimplemented  {ficomp st0, dword [edi]} f- *edi */ - *edi;
    /* unimplemented  {ficomp st0, dword [edi]} */
    *eax_10 += eax_10;
    *eax_10 = &eax_10[*eax_10];
    /* unimplemented  {ficomp st0, dword [edi]} f- *edi */ - *edi;
    /* unimplemented  {ficomp st0, dword [edi]} */
    *eax_10 += eax_10;
    *eax_10 = &eax_10[*eax_10];
    *(esp_1 - 4) = arg3;
    *eax_10;
    *arg3 += eax_10;
    arg2 += ebx;
    *(esp_1 - 4);
    *eax_10 += eax_10;
    *eax_10 = &eax_10[*eax_10];
    /* unimplemented  {ficomp st0, dword [edi]} f- *edi */ - *edi;
    /* unimplemented  {ficomp st0, dword [edi]} */
    *eax_10 += eax_10;
    *eax_10 = &eax_10[*eax_10];
    /* unimplemented  {ficomp st0, dword [edi]} f- *edi */ - *edi;
    /* unimplemented  {ficomp st0, dword [edi]} */
    *eax_10 += eax_10;
    *eax_10 = &eax_10[*eax_10];
    /* unimplemented  {ficomp st0, dword [edi]} f- *edi */ - *edi;
    /* unimplemented  {ficomp st0, dword [edi]} */
    *eax_10 += eax_10;
    *eax_10 = &eax_10[*eax_10];
    /* unimplemented  {ficomp st0, dword [edi]} f- *edi */ - *edi;
    /* unimplemented  {ficomp st0, dword [edi]} */
    *eax_10 += eax_10;
    *eax_10 = &eax_10[*eax_10];
    /* unimplemented  {ficomp st0, dword [edi]} f- *edi */ - *edi;
    /* unimplemented  {ficomp st0, dword [edi]} */
    *eax_10 += eax_10;
    *eax_10 = &eax_10[*eax_10];
    /* unimplemented  {ficomp st0, dword [edi]} f- *edi */ - *edi;
    /* unimplemented  {ficomp st0, dword [edi]} */
    *eax_10 += eax_10;
    *eax_10 = &eax_10[*eax_10];
    /* unimplemented  {ficomp st0, dword [edi]} f- *edi */ - *edi;
    /* unimplemented  {ficomp st0, dword [edi]} */
    *eax_10 += eax_10;
    *eax_10 = &eax_10[*eax_10];
    /* unimplemented  {ficomp st0, dword [edi]} f- *edi */ - *edi;
    /* unimplemented  {ficomp st0, dword [edi]} */
    *eax_10 += eax_10;
    *eax_10 = &eax_10[*eax_10];
    /* unimplemented  {ficomp st0, dword [edi]} f- *edi */ - *edi;
    /* unimplemented  {ficomp st0, dword [edi]} */
    *eax_10 += eax_10;
    *eax_10 = &eax_10[*eax_10];
    /* unimplemented  {ficomp st0, dword [edi]} f- *edi */ - *edi;
    /* unimplemented  {ficomp st0, dword [edi]} */
    *eax_10 += eax_10;
    *eax_10 = &eax_10[*eax_10];
    /* unimplemented  {ficomp st0, dword [edi]} f- *edi */ - *edi;
    /* unimplemented  {ficomp st0, dword [edi]} */
    *eax_10 += eax_10;
    *eax_10 = &eax_10[*eax_10];
    /* unimplemented  {ficomp st0, dword [edi]} f- *edi */ - *edi;
    /* unimplemented  {ficomp st0, dword [edi]} */
    *eax_10 += eax_10;
    *eax_10 = &eax_10[*eax_10];
    /* unimplemented  {ficomp st0, dword [edi]} f- *edi */ - *edi;
    /* unimplemented  {ficomp st0, dword [edi]} */
    *eax_10 += eax_10;
    *eax_10 = &eax_10[*eax_10];
    /* unimplemented  {ficomp st0, dword [edi]} f- *edi */ - *edi;
    /* unimplemented  {ficomp st0, dword [edi]} */
    *eax_10 += eax_10;
    *eax_10 = &eax_10[*eax_10];
    /* unimplemented  {ficomp st0, dword [edi]} f- *edi */ - *edi;
    /* unimplemented  {ficomp st0, dword [edi]} */
    *eax_10 += eax_10;
    *eax_10 = &eax_10[*eax_10];
    /* unimplemented  {ficomp st0, dword [edi]} f- *edi */ - *edi;
    /* unimplemented  {ficomp st0, dword [edi]} */
    *eax_10 += eax_10;
    *eax_10 = &eax_10[*eax_10];
    /* unimplemented  {ficomp st0, dword [edi]} f- *edi */ - *edi;
    /* unimplemented  {ficomp st0, dword [edi]} */
    *eax_10 += eax_10;
    *eax_10 = &eax_10[*eax_10];
    /* unimplemented  {ficomp st0, dword [edi]} f- *edi */ - *edi;
    /* unimplemented  {ficomp st0, dword [edi]} */
    *eax_10 += eax_10;
    *eax_10 = &eax_10[*eax_10];
    /* unimplemented  {ficomp st0, dword [edi]} f- *edi */ - *edi;
    /* unimplemented  {ficomp st0, dword [edi]} */
    *eax_10 += eax_10;
    *eax_10 = &eax_10[*eax_10];
    void* eax_12 = eax_10 & 0x20000;
    
    if (!eax_12)
    {
        0x1100baa3();
        trap(0x41);
    }
    
    *eax_12 += eax_12;
    *eax_12 += eax_12;
    int32_t* eax_13 = eax_12 ^ 0x2000041;
    *ebx[1] += *eax_13[1];
    char* es;
    *(es + eax_13) += eax_13;
    *eax_13 += eax_13;
    char* result;
    char* ecx;
    char edx;
    result = 0x1100ba8b();
    *result;
    *ecx += result;
    *(esp_1 - 2 + arg4) += edx;
    *result += result;
    *result = &result[*result];
    return result;
}

int32_t __convention("regparm") sub_1000c96d(int16_t arg1, int32_t* arg2, void* arg3, int32_t arg4 @ ebp, char* arg5 @ esi, char* arg6 @ edi)
{
    int16_t es;
    uint32_t var_4 = es;
    int32_t eflags;
    int16_t temp0;
    temp0 = __arpl_memw_gpr16(*0x6690fa1, arg4);
    *0x6690fa1 = temp0;
    char temp1 = arg1 % *arg5;
    arg1 = arg1 / *arg5;
    *arg1[1] = temp1;
    *arg5;
    int32_t eflags_1;
    char eax_1;
    eax_1 = __bsf_gprv_memv(*arg2);
    *arg6 = eax_1;
    *(arg3 + 6) += arg3;
    int32_t var_8 = 0;
    void* var_c = arg3;
    int32_t* var_10 = arg2;
    int32_t ebx;
    int32_t var_14 = ebx;
    int32_t* var_18 = &var_14;
    int32_t var_1c = arg4;
    void* var_20 = &arg5[4];
    void* var_24 = &arg6[1];
    return 0;
}

int32_t __convention("regparm") sub_1000c983(int32_t arg1, uint16_t (* arg2)[0x2] @ esi, uint16_t arg3[0x4] @ st0)
{
    __punpcklwd_mmxq_memd(arg3, *arg2);
    /* undefined */
}

int32_t __convention("regparm") sub_1000ca13(int32_t arg1, int32_t, char* arg3)
{
    arg3 |= *arg3;
    *arg3;
    /* undefined */
}

int32_t __convention("regparm") sub_1000cacd(int32_t arg1, char* arg2, char* arg3, int32_t arg4 @ ebp, int32_t arg5 @ esi, int32_t arg6 @ edi)
{
    arg3[0x6319da03];
    *arg3[1] |= arg3[0x6319da03];
    int32_t temp2 = *(arg3 + 0x630d1703);
    *(arg3 + 0x630d1703) = temp2 + arg4;
    *(arg3 + 0x127ed03) = *(arg3 + 0x127ed03) + arg4;
    *arg3 += *arg2[1];
    void* ecx = &arg3[arg5];
    void* ebx;
    int32_t* ebp = arg4 - *(ebx + 0x11);
    *ebp;
    char temp3 = ebx;
    ebx += *arg2;
    *ecx = *ecx - arg1;
    ecx += *ebx[1];
    *arg1;
    int16_t cs;
    *ebp = cs;
    /* undefined */
}

int32_t sub_1000caf3(int32_t arg1 @ esi, int32_t arg2 @ edi)
{
    *(arg1 + 0xe);
    /* undefined */
}

int32_t __convention("regparm") sub_1000cc3b(void** arg1, char* arg2, int32_t* arg3, int32_t arg4 @ ebp, uint16_t* arg5 @ esi, char* arg6 @ edi)
{
    *arg3[1] |= arg3;
    *(arg5 - 0x16f5fbf2) += arg5;
    *arg1 += arg5;
    int16_t cs;
    uint32_t var_4 = cs;
    int32_t eax;
    eax = (*arg3 * 0x3d92e81) - 1;
    eax &= 0x58;
    char* ebx;
    arg2 |= ebx[eax];
    *arg6 = eax;
    void* edi = &arg6[1];
    int32_t eax_1 = eax ^ *arg3;
    char temp1 = *arg3;
    *arg3 += arg3;
    
    if (temp1 == -(arg3) || temp1 + arg3 < temp1)
    {
        *(arg3 + 0x1a484001);
        *arg3 += arg2 - 1;
        /* undefined */
    }
    
    arg3[0x1ec91080] += *arg3[1];
    char temp2 = *(arg3 + 5);
    *(arg3 + 5) += eax_1;
    bool c_1 = temp2 + eax_1 < temp2;
    int32_t var_6 = arg4;
    int32_t eflags;
    int32_t eflags_1;
    char temp0;
    char temp1_1;
    temp0 = __aaa(eax_1, *eax_1[1], eflags);
    eax_1 = temp0;
    *eax_1[1] = temp1_1;
    void* esi_1 = __outsd(arg2, *arg5, arg5, eflags_1);
    int32_t esp = &var_6 + arg3[1];
    *(cs + ebx + arg2 + 0x61) -= *arg2[1];
    eax_1 += 0x21;
    void* ecx_1 = (arg3 & *(arg2 + 0xa)) + 1;
    *edi = eax_1 - 0x5b - 3;
    char temp4 = *0x5f11043;
    *0x5f11043 += ecx_1;
    bool c_3 = temp4 + ecx_1 < temp4;
    int32_t eax_3;
    eax_3 = 0 + 3;
    *(ecx_1 - 0x58fcdbfe) = *(ecx_1 - 0x58fcdbfe) + ebx;
    int32_t temp6 = *ecx_1;
    *ecx_1 += eax_3 - 1;
    *(ecx_1 + (arg2 << 1)) = eax_3 - 1;
    int32_t eax_5 = (eax_3 - 1);
    int16_t* esp_1 = esp + *(ebx + eax_5);
    *esp_1;
    *(esp_1 - 2) = eax_5;
    void* ecx_3 = ecx_1 + esi_1 + 1 + *(eax_5 + 0x2c13a341);
    int32_t ebp = arg4 + *(arg2 - 0xeff3fcd);
    int32_t ebp_1 = ebp + *ebx;
    void* edi_2 = edi + 1 - *(ebx + arg2 + 0x33aa01f4);
    *eax_5 += eax_5;
    eax_5 ^= 3;
    *(esi_1 + 1) - *edi_2;
    void* esi_3 = esi_1 + 5;
    char* edi_3 = edi_2 + 4;
    *ecx_3 += eax_5;
    eax_5 ^= 3;
    *(esp_1 - 2);
    *(esp_1 - 4) = eax_5;
    *(ebx + eax_5) = &edi_3[*(ebx + eax_5)];
    *edi_3 = eax_5;
    int32_t eax_6 = eax_5 ^ *ecx_3;
    char temp9 = *ecx_3;
    *ecx_3 += arg2;
    bool c_7 = temp9 + arg2 < temp9;
    *(esp_1 - 4);
    void* esp_6 = esp_1 - 2;
    char temp10 = *arg2;
    *arg2 = temp10 + *ecx_3[1];
    int32_t* eax_7;
    eax_7 = (eax_6 - 1) - 0xc;
    *0x61011439 += ecx_3;
    int32_t temp11 = *(esi_3 + 1);
    *(esi_3 + 1) += ebp_1;
    *arg2[1] = *arg2[1] - *ecx_3;
    bool c_10 = /* bool c_10 = unimplemented  {sbb dh, byte [ecx]} */;
    eax_7 = eax_7 + 0x3c;
    void* edi_5 = &edi_3[1 + *eax_7];
    eax_7 &= 0x99;
    char temp14 = *ebx[1];
    char temp15 = *(ebx + eax_7);
    *ebx[1] += *(ebx + eax_7);
    
    if (temp14 + temp15 < 0)
    {
        *eax_7 += eax_7;
        
        if (!(eax_7 - 3))
        {
            *(edi_5 * 2 + 0x7191467) += ecx_3;
            /* undefined */
        }
        
        *ecx_3 += eax_7;
        void* ebp_2 = ebp_1 + *(arg2 - 0x3bff3fcd);
        eax_7[4] += ecx_3;
        void* eax_8;
        int16_t edx_1;
        edx_1 = HIGHD(eax_7);
        eax_8 = LOWD(eax_7);
        ebx += ecx_3;
        *(esp_6 + 1);
        void* eax_9;
        eax_9 = (eax_8 + esp_6 + 1) - *ecx_3;
        int32_t temp17_1 = *ecx_3;
        *ecx_3 = ROLD(*ecx_3, 1);
        bool c_12 = /* bool c_12 = unimplemented  {rol dword [ecx], 0x1} */;
        
        if (!ROLD(temp17_1, 1))
        {
            *0x14884692 |= eax_9;
            *0x148f368a |= eax_9;
            *ecx_3 += edx_1;
            void* eax_10;
            eax_10 = ecx_3 ^ 0x95;
            eax_10 = eax_10 - 0x27;
            int32_t temp19 = *(edi_5 + 0x36);
            *(edi_5 + 0x36) += eax_10;
            eax_10 = eax_10 + 9;
            char temp20 = *eax_10[1];
            char temp21 = *(eax_10 * 3 - 0x5f);
            *eax_10[1] += *(eax_10 * 3 - 0x5f);
            eax_10 = eax_10 + 0x21;
            *(esi_3 + 1);
            *(esi_3 + 1) |= ebx;
            eax_10 = eax_10 + 0x29;
            *(esp_6 + 7);
            ebx = 0xf;
            eax_10 = __salc(eflags_1);
            void* eax_11;
            eax_11 = (eax_10 + 0x14b132dc) + 0x22;
            void* ebx_1;
            *ebx_1[1] = 0x14;
            void* esp_15 = esp_6 + 8 + *(edi_5 + 0x19010146);
            void* ecx_5;
            ecx_5 = eax_9 + *edi_5;
            eax_11 = eax_11 + 0x29;
            char temp23 = *eax_11[1];
            *eax_11[1] += *(esi_3 + 1);
            bool c_16 = temp23 + *(esi_3 + 1) < temp23;
            int32_t eflags_2;
            int32_t eip;
            eip = __into(eflags_1);
            eax_11 = eax_11 + 0x29;
            edx_1 += *(eax_11 + 0x1a);
            *(esp_15 - 4) = esp_15;
            *(edi_5 + 0x29010146);
            *edx_1[1] += *(ebp_2 + 0x2914e319);
            edx_1 += *(ecx_5 + 0x37);
            /* jump -> 0x3a0806df */
        }
        
        *(esp_6 + 3);
        *(esp_6 + 7);
        *(esp_6 + 0xb);
        *(esp_6 + 0x17);
        eax_7 = (*(esp_6 + 0x1f)) + 0x39;
        eax_7 += 0x41;
        **(esp_6 + 0x1b);
        *(esp_6 + 0x1f) = eax_7;
        esp_6 += 0x1f;
        eax_7 += 0xd;
    }
    
    *(eax_7 + 0xa);
    eax_7 = eax_7 + 0x19;
    *esp_6;
    /* undefined */
}

void __convention("regparm") sub_10013d66(void* arg1, int32_t* arg2, int32_t* arg3, char* arg4 @ esi) __noreturn
{
    arg3[2] |= 0x9821215;
    *arg2 += arg2;
    *arg3[1] -= 0x13;
    void* ebx;
    *(ebx + 0x12ed8012) &= arg1;
    arg3[3] |= 0x8212150c;
    *arg3;
    *arg3 |= arg1;
    arg1 = arg1 + *(arg1 + 0x12150aed);
    arg1 = arg1 + *(arg1 + 0x75011ed);
    *arg2;
    arg1 |= *arg2;
    arg1 = arg1 + *(arg1 + 0x25011ed);
    int16_t es;
    uint32_t var_4 = es;
    uint32_t* esp = &var_4;
    arg1 += *0x80120107;
    arg1 = arg1 + *(arg2 + 0x120e026d);
    *0x9413350f;
    char* ecx;
    ecx = 0xb + *arg4;
    bool c_2 = 0xb + *arg4 < 0xb;
    char temp7 = arg1;
    char temp8 = *(arg1 + 0x121506bd);
    arg1 = temp7 + temp8;
    
    if (temp7 + temp8)
    {
        uint32_t* var_8 = &var_4;
        esp = &var_8;
        arg1 += *arg4;
    }
    else
        arg2 = arg2 + *(arg2 + arg1 + 6);
    
    int16_t cs;
    *(esp - 4) = cs;
    int16_t es_1 = *(esp - 4);
    *(arg4 + ecx) += arg1;
    *(esp - 6) = cs;
    *(esp - 0xa) = cs;
    *(esp - 0xe) = cs;
    *(esp - 0x12) = cs;
    arg1 += *arg4;
    *(arg2 + 0x20038917);
    *(arg2 + 0x20038917) ^= 0xe;
    *(esp - 0x16) = cs;
    bool c_4 = /* bool c_4 = unimplemented  {sbb eax, 0x1561110d} */;
    int32_t temp11 = *(ecx + 2);
    *(ecx + 2) = temp11 + 0x12012006;
    *(esp - 0x1a) = cs;
    char temp12 = ecx;
    ecx += 2;
    char* eax_3 = (arg1 | 0x12060717) - 0x1561110d - 0x12150c0d + 0xe026911;
    *(esp - 0x1e) = cs;
    ecx += *eax_3;
    *ecx;
    eax_3 |= *ecx;
    *(esp - 0x22) = cs;
    *(esp - 0x26) = es_1;
    *(esp - 0x2a) = cs;
    int32_t eax_5;
    eax_5 = (eax_3 + 0xe026911 + 0xe026911) + 0x20;
    *arg2 += eax_5;
    *arg2 += arg2;
    *(esp - 0x2e) = 0x12012006;
    *(esp - 0x32) = cs;
    arg2 += *0xe026911;
    *0xe026911 += arg2;
    void* eax_6 = *arg2 * 0x50d1d0e;
    int16_t es_2 = *(esp - 0x32);
    *arg2 += arg2;
    bool c_8 = *(eax_6 + 0x55120603) < 8;
    *(esp - 0x34) = cs;
    int32_t eax_8 = eax_6 + 0x2c18012 - 0x1215080d;
    *0x1f1e2e08 &= 0xf;
    *arg2;
    *arg2 &= eax_8;
    int32_t temp23 = *ecx;
    int32_t* eax_9 = eax_8 + temp23;
    bool c_10 = eax_8 + temp23 < eax_8;
    int32_t temp25 = *eax_9;
    int32_t eax_10 = eax_9 + temp25;
    bool c_11 = eax_9 + temp25 < eax_9 || (c_10 && eax_9 + temp25 == eax_9);
    int32_t* eax_11 = eax_10 + 0x2c18012;
    bool c_12 = eax_10 + 0x2c18012 < eax_10 || (c_11 && eax_10 + 0x2c18012 == eax_10);
    int32_t temp28 = *eax_11;
    int32_t eax_14 = eax_11 + temp28 + *ecx - 0x7fedfef9;
    char temp29 = ecx;
    ecx += *arg4;
    bool c_15 = /* bool c_15 = unimplemented  {sbb eax, 0x300070d} */;
    int32_t eax_16;
    eax_16 = (eax_14 - 0x300070d - 0x8080808) + 7;
    int32_t temp32 = *0x1070408;
    *0x1070408 += ebx;
    *(0x51121507 + ecx) = &ecx[*(0x51121507 + ecx)];
    int32_t eax_17;
    eax_17 = (eax_16 - 0x420070d) | 0xc;
    *0x51121503 = cs;
    *0x511214ff = es_2;
    char temp33 = *arg2;
    *arg2 += (eax_17 + 0xe0e0200);
    *0x511214fb = cs;
    *0x511214f7 = cs;
    bool c_18 = /* bool c_18 = unimplemented  {sbb eax, 0x207111c} */;
    int32_t eax_20 = eax_17 + 0xe0e0200 - 0x207111c + 0x12017512;
    char temp35 = eax_20;
    eax_20 += 0x15;
    *(ecx - 0x7fedfeff) = *(ecx - 0x7fedfeff) + eax_20;
    *ecx = RORB(*ecx, 0x20);
    *0x12017912 += arg2;
    ecx[0x80121509] ^= 0xc1;
    arg2 += *arg2;
    ecx[0x10a0502] ^= 0x12;
    ecx[0x8012150b] ^= 0xc1;
    arg2 += *arg2;
    ecx[0x8c08012] ^= 0xa;
    arg2 += *arg2;
    ecx[0x5c08012] ^= 0xa;
    *arg2 += arg2;
    char temp36 = eax_20;
    eax_20 += 7;
    char* eax_21;
    eax_21 = (eax_20 + 0x12017512) + 9;
    *eax_21;
    *eax_21 &= eax_21;
    int32_t* eax_22 = eax_21 + 0x1018111;
    void* eax_23 = eax_22 + *eax_22;
    *0x1018111;
    *0x1018111 |= arg2;
    eax_23 = eax_23 + *(eax_23 + 0x11006c0);
    *0xa03001e += ebx;
    int32_t temp40 = *(ecx * 2);
    *(ecx * 2) += ebx;
    bool c_22 = temp40 + ebx < temp40;
    void* eax_24 = eax_23 + 0x2c18012;
    eax_24 = eax_24 + *(eax_24 + 0x10210ec0);
    char temp42 = eax_24;
    eax_24 += *arg2;
    bool c_24 = temp42 + *arg2 < temp42;
    void* eax_26 = eax_24 + 0x1c58012 + 0x2098112;
    int16_t ds;
    *0x511214f3 = ds;
    *arg4 += ebx;
    *0x1c58012 += arg2;
    *0x511214ef = ds;
    *0x2c18012 += arg2;
    *0x511214eb = ds;
    *arg4 += ebx;
    *arg4 += eax_26;
    *arg2;
    eax_26 |= *arg2;
    char temp47 = eax_26;
    char temp48 = *(eax_26 + 0x15100ec0);
    eax_26 = temp47 + temp48;
    eax_26 = eax_26 + *(eax_26 + 0x121502c1);
    *ecx;
    *ecx |= 0x80120e02;
    *arg2 = RLCB(*arg2, 0x4c, false);
    void* eax_27 = eax_26 | 0x1215020a;
    *ecx;
    *ecx |= 0x80120e02;
    *arg2 = RLCB(*arg2, 0x4c, false);
    bool c_27 = eax_27 >= 0x7fedfef9;
    /* unimplemented  {enter 0x2007, 0x1} */
    char temp52 = (eax_27 - 0x7fedfef9);
    char temp53 = *(eax_27 - 0x7a98ec48);
    void* eax_28;
    eax_28 = temp52 + temp53;
    *0x511214e7 = es_2;
    int32_t eax_29 = eax_28 - 0x100d8112;
    bool c_29 = /* bool c_29 = unimplemented  {sbb eax, 0x100d8112} */;
    char eax_30 = eax_29 + 0x2c18012;
    bool c_30 = eax_29 + 0x2c18012 < eax_29 || (c_29 && eax_29 + 0x2c18012 == eax_29);
    char temp57 = ecx[0x8012150d];
    bool c_31 = eax_30 + temp57 < eax_30 || (c_30 && eax_30 + temp57 == eax_30);
    int32_t eax_31;
    int16_t ds_1;
    eax_31 = __lds_gprz_memp(*ecx);
    char temp58 = eax_31;
    char temp59 = ecx[0x20a0811];
    eax_31 = temp58 + temp59;
    eax_31 = eax_31 + ecx[0x1181120d];
    *0x2c18012;
    char* edx = arg2 | *0x2c18012;
    eax_31 = eax_31 + ecx[0x15811211];
    *edx |= ecx;
    char temp62 = edx;
    char temp63 = *edx;
    edx += *edx;
    bool c_33 = temp62 + temp63 < temp62;
    int32_t temp64 = *ecx;
    *ecx = temp64 + 0x9158112;
    bool c_34 = temp64 + 0x9158112 < temp64 || (c_33 && temp64 + 0x9158112 == temp64);
    int32_t eax_32;
    eax_32 = (eax_31 + 0x2c18012) + ecx[0xa050215];
    int32_t temp66 = *edx;
    *edx = &edx[*edx];
    bool c_36 = &edx[temp66] < temp66;
    int32_t temp67 = *0x80121509;
    *0x80121509 = temp67 - 0x7eedfd3f;
    bool c_37 = temp67 - 0x7eedfd3f < temp67 || (c_36 && temp67 - 0x7eedfd3f == temp67);
    bool c_38 = eax_32 + 0x20a060e < eax_32 || (c_37 && eax_32 + 0x20a060e == eax_32);
    char temp69 = (eax_32 + 0x20a060e);
    char temp70 = ecx[0x15100e15];
    void* eax_33;
    eax_33 = temp69 + temp70;
    eax_33 = eax_33 + *(eax_33 + 0x121502c1);
    *ecx;
    *ecx |= 0x81120e02;
    char temp72 = edx;
    edx += *0x2098112;
    bool c_40 = temp72 + *0x2098112 < temp72;
    *0x511214e3 = cs;
    char* eax_34;
    eax_34 = (eax_33 + 0xa0d4c12) + ecx[0x94c1215];
    *eax_34;
    *eax_34 &= eax_34;
    *0x80121509 -= 0x7eedfd3f;
    ecx[0x12150b05];
    ecx += 2;
    ecx[0xc0801205];
    *edx |= ecx;
    edx += *edx;
    *0x9c08012 -= 0x7fedfdf9;
    breakpoint();
}

int32_t _CorDllMain()
{
    /* tailcall */
    return _CorDllMain();
}

